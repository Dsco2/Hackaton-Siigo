namespace Business.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public int IdTenant { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
