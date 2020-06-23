using System;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public partial class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short ValidId { get; set; }
        public string Comments { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
        public int? TypeId { get; set; }
        public string Criticality { get; set; }
        public string TypeService { get; set; }
    }
}
