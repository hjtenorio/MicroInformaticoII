using AssetsIT.Domain.AggregatesModel.TrackingAggregate;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFRepositories
{
    public class TrackingEFRepository : ITrackingRepository
    {
        private OTRSContext _OTRSContext;

        public TrackingEFRepository(OTRSContext OTRSContext) {
            _OTRSContext = OTRSContext;
        }

        public async Task<IEnumerable<QueueTicket>> GetListQueueTicket(string nroTicket) {
            var response = _OTRSContext.SpCabeceraTracking.FromSqlInterpolated($"CALL sp_cabecera_tracking({nroTicket});");

            var result = (from p in response
                          select new QueueTicket {
                              TicketNumber = p.Tin,
                              TypeID = p.IdTipo,
                              Type = p.Tipo,
                              Work = p.Tarea,
                              Queue = p.Cola,
                              ProcessQueue = p.FlujoCola,
                              StartTime = p.Temp1,
                              EndTime = p.Temp2,
                              DiferenceTime = p.Diferencia,
                              Status = p.Estado
                          });

            return await result.ToListAsync();
        }

        public async Task<IEnumerable<QueueDetailTicket>> GetListQueueDetailTicket(string nroTicket, string nameQueue) {
            var response = await _OTRSContext.SpDetalleTracking.FromSqlInterpolated($"CALL sp_detalle_tracking({nroTicket},{nameQueue});").ToListAsync();

            var result = (from qd in response
                          select new QueueDetailTicket {
                              QueueId = qd.QueueId,
                              ArticuleId = qd.ArticuloId,
                              ABody = qd.ABody,
                              CreatedTime = qd.CreatedTime,
                              CreatedBy = qd.CreadoPor,
                              Especialist = qd.Especialista,
                              HistoryType = qd.TipoHistoria,
                              QueueDetailAttachments = GetListQueueDetailAttachmentTicket(nroTicket, nameQueue, qd.ArticuloId)
                          }).ToList();
            return result;
        }

        private List<QueueDetailAttachmentTicket> GetListQueueDetailAttachmentTicket(string nroTicket, string nameQueue, int articuleId) {
            var response = _OTRSContext.SpDetalleAdjuntosTracking.FromSqlInterpolated($"CALL sp_detalle_adjunto_tracking({nroTicket},{nameQueue},{articuleId});").ToList();

            var result = (from qd in response
                          select new QueueDetailAttachmentTicket {
                              ArticuleId = qd.ArticuloId,
                              ContentType = qd.ContentType,
                              FileName = qd.NombreArchivo,
                              Content = qd.Content
                          }).ToList();
            return result;
        }
    }
}