using CapitalTrade.OrderService.Contracts;
using CapitalTrade.OrderService.Services;
using Microsoft.AspNetCore.Mvc;

namespace CapitalTrade.OrderService.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(
        CreateOrderRequest request)
    {
        var order = await _orderService.CreateOrderAsync(request);

        return CreatedAtAction(
            nameof(GetOrder),
            new { id = order.Id },
            order);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetOrder(Guid id)
    {
        var order = await _orderService.GetOrderAsync(id);

        if (order is null)
        {
            return NotFound();
        }

        return Ok(order);
    }
}