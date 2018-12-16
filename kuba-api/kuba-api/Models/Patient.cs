using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kubaapi.Models
{
    public class Patient
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
    }
}
