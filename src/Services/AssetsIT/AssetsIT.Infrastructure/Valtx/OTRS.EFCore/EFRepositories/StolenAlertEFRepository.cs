using AssetsIT.Domain.AggregatesModel.StolenAlertAggregate;
using AssetsIT.Domain.AggregatesModel.TicketAggregate;
using AssetsIT.Infrastructure.Valtx.OTRS.OTRSClient;
using AssetsIT.Infrastructure.Valtx.OTRS.OTRSModels.Request;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EntityFramework.Repositories
{
    public class StolenAlertEFRepository : IStolenAlertRepository
    {
        private readonly OTRSClientRest _OTRSClientRest;
        private OTRSContext _OTRSContext;
        private OTRSOptions _OTRSOptions;

        public StolenAlertEFRepository(OTRSClientRest OTRSClientRest,
            OTRSContext OTRSContext, IOptionsMonitor<OTRSOptions> OTRSOptions) {
            _OTRSClientRest = OTRSClientRest;
            _OTRSContext = OTRSContext;
            _OTRSOptions = OTRSOptions.CurrentValue;
        }

        public TicketCreateResponse AddStolenAlert(TicketCredencials ticketCredencials, StolenAlert stolenAlert) {
            var service = _OTRSContext.VwService.Find(stolenAlert.OtrsServiceId);

            TicketBodyCreateRequest ticketRequest = new TicketBodyCreateRequest();
            ticketRequest.Ticket = new TicketParametersCreateRequest() {
                Title = _OTRSOptions.StolenAlertTicketTitle + " " + stolenAlert.Asset.Name,
                CustomerUser = stolenAlert.UserCip,
                Queue = _OTRSOptions.StolenAlertQueueName,
                Priority = _OTRSOptions.TicketPriorityLow,
                State = _OTRSOptions.TicketStateNew,
                TypeID = int.Parse(service.TypeService),
                ServiceID = service.Id
            };
            ticketRequest.Article = new ArticleRequest() {
                Subject = service.TypeServiceName,
                Body = $"Robo del siguiente activo: Código: {stolenAlert.Asset.Id}, Modelo: {stolenAlert.Asset.Name}, Serie: {stolenAlert.Asset.SerieNro}",
                ContentType = "text/plain; charset=utf8",
                SenderType = "customer",
                TimeUnit = "0"
            };

            List<AttachmentRequest> attachments = new List<AttachmentRequest>
            {
                new AttachmentRequest { Content = stolenAlert.PoliceReport.Base64, ContentType = stolenAlert.PoliceReport.ContentType, Filename = stolenAlert.PoliceReport.FileName },
                new AttachmentRequest { Content = stolenAlert.Affidavit.Base64, ContentType = stolenAlert.Affidavit.ContentType, Filename = stolenAlert.Affidavit.FileName }
            };

            var result = _OTRSClientRest.GenerateTicketCreateRequest(ticketCredencials, ticketRequest, attachments);

            return result;
        }
    }
}