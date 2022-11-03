using F1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Domain.Entities
{
    public class Circuit : EntityBase
    {
        public string Ref { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Lat { get; set; }
        public string Ing { get; set; }
        public string Alt { get; set; }
    }
}
