using F1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Domain.Entities
{
    public class Race : EntityBase
    {
        public string Year { get; set; }
        public string Round { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
