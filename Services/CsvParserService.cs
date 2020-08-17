using CsvHelper;
using CSVReader.Common;
using CSVReader.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVReader.Services
{
    public class CsvParserService : ICsvParserService<PageResponse>
    {
        public List<PageResponse> ReadCsvFile(string path)
        {
            try
            {
                using (var reader = new StreamReader(path, Encoding.Default))
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csvReader.Configuration.RegisterClassMap<CsvMapping>();
                    var records = csvReader.GetRecords<VehicleSale>().GroupBy(x => x.Vehicle.Trim())
                        .Select(grp => new PageResponse { Vehicle = grp.Key, Count = grp.Count(), Result = grp.ToList() }).OrderByDescending(x=> x.Count).ToList();
                    return records;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e)
            {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
