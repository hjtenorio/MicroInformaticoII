using AssetsIT.Domain.AggregatesModel.TicketAggregate;
using AssetsIT.Infrastructure.Valtx.OTRS.OTRSClient;
using AssetsIT.Infrastructure.Valtx.OTRS.OTRSModels.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFRepositories
{
    public class TicketEFRepository : ITicketRepository
    {
        private readonly OTRSClientRest _OTRSClientRest;
        private OTRSContext _OTRSContext;
        private OTRSOptions _OTRSOptions;

        public TicketEFRepository(OTRSClientRest OTRSClientRest,
                                    OTRSContext OTRSContext,
                                    IOptionsMonitor<OTRSOptions> OTRSOptions) {
            _OTRSClientRest = OTRSClientRest;
            _OTRSContext = OTRSContext;
            _OTRSOptions = OTRSOptions.CurrentValue;
        }

        #region OTRSContext
        public async Task<IEnumerable<TicketListResponse>> GetListTicketByCustomerId(TicketsEmployeeSearch search) {
            var response = await _OTRSContext.SpListTicketsByUser.FromSqlInterpolated(
                    $"CALL sp_list_tickets_by_user({search.SearchContent},{search.StartDate},{search.EndtDate},{search.ServiceTypeId},{search.TicketStatusId},{search.CustomerId});"
                ).ToListAsync();

            var result = (from tk in response
                          select new TicketListResponse {
                              Id = tk.Id,
                              TicketNumber = tk.Tn,
                              ServiceTypeId = tk.IdTipoSolicitud,
                              ServiceType = tk.TipoSolicitud,
                              Title = tk.Solicitud,
                              CreateTime = tk.FechaSolicitud,
                              StatusId = tk.IdEstado,
                              Status = tk.Estado
                          }).ToList();
            return result;
        }

        public async Task<TicketDetail> GetTicketDetailByNroTicket(string nroTicket) {
            var ticket = (from tk in _OTRSContext.Ticket
                          join tt in _OTRSContext.TicketType on tk.TicketPriorityId equals tt.Id
                          where tk.Tn == nroTicket
                          select new TicketDetail {
                              Id = tk.Id,
                              Tn = tk.Tn,
                              Title = tk.Title,
                              TicketPriorityId = tk.TicketPriorityId,
                              TicketPriority = tt.Name,
                              CustomerId = tk.CustomerId,
                              CreateTime = tk.CreateTime,
                          }).FirstOrDefault();

            var articleTicket = await (from ar in _OTRSContext.Article
                                       where ar.TicketId == ticket.Id
                                       orderby ar.Id ascending
                                       select new TicketArticle {
                                           Id = ar.Id,
                                           TicketId = ar.TicketId,
                                           ABody = ar.ABody
                                       }).FirstOrDefaultAsync();

            TicketDetail result = new TicketDetail {
                Id = ticket.Id,
                Tn = ticket.Tn,
                Title = ticket.Title,
                TicketPriorityId = ticket.TicketPriorityId,
                TicketPriority = ticket.TicketPriority,
                CustomerId = ticket.CustomerId,
                CreateTime = ticket.CreateTime,
                TicketArticle = articleTicket
            };

            return result;
        }

        public async Task<IEnumerable<TicketState>> GetTicketState() {
            var result = (from ts in _OTRSContext.TicketState
                          where ts.ValidId == 1 && ts.NameSpn != null
                          select new TicketState {
                              Id = ts.Id,
                              Name = ts.Name
                          });

            return await result.ToListAsync();
        }
        #endregion

        #region OTRS Rest API
        public TicketCreateResponse AddTicketIncidenceOtrs(TicketCredencials ticketCredencials, TicketIncidenceCreate ticket) {
            var service = _OTRSContext.VwService.Find(ticket.OtrsServiceId);

            TicketBodyCreateRequest ticketRequest = new TicketBodyCreateRequest {
                Ticket = new TicketParametersCreateRequest() {
                    Title = service.Name + ": " + ticket.Asset.Name,
                    CustomerUser = ticket.UserCip,
                    Queue = _OTRSOptions.TicketIncidenceQueueName,
                    Priority = _OTRSOptions.TicketPriorityLow,
                    State = _OTRSOptions.TicketStateNew,
                    TypeID = int.Parse(service.TypeService),
                    ServiceID = service.Id
                },
                Article = new ArticleRequest() {
                    Subject = service.TypeServiceName,
                    Body = ticket.Description,
                    ContentType = "text/plain; charset=utf8",
                    SenderType = "customer",
                    TimeUnit = "0"
                }
            };
            List<AttachmentRequest> attachments = new List<AttachmentRequest>();
            foreach (TicketAttachments file in ticket.Attachments) {
                attachments.Add(new AttachmentRequest { Content = file.Base64, ContentType = file.ContentType, Filename = file.FileName });
            }

            TicketCreateResponse response = null;

            try {
                response = _OTRSClientRest.GenerateTicketCreateRequest(ticketCredencials, ticketRequest, attachments);
            } catch (System.Exception) {

                throw;
            }


            return response;
        }

        public TicketCreateResponse AddTicketNoRenewOtrs(TicketCredencials ticketCredencials, TicketIncidenceCreate ticket) {
            var service = _OTRSContext.VwService.Find(ticket.OtrsServiceId);

            TicketBodyCreateRequest ticketRequest = new TicketBodyCreateRequest {
                Ticket = new TicketParametersCreateRequest() {
                    Title = service.Name,
                    CustomerUser = ticket.UserCip,
                    Queue = _OTRSOptions.AssetReturnQueueName,
                    Priority = _OTRSOptions.TicketPriorityLow,
                    State = _OTRSOptions.TicketStateNew,
                    TypeID = int.Parse(service.TypeService),
                    ServiceID = service.Id
                },
                Article = new ArticleRequest() {
                    Subject = _OTRSOptions.TicketArticleSubjectNoRenew + " " + ticket.Asset.Name,
                    Body = ticket.Description,
                    ContentType = "text/plain; charset=utf8",
                    SenderType = "customer",
                    TimeUnit = "0"
                }
            };
            List<AttachmentRequest> attachments = new List<AttachmentRequest>();
            foreach (TicketAttachments file in ticket.Attachments) {
                attachments.Add(new AttachmentRequest { Content = file.Base64, ContentType = file.ContentType, Filename = file.FileName });
            }

            var result = _OTRSClientRest.GenerateTicketCreateRequest(ticketCredencials, ticketRequest, attachments);

            return result;
        }

        public TicketUpdateResponse UpdateTicketOtrs(TicketCredencials ticketCredencials, TicketIncidenceCreate ticket) {
            TicketBodyUpdateRequest ticketRequest = new TicketBodyUpdateRequest {
                Article = new ArticleRequest() {
                    Subject = _OTRSOptions.TicketArticleSubjectUpdate,
                    Body = ticket.Description,
                    ContentType = "text/plain; charset=utf8",
                    SenderType = "customer",
                    TimeUnit = "0"
                }
            };
            List<AttachmentRequest> attachments = new List<AttachmentRequest>();
            foreach (TicketAttachments file in ticket.Attachments) {
                attachments.Add(new AttachmentRequest { Content = file.Base64, ContentType = file.ContentType, Filename = file.FileName });
            }

            var result = _OTRSClientRest.GenerateTicketUpdateRequest(ticket.TicketId, ticketCredencials, ticketRequest, attachments);

            return result;
        }
        #endregion
    }
}