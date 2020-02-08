namespace Business.Entities
{
    public class SearchHistory
    {
        public int IdSearchHistory { get; set; }
        public int IdProduct { get; set; }
        public int IdCustomer { get; set; }
        public string QuantitySearch { get; set; }
    }
}
