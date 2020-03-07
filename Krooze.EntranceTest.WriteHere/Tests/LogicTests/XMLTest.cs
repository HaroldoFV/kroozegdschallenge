using Krooze.EntranceTest.WriteHere.Serializers;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class XMLTest
    {
        public CruiseDTO TranslateXML()
        {
            //TODO: Take the Cruises.xml file, on the Resources folder, and translate it to the CruisesDTO object,
            //you can do it in any way, including intermediary objects

            string path = string.Empty;
            path = @"C:\projetos\kroozegdschallenge\Krooze.EntranceTest.WriteHere\Resources\Cruises.xml";

            FileStream stream = new FileStream(path, FileMode.Open);
            XmlSerializer desserializador = new XmlSerializer(typeof(Cruises));
            var cruises = (Cruises)desserializador.Deserialize(stream);

            List<PassengerCruiseDTO> passengerCruise = new List<PassengerCruiseDTO>();
            int count = 0;
            foreach (var item in cruises.CategoryPriceDetails.Pax)
            {
                passengerCruise.Add(new PassengerCruiseDTO
                {
                    PassengerCode = item.PaxID,
                    Cruise = new CruiseDTO
                    {
                        CruiseCode = cruises.CruiseId,
                        ShipName = cruises.ShipName,
                        TotalValue = passengerCruise.Count() == 0 ? Math.Round(Convert.ToDecimal(cruises.TotalCabinPrice.Replace(".", ","))) : 0,
                        CabinValue = passengerCruise.Count() == 0 ? Math.Round(Convert.ToDecimal(cruises.CabinPrice.Replace(".", ","))) : 0,
                        PortCharge = passengerCruise.Count() == 0 ? Math.Round(Convert.ToDecimal(cruises.PortChargesAmt.Replace(".", ","))) : 0
                    }
                });
                count++;
            }

            CruiseDTO cliente = new CruiseDTO
            {
                CruiseCode = cruises.CruiseId,
                ShipName = cruises.ShipName,
                TotalValue = Math.Round(Convert.ToDecimal(cruises.TotalCabinPrice.Replace(".", ","))),
                CabinValue = Math.Round(Convert.ToDecimal(cruises.CabinPrice.Replace(".", ","))),
                PortCharge = Math.Round(Convert.ToDecimal(cruises.PortChargesAmt.Replace(".", ","))),
                PassengerCruise = passengerCruise
            };

            return cliente;
        }
    }
}
