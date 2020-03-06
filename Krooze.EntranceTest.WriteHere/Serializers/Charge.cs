using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Krooze.EntranceTest.WriteHere.Serializers
{
    [XmlRoot(ElementName = "Charge")]
    public class Charge
    {
        [XmlElement(ElementName = "BonusCommissionAmtBfrDisc")]
        public string BonusCommissionAmtBfrDisc { get; set; }
        [XmlElement(ElementName = "BonusCommissionAmt")]
        public string BonusCommissionAmt { get; set; }
        [XmlElement(ElementName = "CommissionAmt")]
        public string CommissionAmt { get; set; }
        [XmlElement(ElementName = "CommBfrDisc")]
        public string CommBfrDisc { get; set; }
        [XmlElement(ElementName = "GrossAmountBfrDisc")]
        public string GrossAmountBfrDisc { get; set; }
        [XmlElement(ElementName = "GrossAmount")]
        public string GrossAmount { get; set; }
        [XmlElement(ElementName = "NetAmountBfrDisc")]
        public string NetAmountBfrDisc { get; set; }
        [XmlElement(ElementName = "NetAmount")]
        public string NetAmount { get; set; }
        [XmlElement(ElementName = "StdCommissionAmtBfrDisc")]
        public string StdCommissionAmtBfrDisc { get; set; }
        [XmlElement(ElementName = "StdCommissionAmt")]
        public string StdCommissionAmt { get; set; }
        [XmlElement(ElementName = "TotDiscAmt")]
        public string TotDiscAmt { get; set; }
        [XmlAttribute(AttributeName = "ChargeType")]
        public string ChargeType { get; set; }
    }
}
