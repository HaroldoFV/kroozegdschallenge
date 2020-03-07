using System.Collections.Generic;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Microsoft.AspNetCore.Mvc;
using Krooze.EntranceTest.Application.Models;
using Krooze.EntranceTest.Application.Services;
using Newtonsoft.Json.Linq;

namespace Krooze.EntranceTest.Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class CruiseController : ControllerBase
    {
        private readonly CruiseService _cruiseService;

        public CruiseController(CruiseService cruiseService)
        {
            _cruiseService = cruiseService;
        }

        [HttpGet]
        [Route("cruises/companies/{cruiseCompanyCode}")]
        public List<CruiseDTO> GetCruises(int cruiseCompanyCode)
        {
            return _cruiseService.GetCruises(cruiseCompanyCode);
        }

        [HttpGet]
        [Route("cruises/cabinValue/{cabinValue}/portCharge/{portCharge}/totalValue/{totalValue}/rate")]
        public decimal? GetOtherTaxes(decimal cabinValue, decimal portCharge, decimal totalValue)
        {
            return _cruiseService.GetOtherTaxes(cabinValue, portCharge, totalValue);
        }

        [HttpPost]
        [Route("cruises/discount")]
        public bool? IsThereDiscount([FromBody] PassengerCruiseModel request)
        {
            return _cruiseService.IsThereDiscount(request);
        }

        [HttpGet]
        [Route("cruises/GetInstallments/fullPrice/{fullPrice}")]
        public int? GetInstallments(decimal fullPrice)
        {
            return _cruiseService.GetInstallments(fullPrice);
        }

        [HttpGet]
        [Route("cruises/translateXML")]
        public CruiseDTO TranslateXML()
        {
            return _cruiseService.TranslateXML();
        }

        [HttpGet]
        [Route("movies")]
        public JObject GetAllMovies()
        {
            return _cruiseService.GetAllMovies();
        }

        [HttpGet]
        [Route("director")]
        public string GetDirector()
        {
            return _cruiseService.GetDirector();
        }



    }
}
