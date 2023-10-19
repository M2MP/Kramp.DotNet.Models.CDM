namespace Kramp.DotNet.Models.CDM
{
    [MainDoc(Constants.OrderResponseNamespace)]
    public class OrderResponse
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }

        [CommonBasicComponent]
        public Date IssueDate { get; set; }

        [CommonBasicComponent]
        public Code OrderResponseCode { get; set; }

        [CommonAggregateComponent]
        public OrderReference OrderReference { get; set; }

        [CommonAggregateComponent]
        public SellerSupplierParty SellerSupplierParty { get; set; }

        [CommonAggregateComponent]
        public BuyerCustomerParty BuyerCustomerParty { get; set; }

        [CommonAggregateComponent]
        public AccountingCustomerParty AccountingCustomerParty { get; set; }

        [CommonAggregateComponent]
        public Delivery Delivery { get; set; }
        
        [CommonAggregateComponent]
        public OrderLine[] OrderLine { get; set; }
    }
}
