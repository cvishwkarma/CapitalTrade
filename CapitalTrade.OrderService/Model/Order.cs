namespace CapitalTrade.OrderService.Models;
    public class Order
    {
        public Guid Id { get; set; }

        public string CustomerId { get; set; } = string.Empty;

        public string Symbol { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; } = string.Empty;

        public DateTime CreatedAtUtc { get; set; }
    }
