using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public class VwService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Service1 { get; set; }
        public string Service2 { get; set; }
        public string Service3 { get; set; }
        public string TypeService { get; set; }
        public string TypeServiceName { get; set; }
        public string ServiceFullName { get; set; }
    }
}
