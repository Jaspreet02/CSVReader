using CSVReader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSVReader.Services
{
   public interface ICsvParserService<T> where T : class
    {
        List<T> ReadCsvFile(string path);
    }
}
