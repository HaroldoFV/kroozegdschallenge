using System;
using System.Collections.Generic;
using System.Text;

namespace Krooze.EntranceTest.Application.Models
{
    public class CruiseModel
    {
        public string CruiseCode { get; set; }
        public decimal TotalValue { get; set; }
        public decimal CabinValue { get; set; }
        public decimal PortCharge { get; set; }
        public string ShipName { get; set; }
        public string PassengerCode { get; set; }

    }

    public class PassengerCruiseModel
    {
        public List<CruiseModel> PassengerCruise { get; set; } 
    }
}

