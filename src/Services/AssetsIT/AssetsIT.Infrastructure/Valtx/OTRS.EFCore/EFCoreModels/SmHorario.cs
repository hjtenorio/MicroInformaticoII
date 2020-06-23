using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SmHorario
    {
        public int IdHor { get; set; }
        public TimeSpan? HorInicio { get; set; }
        public TimeSpan? HorFin { get; set; }
    }
}
