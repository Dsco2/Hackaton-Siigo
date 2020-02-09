namespace Business.Entities
{
    public class SearchCustomerHistory
    {
        public int IdSearchCustomerHistory { get; set; }
        public int IdCustomer { get; set; }
        public int AmountOfSearch { get; set; }


        
        public virtual Customer Customer { get; set; }
    }
}
