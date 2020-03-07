using Krooze.EntranceTest.Application.Models;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Tests.InjectionTests;
using Krooze.EntranceTest.WriteHere.Tests.LogicTests;
using Krooze.EntranceTest.WriteHere.Tests.WebTests;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Krooze.EntranceTest.Application.Services
{
    public class CruiseService
    {
        private readonly InjectionTest _injectionTest;
        private readonly SimpleLogicTest _simpleLogicTest;
        private readonly XMLTest _xMLTest;
        private readonly WebTest _webTest;

        public CruiseService(InjectionTest injectionTest, SimpleLogicTest simpleLogicTest, XMLTest xMLTest, WebTest webTest)
        {
            _injectionTest = injectionTest;
            _simpleLogicTest = simpleLogicTest;
            _xMLTest = xMLTest;
            _webTest = webTest;
        }

        public List<CruiseDTO> GetCruises(int cruiseCompanyCode)
        {
            return _injectionTest.GetCruises(new CruiseRequestDTO() { CruiseCompanyCode = cruiseCompanyCode });
        }

        public decimal? GetOtherTaxes(decimal cabinValue, decimal portCharge, decimal totalValue)
        {
            return _simpleLogicTest.GetOtherTaxes(new CruiseDTO() { CabinValue = cabinValue, PortCharge = portCharge, TotalValue = totalValue });
        }

        public bool? IsThereDiscount(PassengerCruiseModel request)
        {
            List<PassengerCruiseDTO> passengerCruise = new List<PassengerCruiseDTO>();
            decimal cabinValue = 0;
            foreach (var item in request.PassengerCruise)
            {
                passengerCruise.Add(
                    new PassengerCruiseDTO()
                    { PassengerCode = item.PassengerCode, Cruise = new CruiseDTO() { CabinValue = item.CabinValue } }
                    );
                cabinValue += item.CabinValue;
            }

            var cruise = new CruiseDTO()
            {
                PassengerCruise = passengerCruise,
                CabinValue = cabinValue
            };
            return _simpleLogicTest.IsThereDiscount(cruise);
        }

        public int? GetInstallments(decimal fullPrice)
        {
            return _simpleLogicTest.GetInstallments(fullPrice);
        }

        public CruiseDTO TranslateXML()
        {
            return _xMLTest.TranslateXML();
        }

        public JObject GetAllMovies()
        {
            return _webTest.GetAllMovies();
        }

        public string GetDirector()
        {
            return _webTest.GetDirector();
        }
    }
}
