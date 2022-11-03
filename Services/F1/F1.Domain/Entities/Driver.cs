using F1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Domain.Entities
{
    public class Driver : EntityBase
    {
        public string Ref { get; set; }
        public string Number { get; set; }
        public string code { get; set; }
        public string forename { get; set; }
        public string surename { get; set; }
        public string dob { get; set; }
        public string natonality { get; set; }
    }
}
