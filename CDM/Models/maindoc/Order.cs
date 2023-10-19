namespace Kramp.DotNet.Models.CDM
{
    [MainDoc(Constants.OrderNamespace)]
    public class Order
    {
        [CommonBasicComponent]
        public Identifier UBLVersionID { get; set; }

        [CommonBasicComponent]
        public Identifier CustomizationID { get; set; }

        [CommonBasicComponent]
        public Identifier ID { get; set; }

        [CommonBasicComponent]
        public Indicator CopyIndicator { get; set; }

        [CommonBasicComponent]
        public Date IssueDate { get; set; }

        [CommonBasicComponent]
        public Code OrderTypeCode { get; set; }

        [CommonBasicComponent]
        public Code DocumentCurrencyCode { get; set; }

        [CommonAggregateComponent]
        public BuyerCustomerParty BuyerCustomerParty { get; set; }

        [CommonAggregateComponent]
        public SellerSupplierParty SellerSupplierParty { get; set; }

        [CommonAggregateComponent]
        public AccountingCustomerParty AccountingCustomerParty { get; set; }

        [CommonAggregateComponent]
        public Delivery Delivery { get; set; }

        [CommonAggregateComponent]
        public PaymentMeans PaymentMeans { get; set; }

        [CommonAggregateComponent]
        public PaymentTerms PaymentTerms { get; set; }

        [CommonAggregateComponent]
        public AllowanceCharge[] AllowanceCharge { get; set; }

        [CommonAggregateComponent]
        public TaxTotal[] TaxTotal { get; set; }

        [CommonAggregateComponent]
        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }

        [CommonAggregateComponent]
        public OrderLine[] OrderLine { get; set; }
    }
}
