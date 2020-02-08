using System.Collections.Generic;

namespace Business.Entities
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public int IdTenant { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        #region Relationships

        public virtual ICollection<Tenant> Tenant { get; set; }

        #endregion
    }
}
