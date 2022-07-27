using sandwicherie.adapters.secondary;
using sandwicherie.application_core;

namespace sandwicherie.adapters.primary;

public class ConsoleCommand
{
    private readonly OrderService _orderService;
    private readonly ParserService _parserService;
    private readonly BillingGenerator _billingGenerator;

    public ConsoleCommand(OrderService orderService, ParserService parserService, BillingGenerator billingGenerator)
    {
        _orderService = orderService;
        _parserService = parserService;
        _billingGenerator = billingGenerator;
    }

    public string createOrder(string createOrderInput)
    {
        var createOrderParsed = _parserService.parseOrderInput(createOrderInput);

        OrderRequest orderRequest = new OrderRequest(createOrderParsed);

        var order = _orderService.createOrder(orderRequest);
        
        return _billingGenerator.generateBill(order);
    }

}