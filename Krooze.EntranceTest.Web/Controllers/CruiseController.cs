using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Tests.InjectionTests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Krooze.EntranceTest.Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class CruiseController : ControllerBase
    {
        [HttpGet]
        [Route("cruise/company/{cruiseCompanyCode}")]
        public List<CruiseDTO> GetCruises(int cruiseCompanyCode)
        {
            InjectionTest injectionTest = new InjectionTest();
            return injectionTest.GetCruises(new CruiseRequestDTO() { CruiseCompanyCode = cruiseCompanyCode });
        }

        // GET: api/Cruise/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cruise
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cruise/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
