namespace ODataQueryOptions_WebAPI.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateOnly SaleDate { get; set; }
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
    }
}
