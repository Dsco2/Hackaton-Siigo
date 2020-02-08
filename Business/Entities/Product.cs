using System.Collections.Generic;

namespace Business.Entities
{
    public class Product
    {
        public int IdProduct { get; set; }  
        public int IdTenant { get; set; }  
        public string Name { get; set; }  
        public string Description { get; set; }  
        public float ListPrice { get; set; }
        
        #region Relationships

        public virtual ICollection<Tenant> Tenant { get; set; }

        #endregion
    }
}
