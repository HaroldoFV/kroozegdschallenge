using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Krooze.EntranceTest.WriteHere.Serializers
{
    [XmlRoot(ElementName = "Cruises")]
    public class Cruises
    {
        [XmlElement(ElementName = "AirMandatory")]
        public string AirMandatory { get; set; }
        [XmlElement(ElementName = "AllInclBnsCommTotal")]
        public string AllInclBnsCommTotal { get; set; }
        [XmlElement(ElementName = "AllInclBnsCommTotalBfrDisc")]
        public string AllInclBnsCommTotalBfrDisc { get; set; }
        [XmlElement(ElementName = "AllInclCommTotal")]
        public string AllInclCommTotal { get; set; }
        [XmlElement(ElementName = "AllInclCommTotalBfrDisc")]
        public string AllInclCommTotalBfrDisc { get; set; }
        [XmlElement(ElementName = "AllInclNetTotal")]
        public string AllInclNetTotal { get; set; }
        [XmlElement(ElementName = "AllInclNetTotalBfrDisc")]
        public string AllInclNetTotalBfrDisc { get; set; }
        [XmlElement(ElementName = "AllInclStdCommTotal")]
        public string AllInclStdCommTotal { get; set; }
        [XmlElement(ElementName = "AllInclStdCommTotalBfrDisc")]
        public string AllInclStdCommTotalBfrDisc { get; set; }
        [XmlElement(ElementName = "AllowedOccupancies")]
        public string AllowedOccupancies { get; set; }
        [XmlElement(ElementName = "ArrivalDate")]
        public string ArrivalDate { get; set; }
        [XmlElement(ElementName = "GuaranteesAvailable")]
        public string GuaranteesAvailable { get; set; }
        [XmlElement(ElementName = "PricedCategory")]
        public string PricedCategory { get; set; }
        [XmlElement(ElementName = "TotalAvailable")]
        public string TotalAvailable { get; set; }
        [XmlElement(ElementName = "BonusCommissionAmtBfrDisc")]
        public string BonusCommissionAmtBfrDisc { get; set; }
        [XmlElement(ElementName = "BonusCommissionAmt")]
        public string BonusCommissionAmt { get; set; }
        [XmlElement(ElementName = "CabinPrice")]
        public string CabinPrice { get; set; }
        [XmlElement(ElementName = "CabinsAvailable")]
        public string CabinsAvailable { get; set; }
        [XmlElement(ElementName = "Canvas")]
        public string Canvas { get; set; }
        [XmlElement(ElementName = "CanvasDesc")]
        public string CanvasDesc { get; set; }
        [XmlElement(ElementName = "Category")]
        public string Category { get; set; }
        [XmlElement(ElementName = "CategoryPriceDetails")]
        public CategoryPriceDetails CategoryPriceDetails { get; set; }
        [XmlElement(ElementName = "CommissionAmt")]
        public string CommissionAmt { get; set; }
        [XmlElement(ElementName = "CommBfrDisc")]
        public string CommBfrDisc { get; set; }
        [XmlElement(ElementName = "ConfigCode")]
        public string ConfigCode { get; set; }
        [XmlElement(ElementName = "CruAvail")]
        public string CruAvail { get; set; }
        [XmlElement(ElementName = "CruiseId")]
        public string CruiseId { get; set; }
        [XmlElement(ElementName = "CruiseLen")]
        public string CruiseLen { get; set; }
        [XmlElement(ElementName = "CurrencyCd")]
        public string CurrencyCd { get; set; }
        [XmlElement(ElementName = "DepartureDate")]
        public string DepartureDate { get; set; }
        [XmlElement(ElementName = "DisembkPort")]
        public string DisembkPort { get; set; }
        [XmlElement(ElementName = "DisembkPortDesc")]
        public string DisembkPortDesc { get; set; }
        [XmlElement(ElementName = "EmbkPort")]
        public string EmbkPort { get; set; }
        [XmlElement(ElementName = "EmbkPortDesc")]
        public string EmbkPortDesc { get; set; }
        [XmlElement(ElementName = "FirstPaxPrice")]
        public string FirstPaxPrice { get; set; }
        [XmlElement(ElementName = "FitAirManagement")]
        public string FitAirManagement { get; set; }
        [XmlElement(ElementName = "InstantConfirm")]
        public string InstantConfirm { get; set; }
        [XmlElement(ElementName = "LimitAirports")]
        public string LimitAirports { get; set; }
        [XmlElement(ElementName = "MaximumOccupancy")]
        public string MaximumOccupancy { get; set; }
        [XmlElement(ElementName = "MaximunOccupancyGar")]
        public string MaximunOccupancyGar { get; set; }
        [XmlElement(ElementName = "PortChargesAmt")]
        public string PortChargesAmt { get; set; }
        [XmlElement(ElementName = "PriceCode")]
        public string PriceCode { get; set; }
        [XmlElement(ElementName = "PriceDesc")]
        public string PriceDesc { get; set; }
        [XmlElement(ElementName = "PriceType")]
        public string PriceType { get; set; }
        [XmlElement(ElementName = "PricedOccupancy")]
        public string PricedOccupancy { get; set; }
        [XmlElement(ElementName = "SecondPaxPrice")]
        public string SecondPaxPrice { get; set; }
        [XmlElement(ElementName = "ShipCd")]
        public string ShipCd { get; set; }
        [XmlElement(ElementName = "ShipName")]
        public string ShipName { get; set; }
        [XmlElement(ElementName = "SngPrice")]
        public string SngPrice { get; set; }
        [XmlElement(ElementName = "StdCommissionAmtBfrDisc")]
        public string StdCommissionAmtBfrDisc { get; set; }
        [XmlElement(ElementName = "StdCommissionAmt")]
        public string StdCommissionAmt { get; set; }
        [XmlElement(ElementName = "SurchargesAmtBfrDisc")]
        public string SurchargesAmtBfrDisc { get; set; }
        [XmlElement(ElementName = "SurchargesAmt")]
        public string SurchargesAmt { get; set; }
        [XmlElement(ElementName = "TotDiscAmt")]
        public string TotDiscAmt { get; set; }
        [XmlElement(ElementName = "TotalAllInclusiveCabinPrice")]
        public string TotalAllInclusiveCabinPrice { get; set; }
        [XmlElement(ElementName = "TotalCabinPriceBfrDisc")]
        public string TotalCabinPriceBfrDisc { get; set; }
        [XmlElement(ElementName = "TotalCabinPrice")]
        public string TotalCabinPrice { get; set; }
        [XmlElement(ElementName = "CABFSAdt")]
        public string CABFSAdt { get; set; }
        [XmlElement(ElementName = "CABSng")]
        public string CABSng { get; set; }
        [XmlElement(ElementName = "CABTAdt")]
        public string CABTAdt { get; set; }
        [XmlElement(ElementName = "CABTChd")]
        public string CABTChd { get; set; }
        [XmlElement(ElementName = "FSAdtPrice")]
        public string FSAdtPrice { get; set; }
        [XmlElement(ElementName = "FUEFSAdt")]
        public string FUEFSAdt { get; set; }
        [XmlElement(ElementName = "FUESng")]
        public string FUESng { get; set; }
        [XmlElement(ElementName = "FUETAdt")]
        public string FUETAdt { get; set; }
        [XmlElement(ElementName = "FUETChd")]
        public string FUETChd { get; set; }
        [XmlElement(ElementName = "GFTFSAdt")]
        public string GFTFSAdt { get; set; }
        [XmlElement(ElementName = "GFTSng")]
        public string GFTSng { get; set; }
        [XmlElement(ElementName = "GFTTAdt")]
        public string GFTTAdt { get; set; }
        [XmlElement(ElementName = "GFTTChd")]
        public string GFTTChd { get; set; }
        [XmlElement(ElementName = "NCFFSAdt")]
        public string NCFFSAdt { get; set; }
        [XmlElement(ElementName = "NCFSng")]
        public string NCFSng { get; set; }
        [XmlElement(ElementName = "NCFTAdt")]
        public string NCFTAdt { get; set; }
        [XmlElement(ElementName = "NCFTChd")]
        public string NCFTChd { get; set; }
        [XmlElement(ElementName = "TAdtPrice")]
        public string TAdtPrice { get; set; }
        [XmlElement(ElementName = "TChdPrice")]
        public string TChdPrice { get; set; }
    }
}
