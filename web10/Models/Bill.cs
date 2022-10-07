namespace web10.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string customerName { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
