using AssetsIT.API.Models.Response;
using AssetsIT.Domain.AggregatesModel.StolenAlertAggregate;
using AssetsIT.Domain.AggregatesModel.TicketAggregate;
using AutoMapper;

namespace AssetsIT.API.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<FileDTOResponse, PoliceReport>();
            CreateMap<FileDTOResponse, Affidavit>();
            CreateMap<OtrsCredencialsDTOResponse, TicketCredencials>();
            CreateMap<FileDTOResponse, TicketAttachments>();
        }
    }
}
