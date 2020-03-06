using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Krooze.EntranceTest.WriteHere.Serializers
{
    [XmlRoot(ElementName = "Pax")]
    public class Pax
    {
        [XmlElement(ElementName = "AllInclBnsComm")]
        public string AllInclBnsComm { get; set; }
        [XmlElement(ElementName = "AllInclBnsCommBfrDisc")]
        public string AllInclBnsCommBfrDisc { get; set; }
        [XmlElement(ElementName = "AllInclComm")]
        public string AllInclComm { get; set; }
        [XmlElement(ElementName = "AllInclCommBfrDisc")]
        public string AllInclCommBfrDisc { get; set; }
        [XmlElement(ElementName = "AllInclNet")]
        public string AllInclNet { get; set; }
        [XmlElement(ElementName = "AllInclNetBfrDisc")]
        public string AllInclNetBfrDisc { get; set; }
        [XmlElement(ElementName = "AllInclStdComm")]
        public string AllInclStdComm { get; set; }
        [XmlElement(ElementName = "AllInclStdCommBfrDisc")]
        public string AllInclStdCommBfrDisc { get; set; }
        [XmlElement(ElementName = "AllInclusivePerPax")]
        public string AllInclusivePerPax { get; set; }
        [XmlElement(ElementName = "AllInclusivePerPaxBfrDisc")]
        public string AllInclusivePerPaxBfrDisc { get; set; }
        [XmlElement(ElementName = "Charge")]
        public List<Charge> Charge { get; set; }
        [XmlAttribute(AttributeName = "PaxID")]
        public string PaxID { get; set; }
    }
}
