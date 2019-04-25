using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generator
{
    public class RegBaseInfo
    {
        public string Organization { get; set; }
        public string MachineCode { get; set; }
        public string ExpiryDate { get; set; }
    }

    public class RegInfo
    {
        public RegBaseInfo RegBase { get; set; }
        public string Signature { get; set; }
    }
}
