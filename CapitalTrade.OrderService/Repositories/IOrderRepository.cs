using CapitalTrade.OrderService.Models;

namespace CapitalTrade.OrderService.Repositories;

public interface IOrderRepository
{
    Task AddAsync(Order order);

    Task<Order?> GetByIdAsync(Guid id);

    Task SaveChangesAsync();
}