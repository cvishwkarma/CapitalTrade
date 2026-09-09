using System.ComponentModel.DataAnnotations;

namespace CapitalTrade.OrderService.Contracts;

public class CreateOrderRequest
{
    [Required]
    public string CustomerId { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string Symbol { get; set; } = string.Empty;

    [Range(1, 10000)]
    public int Quantity { get; set; }

    [Range(typeof(decimal), "0.01", "999999999")]
    public decimal Price { get; set; }
}