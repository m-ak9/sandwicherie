using sandwicherie.application_core;

namespace sandwicherie.adapters.primary;

public class ConsoleCommand
{
    private readonly OrderService _orderService;
    private readonly ParserService _parserService;

    public ConsoleCommand(OrderService orderService, ParserService parserService)
    {
        _orderService = orderService;
        _parserService = parserService;
    }

    public void createOrder(string createOrderInput)
    {
        var createOrderParsed = _parserService.parseOrderInput(createOrderInput);

        OrderRequest orderRequest = new OrderRequest(createOrderParsed);

        _orderService.ProceedOrder(orderRequest);
    }

}