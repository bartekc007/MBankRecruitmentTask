using F1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Domain.Dto
{
    public class BaseCollection<T> where T : EntityBase
    {
        public IEnumerable<T> Data { get; set; }
        public int ElementCount { get; set; }
        public int PageSize { get; set; } =  25;
    }
}
