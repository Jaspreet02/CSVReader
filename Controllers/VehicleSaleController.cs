using CSVReader.Model;
using CSVReader.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;

namespace CSVReader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleSaleController : ControllerBase
    {
        private readonly ICsvParserService<PageResponse> _service;
        public VehicleSaleController(CsvParserService service)
        {
            _service = service;
        }

        [HttpGet()]
        public IEnumerable<PageResponse> Get()
        {
            var path = Directory.GetCurrentDirectory();
            return _service.ReadCsvFile(path + "\\Resources\\Dealertrack.csv");
        }
    }
}
