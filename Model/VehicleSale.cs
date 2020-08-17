using CsvHelper.Configuration.Attributes;
using CSVReader.Common;
using System;

namespace CSVReader
{
    public class VehicleSale
    {
        [Name(Constants.CsvHeaders.DealNumber)]
        public long DealNumber { get; set; }
        [Name(Constants.CsvHeaders.CustomerName)]
        public string CustomerName { get; set; }
        [Name(Constants.CsvHeaders.DealershipName)]
        public string DealershipName { get; set; }
        [Name(Constants.CsvHeaders.Vehicle)]
        public string Vehicle { get; set; }
        [Name(Constants.CsvHeaders.Price)]
        public decimal Price { get; set; }
        [Name(Constants.CsvHeaders.Date)]
        public DateTime Date { get; set; }
        public int Count { get; set; }
    }
}
