using System;
using System.Collections.Generic;

namespace EntFr
{
    public partial class Stamps
    {
        public int StampId { get; set; }
        public string Number { get; set; }
        public DateTime? OpeningDate { get; set; }
        public DateTime? FillingDate { get; set; }
    }
}
