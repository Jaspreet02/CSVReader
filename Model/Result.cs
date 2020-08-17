using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSVReader.Model
{
    public class PageResponse
    {
        public string  Vehicle { get; set; }
        public int Count { get; set; }
        public IList<VehicleSale> Result { get; set; }
    }
}
