namespace Business.Entities
{
    public class Tenant
    {
        public int IdTenant { get; set; }
        public string Name { get; set; }

        
        #region Relationships

        public Customer Customer { get; set; }
        public InvoiceItem InvoiceItem { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }

        #endregion
    }
}
