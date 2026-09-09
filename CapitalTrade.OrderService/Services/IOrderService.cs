using CapitalTrade.OrderService.Contracts;
using CapitalTrade.OrderService.Models;

namespace CapitalTrade.OrderService.Services;

public interface IOrderService
{
    Task<Order> CreateOrderAsync(CreateOrderRequest request);

    Task<Order?> GetOrderAsync(Guid id);
}