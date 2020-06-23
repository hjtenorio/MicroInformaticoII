using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class CmdbMoviles
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DeployState { get; set; }
        public string InciState { get; set; }
        public string Owner { get; set; }
        public string CostCenter { get; set; }
        public string BenefCenter { get; set; }
        public string Ccr { get; set; }
        public string Line { get; set; }
        public string Rpm { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public string ImeiChip { get; set; }
        public string Type { get; set; }
        public DateTime? DateDeliver { get; set; }
        public string Plan { get; set; }
        public string PlanDetail { get; set; }
        public string Note { get; set; }
        public DateTime? FechaEntrega { get; set; }
    }
}
