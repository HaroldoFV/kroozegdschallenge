using Krooze.EntranceTest.WriteHere.Structure.Model;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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
            XmlSerializer desserializador = new XmlSerializer(typeof(CruiseDTO));
            CruiseDTO cliente = (CruiseDTO)desserializador.Deserialize(stream);
            return cliente;
        }
    }
}
