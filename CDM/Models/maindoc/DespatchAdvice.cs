namespace Kramp.DotNet.Models.CDM
{
    [MainDoc(Constants.DespatchAdviceNamespace)]
    public class DespatchAdvice
    {
        [CommonBasicComponent]
        public Identifier ID { get; set; }

        [CommonBasicComponent]
        public Date IssueDate { get; set; }

        [CommonAggregateComponent]
        public OrderReference OrderReference { get; set; }

        [CommonAggregateComponent]
        public DespatchSupplierParty DespatchSupplierParty { get; set; }

        [CommonAggregateComponent]
        public DeliveryCustomerParty DeliveryCustomerParty { get; set; }
        
        [CommonAggregateComponent]
        public BuyerCustomerParty BuyerCustomerParty { get; set; }

        [CommonAggregateComponent]
        public SellerSupplierParty SellerSupplierParty { get; set; }

        [CommonAggregateComponent]
        public Shipment Shipment { get; set; }
        
        [CommonAggregateComponent]
        public DespatchLine[] DespatchLine { get; set; }
    }
}
