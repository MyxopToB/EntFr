using System;
using System.Collections.Generic;

namespace EntFr
{
    public partial class Hdd
    {
        public int HddId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public short? Capacity { get; set; }
        public string SerialNumber { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
