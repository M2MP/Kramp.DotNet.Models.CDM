using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class AccountingSupplierParty : SupplierParty { }
    public class AccountingCustomerParty : CustomerParty { }

    public class Address
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Name Postbox { get; set; }
        [CommonBasicComponent]
        public Name StreetName { get; set; }
        [CommonBasicComponent]
        public Name AdditionalStreetName { get; set; }
        [CommonBasicComponent]
        public Text BuildingNumber { get; set; }
		[CommonBasicComponent]
		public Text MarkAttention { get; set; }
        [CommonBasicComponent]
        public Name CityName { get; set; }
        [CommonBasicComponent]
        public Text PostalZone { get; set; }
        public Country Country { get; set; }
    }
    
    [XmlRoot(Namespace = Constants.CommonAggregateComponentsNamespace)]
    public class AllowanceCharge
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Indicator ChargeIndicator { get; set; }

        [CommonBasicComponent]
        public Code AllowanceChargeReasonCode { get; set; }

        [CommonBasicComponent]
        public Text AllowanceChargeReason { get; set; }

        [CommonBasicComponent]
        public Numeric MultiplierFactorNumeric { get; set; }

        [CommonBasicComponent]
        public Amount Amount { get; set; }
    }
    public class BillingReference
    {
        [CommonAggregateComponent]
        public DocumentReference InvoiceDocumentReference { get; set; }
    }

    public class BuyerCustomerParty : CustomerParty { }
    public class Country
    {
        [CommonBasicComponent]
        public Code IdentificationCode { get; set; }
    }
    public class DeliveryCustomerParty : CustomerParty { }
    public class CustomerParty
    {
        [CommonBasicComponent]
        public Identifier CustomerAssignedAccountID { get; set; }
        [CommonBasicComponent]
        public Identifier SupplierAssignedAccountID { get; set; }
        [CommonBasicComponent]
        public Identifier AdditionalAccountID { get; set; }
        public Party Party { get; set; }
        public Contact BuyerContact{ get; set; }
    }

    public class PayeeParty
    {
        public Identifier EndpointID { get; set; }
        public PartyIdentification PartyIdentification { get; set; }
        public PartyName PartyName { get; set; }
        public PostalAddress PostalAddress { get; set; }
        public PartyTaxScheme PartyTaxScheme { get; set; }
        public PartyLegalEntity PartyLegalEntity { get; set; }
        public Contact Contact { get; set; }
        public AgentParty AgentParty { get; set; }
    }
    public class AgentParty
    {
        public PartyIdentification PartyIdentification { get; set; }
    }
    public class Delivery
    {
        [CommonBasicComponent]
        public Quantity Quantity { get; set; }
        [CommonBasicComponent]
        public Date ActualDeliveryDate { get; set; }
        public DeliveryParty DeliveryParty { get; set; }
        public RequestedDeliveryPeriod RequestedDeliveryPeriod { get; set; }
        public PromisedDeliveryPeriod PromisedDeliveryPeriod { get; set; }
        public EstimatedDeliveryPeriod EstimatedDeliveryPeriod { get; set; }
        public Despatch Despatch { get; set; }
        public Shipment Shipment { get; set; }
    }
    public class DeliveryParty : Party { }
    public class Dimension
    {
        // TODO
    }

    [XmlRoot(Namespace = Constants.CommonAggregateComponentsNamespace)]
    public class InvoiceLine
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Identifier UUID { get; set; }
        [CommonBasicComponent]
        public Text[] Note { get; set; }
        [CommonBasicComponent]
        public Quantity InvoicedQuantity { get; set; }
        [CommonBasicComponent]
        public Amount LineExtensionAmount { get; set; }
        [CommonBasicComponent]
        public Amount TaxInclusiveLineExtensionAmount { get; set; }
        [CommonBasicComponent]
        public Date TaxPointDate { get; set; }
        [CommonBasicComponent]
        public Code AccountingCostCode { get; set; }
        [CommonBasicComponent]
        public Text AccountingCost { get; set; }
        [CommonBasicComponent]
        public Code PaymentPurposeCode { get; set; }
        [CommonBasicComponent]
        public Indicator FreeOfChargeIndicator { get; set; }
        [CommonBasicComponent]
        public Period[] InvoicePeriod { get; set; }
        [CommonAggregateComponent]
        public OrderLineReference[] OrderLineReference { get; set; }
        [XmlElement]
        public PricingReference[] PricingReference { get; set; }
        public Delivery Delivery { get; set; }
        public TaxTotal TaxTotal { get; set; }
        // TODO
        public Item Item { get; set; }
        public Price Price { get; set; }
        public DeliveryTerms DeliveryTerms { get; set; }
        // TODO
    }

    [XmlRoot(Namespace = Constants.CommonAggregateComponentsNamespace)]
    public class CreditNoteLine
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Identifier UUID { get; set; }
        [CommonBasicComponent]
        public Text[] Note { get; set; }
        [CommonBasicComponent]
        public Quantity CreditedQuantity { get; set; }
        [CommonBasicComponent]
        public Amount LineExtensionAmount { get; set; }
        [CommonBasicComponent]
        public Amount TaxInclusiveLineExtensionAmount { get; set; }
        [CommonBasicComponent]
        public Date TaxPointDate { get; set; }
        [CommonBasicComponent]
        public Code AccountingCostCode { get; set; }
        [CommonBasicComponent]
        public Text AccountingCost { get; set; }
        [CommonBasicComponent]
        public Code PaymentPurposeCode { get; set; }
        [CommonBasicComponent]
        public Indicator FreeOfChargeIndicator { get; set; }
        [CommonBasicComponent]
        public Period[] InvoicePeriod { get; set; }
        [CommonAggregateComponent]
        public OrderLineReference[] OrderLineReference { get; set; }
        [XmlElement]
        public PricingReference[] PricingReference { get; set; }
        public Delivery Delivery { get; set; }
        public TaxTotal TaxTotal { get; set; }
        // TODO
        public Item Item { get; set; }
        public Price Price { get; set; }
        public DeliveryTerms DeliveryTerms { get; set; }
        // TODO
    }
    public class DespatchLine
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }

        [CommonBasicComponent]
        public Quantity DeliveredQuantity { get; set; }

        [CommonAggregateComponent]
        public OrderLineReference OrderLineReference { get; set; }

        [CommonAggregateComponent]
        public Item Item { get; set; }

        [CommonAggregateComponent]
        public Shipment Shipment { get; set; }
    }

    public class OrderLine
    {
        [CommonAggregateComponent]
        public LineItem LineItem { get; set; }
        public OrderLineReference OrderLineReference { get; set; }
    }

    public class LineItem
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }

        [CommonBasicComponent]
        public Quantity Quantity { get; set; }

        [CommonBasicComponent]
        public Amount LineExtensionAmount { get; set; }

        public Delivery Delivery { get; set; }

        public Price Price { get; set; }
        
        public Item Item { get; set; }

    }
    public class RequestedDeliveryPeriod : DeliveryPeriod { }
    public class PromisedDeliveryPeriod : DeliveryPeriod { }
    public class EstimatedDeliveryPeriod : DeliveryPeriod { }
    public class DeliveryPeriod
    {
        [CommonBasicComponent]
        public Date StartDate { get; set; }
        [CommonBasicComponent]
        public Date EndDate { get; set; }
    }

    public class Item
    {
        [CommonBasicComponent]
        public Text[] Description { get; set; }
        [CommonBasicComponent]
        public Quantity PackQuantity { get; set; }
        [CommonBasicComponent]
        public Numeric PackSizeNumeric { get; set; }
        [CommonBasicComponent]
        public Indicator CatalogueIndicator { get; set; }
        [CommonBasicComponent]
        public Name Name { get; set; }
        [CommonBasicComponent]
        public Indicator HazardousRiskIndicator { get; set; }
        [CommonBasicComponent]
        public Text[] AdditionalInformation { get; set; }
        [CommonBasicComponent]
        public Text[] Keyword { get; set; }
        [CommonBasicComponent]
        public Text[] BrandName { get; set; }
        [CommonBasicComponent]
        public Text[] ModelName { get; set; }
        public ItemIdentification BuyersItemIdentification { get; set; }
        public ItemIdentification SellersItemIdentification { get; set; }
        public ItemIdentification ManufacturersItemIdentification { get; set; }
        public ItemIdentification StandardItemIdentification { get; set; }
        public ItemIdentification CatalogueItemIdentification { get; set; }
        [XmlElement]
        public ItemIdentification[] AdditionalItemIdentification { get; set; }
        public OriginCountry OriginCountry { get; set; }
        public ClassifiedTaxCategory ClassifiedTaxCategory { get; set; }
        public ItemInstance ItemInstance { get; set; }
        //TODO
    }
    public class ClassifiedTaxCategory
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Name Name { get; set; }
        [CommonBasicComponent]
        public Percent Percent { get; set; }
        public TaxScheme TaxScheme { get; set; }
    }
    public class ItemInstance
    {
        public LotIdentification LotIdentification { get; set; }
    }
    public class LotIdentification
    {
        [XmlElement]
        public AdditionalItemProperty[] AdditionalItemProperty { get; set; }
    }
    public class AdditionalItemProperty
    {
        [CommonBasicComponent]
        public Name Name { get; set; }
        [CommonBasicComponent]
        public Text Value { get; set; }
    }
    public class OriginCountry : Country { }
    public class ItemIdentification
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Identifier ExtendedID { get; set; }
        [CommonBasicComponent]
        public Identifier BarcodeSymbologyID { get; set; }
        [CommonBasicComponent]
        public Identifier IssuerScopeID { get; set; }
        public PhysicalAttribute[] PhysicalAttribute { get; set; }
        public Dimension[] MeasurementDimension { get; set; }
        public Party[] IssuerParty { get; set; }

    }
    public class LegalMonetaryTotal : MonetaryTotal {}
    public class MonetaryTotal
    {
        [CommonBasicComponent]
        public Amount LineExtensionAmount { get; set; }
        [CommonBasicComponent]
        public Amount TaxExclusiveAmount { get; set; }
        [CommonBasicComponent]
        public Amount TaxInclusiveAmount { get; set; }
        [CommonBasicComponent]
        public Amount AllowanceTotalAmount { get; set; }
        [CommonBasicComponent]
        public Amount ChargeTotalAmount { get; set; }
        [CommonBasicComponent]
        public Amount WithholdingTaxTotalAmount { get; set; }
        [CommonBasicComponent]
        public Amount PrepaidAmount { get; set; }
        [CommonBasicComponent]
        public Amount PayableRoundingAmount { get; set; }
        [CommonBasicComponent]
        public Amount PayableAmount { get; set; }
        [CommonBasicComponent]
        public Amount PayableAlternativeAmount { get; set; }
    }
    public class OrderLineReference
    {
        [CommonBasicComponent]
        public Identifier LineID { get; set; }
        [CommonBasicComponent]
        public Identifier SalesOrderLineID { get; set; }
        [CommonBasicComponent]
        public Identifier UUID { get; set; }
        [CommonBasicComponent]
        public Code LineStatusCode { get; set; }
        public OrderReference OrderReference { get; set; }
    }
    public class OrderReference
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Identifier SalesOrderID { get; set; }
        [CommonBasicComponent]
        public Date IssueDate { get; set; }
        [CommonBasicComponent]
        public Text CustomerReference { get; set; }
        
        public DocumentReference DocumentReference { get; set; }
    }
    public class DocumentReference
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Text DocumentType { get; set; }
    }
    public class Shipment
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }

        public GoodsItem GoodsItem { get; set; }

        [CommonAggregateComponent]
        public Delivery Delivery { get; set; }
    }
    public class GoodsItem
    {
        [CommonBasicComponent]
        public Identifier RequiredCustomsID { get; set; }
    }
    public class Despatch
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Date EstimatedDespatchDate { get; set; }
        [CommonBasicComponent]
        public Date ActualDespatchDate { get; set; }
    }
    public class PricingReference
    {
        [XmlElement]
        public Price[] AlternativeConditionPrice { get; set; }
    }
    
    public class Party
    {
		[CommonBasicComponent]
		public Indicator MarkAttentionIndicator { get; set; }
        [CommonBasicComponent]
        public Identifier EndpointID { get; set; }
	    public PartyIdentification PartyIdentification { get; set; }
        public PartyName PartyName { get; set; }
        public PostalAddress PostalAddress { get; set; }
        public PhysicalLocation PhysicalLocation { get; set; }
        public PartyTaxScheme PartyTaxScheme { get; set; }
        public PartyLegalEntity PartyLegalEntity { get; set; }
        public Contact Contact { get; set; }
    }
    public class PartyName
    {
        [CommonBasicComponent]
        public Name Name { get; set; }
    }

    public class PartyLegalEntity
    {
        [CommonBasicComponent]
        public Name RegistrationName { get; set; }
        [CommonBasicComponent]
        public Identifier CompanyID { get; set; }
    }

    public class PartyIdentification
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
    }
    public class PartyTaxScheme
    {
        [CommonBasicComponent]
        public Identifier CompanyID { get; set; }
        public TaxScheme TaxScheme { get; set; }
    }
    public class PhysicalAttribute
    {
        // TODO
    }
    public class Period
    {
        [CommonBasicComponent]
        public Date StartDate { get; set; }
        [CommonBasicComponent]
        public Time StartTime { get; set; }
        [CommonBasicComponent]
        public Date EndDate { get; set; }
        [CommonBasicComponent]
        public Time EndTime { get; set; }
        [CommonBasicComponent]
        public Measure DurationMeasure { get; set; }
        [CommonBasicComponent]
        public Code DescriptionCode { get; set; }
        [CommonBasicComponent]
        public Text Description { get; set; }
    }
    public class PostalAddress : Address { }

    public class PhysicalLocation
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Text Description { get; set; }
        [CommonBasicComponent]
        public Name Name { get; set; }
        [CommonAggregateComponent]
        public Address Address { get; set; }
    }
    public class Price
    {
        [CommonBasicComponent]
        public Amount PriceAmount { get; set; }
        [CommonBasicComponent]
        public Quantity BaseQuantity { get; set; }
        [CommonBasicComponent]
        public Text[] PriceChangeReason { get; set; }
        [CommonBasicComponent]
        public Code PriceTypeCode { get; set; }
        [CommonBasicComponent]
        public Text PriceType { get; set; }
        [XmlElement]
        public AllowanceCharge[] AllowanceCharge { get; set; }
        // TODO
    }
    public class DespatchSupplierParty : SupplierParty { }
    public class SellerSupplierParty : SupplierParty { }
    public class SupplierParty
    {
        [CommonBasicComponent]
        public Identifier CustomerAssignedAccountID { get; set; }

        [CommonBasicComponent]
        public Identifier AdditionalAccountID { get; set; }

        public Party Party { get; set; }
    }
    public class TaxCategory
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Name Name { get; set; }
        [CommonBasicComponent]
        public Percent Percent { get; set; }
        [CommonBasicComponent]
        public Measure BaseUnitMeasure { get; set; }
        [CommonBasicComponent]
        public Amount PerUnitAmount { get; set; }
        [CommonBasicComponent]
        public Code TaxExemptionReasonCode { get; set; }
        [CommonBasicComponent]
        public Text TaxExemptionReason { get; set; }
        [CommonBasicComponent]
        public Text TierRange { get; set; }
        [CommonBasicComponent]
        public Percent TierRatePercent { get; set; }
        public TaxScheme TaxScheme { get; set; }
    }
    public class TaxScheme
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }

        [CommonBasicComponent]
        public Name Name { get; set; }
    }
    public class TaxSubtotal
    {
        [CommonBasicComponent]
        public Amount TaxableAmount { get; set; }
        [CommonBasicComponent]
        public Amount TaxAmount { get; set; }
        [CommonBasicComponent]
        public Percent Percent { get; set; }
        [CommonBasicComponent]
        public Text TierRange { get; set; }
        [CommonBasicComponent]
        public Percent TierRatePercent { get; set; }
        public TaxCategory TaxCategory { get; set; }
    }
    public class TaxTotal
    {
        [CommonBasicComponent]
        public Amount TaxAmount { get; set; }
        
        [CommonBasicComponent]
        public Text TaxEvidenceIndicator { get; set; }

        [XmlElement]
        public TaxSubtotal[] TaxSubtotal { get; set; }

    }

    public class Contact
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Name Name { get; set; }
        [CommonBasicComponent]
        public Text Telephone { get; set; }
        [CommonBasicComponent]
        public Text Telefax { get; set; }
        [CommonBasicComponent]
        public Text ElectronicMail { get; set; }
        [CommonBasicComponent]
        public Text Note { get; set; }
    }

    public class PaymentMeans
    {
        [CommonBasicComponent]
        public Code PaymentMeansCode { get; set; }
        [CommonBasicComponent]
        public Date PaymentDueDate { get; set; }
        public PayeeFinancialAccount PayeeFinancialAccount { get; set; }
    }
    public class PayeeFinancialAccount
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        public FinancialInstitutionBranch FinancialInstitutionBranch { get; set; }
    }

    public class FinancialInstitutionBranch
    {
        public FinancialInstitution FinancialInstitution { get; set; }
    }
    public class FinancialInstitution
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
    }
    public class PaymentTerms
    {
        [CommonBasicComponent]
        public Text Note { get; set; }
    }
    public class DeliveryTerms
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Text SpecialTerms { get; set; }
        public DeliveryLocation DeliveryLocation { get; set; }
    }
    public class DeliveryLocation
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }
        [CommonBasicComponent]
        public Text Description { get; set; }
        public Address Address { get; set; }
    }
}
