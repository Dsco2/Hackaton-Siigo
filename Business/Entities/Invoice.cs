using System.Collections.Generic;

namespace Business.Entities
{
    public class Invoice
    {
        public int IdInvoice { get; set; }
        public int? IdTenant { get; set; }
        public int? IdCustomer { get; set; }
        public string DocDate { get; set; }
        public string DocNumber { get; set; }
        public int TotalDiscount { get; set; }
        public int TotalTax { get; set; }
        public int TotalValue { get; set; }
        
        #region Relationships

        public virtual Tenant Tenant { get; set; }
        public virtual Customer Customer { get; set; }

        #endregion
    }
}
