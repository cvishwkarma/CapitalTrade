using CapitalTrade.OrderService.Contracts;
using CapitalTrade.OrderService.Models;
using CapitalTrade.OrderService.Repositories;

namespace CapitalTrade.OrderService.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _repository;

    public OrderService(IOrderRepository repository)
    {
        _repository = repository;
    }

    public async Task<Order> CreateOrderAsync(CreateOrderRequest request)
    {
        var order = new Order
        {
            Id = Guid.NewGuid(),
            CustomerId = request.CustomerId,
            Symbol = request.Symbol,
            Quantity = request.Quantity,
            Price = request.Price,
            Status = "Created",
            CreatedAtUtc = DateTime.UtcNow
        };

        await _repository.AddAsync(order);
        await _repository.SaveChangesAsync();

        return order;
    }

    public async Task<Order?> GetOrderAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }
}