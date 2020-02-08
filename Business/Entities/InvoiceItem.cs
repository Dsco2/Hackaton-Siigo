namespace Business.Entities
{
    public class InvoiceItem
    {
        public int IdInvoiceItem { get; set; }
        public int? IdTenant { get; set; }
        public int? IdProduct { get; set; }
        public int? IdInvoice { get; set; }
        public float Quantity { get; set; }
        public float UnitValue { get; set; }
        public float ItemValue { get; set; }
        
        #region Relationships

        public virtual Tenant Tenant { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }

        #endregion
    }
}
