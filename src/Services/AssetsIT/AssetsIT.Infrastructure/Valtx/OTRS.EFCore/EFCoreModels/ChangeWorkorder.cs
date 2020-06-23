using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class ChangeWorkorder
    {
        public long Id { get; set; }
        public long ChangeId { get; set; }
        public int WorkorderNumber { get; set; }
        public string Title { get; set; }
        public string Instruction { get; set; }
        public string InstructionPlain { get; set; }
        public string Report { get; set; }
        public string ReportPlain { get; set; }
        public int WorkorderStateId { get; set; }
        public int WorkorderTypeId { get; set; }
        public int? WorkorderAgentId { get; set; }
        public DateTime PlannedStartTime { get; set; }
        public DateTime PlannedEndTime { get; set; }
        public DateTime ActualStartTime { get; set; }
        public DateTime ActualEndTime { get; set; }
        public decimal PlannedEffort { get; set; }
        public decimal AccountedTime { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
    }
}
