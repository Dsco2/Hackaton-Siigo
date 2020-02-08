namespace Business.Entities
{
    public class InvoiceItem
    {
        public int IdInvoiceItem { get; set; }
        public int IdTenant { get; set; }
        public int IdProduct { get; set; }
        public int IdInvoice { get; set; }
        public float Quantity { get; set; }
        public float UnitValue { get; set; }
        public float ItemValue { get; set; }
    }
}
