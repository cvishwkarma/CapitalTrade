using CapitalTrade.OrderService.Models;
using Microsoft.EntityFrameworkCore;

namespace CapitalTrade.OrderService.Data;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
    {
    }

    public DbSet<Order> Orders => Set<Order>();
}