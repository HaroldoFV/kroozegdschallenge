using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Krooze.EntranceTest.WriteHere.Serializers
{
    [XmlRoot(ElementName = "CategoryPriceDetails")]
    public class CategoryPriceDetails
    {
        [XmlElement(ElementName = "Pax")]
        public List<Pax> Pax { get; set; }
    }
}
