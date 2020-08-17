using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSVReader.Common
{
        public sealed class CsvMapping : ClassMap<VehicleSale>
        {
            public CsvMapping()
            {
                Map(m => m.DealNumber).Name(Constants.CsvHeaders.DealNumber);
                Map(m => m.CustomerName).Name(Constants.CsvHeaders.CustomerName);
                Map(m => m.DealershipName).Name(Constants.CsvHeaders.DealershipName);
                Map(m => m.Vehicle).Name(Constants.CsvHeaders.Vehicle);
                Map(m => m.Price).Name(Constants.CsvHeaders.Price);
                Map(m => m.Date).Name(Constants.CsvHeaders.Date);
            }
    }
}
