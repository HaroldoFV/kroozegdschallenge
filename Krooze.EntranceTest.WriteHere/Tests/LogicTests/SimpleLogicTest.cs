using Krooze.EntranceTest.WriteHere.Structure.Model;
using System;
using System.Linq;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class SimpleLogicTest
    {
        public decimal? GetOtherTaxes(CruiseDTO cruise)
        {
            //TODO: Based on the CruisesDTO object, gets if there is some other tax that not the port charge

            var tax = cruise.CabinValue + cruise.PortCharge;

            if (cruise.TotalValue != tax)
                return cruise.TotalValue - tax;
            else
                return 0;
        }

        public bool? IsThereDiscount(CruiseDTO cruise)
        {
            //TODO: Based on the CruisesDTO object, check if the second passenger has some kind of discount, based on the first passenger price
            //Assume there are always 2 passengers on the list
            if (cruise.PassengerCruise[1].Cruise.CabinValue < cruise.PassengerCruise[0].Cruise.CabinValue)
                return true;

            return false;
        }

        public int? GetInstallments(decimal fullPrice)
        {
            //TODO: Based on the full price, find the max number of installments
            // -The absolute max number is 12
            // -The minimum value of the installment is 200
            int? parc = 0;

            if (fullPrice >= 200)
            {
                parc = (int?)(fullPrice / 200);
                if (parc > 12)
                    parc = 12;
            }
            else
            {
                parc = 1;
            }

            return parc;
        }
    }
}
