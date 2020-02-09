namespace Business.Entities
{
    public class SearchProductHistory
    {
        public int IdSearchProductHistory { get; set; }
        public int IdProduct { get; set; }
        public int AmountOfSearch { get; set; }

        
        public virtual Product Product{ get; set; }
    }
}
