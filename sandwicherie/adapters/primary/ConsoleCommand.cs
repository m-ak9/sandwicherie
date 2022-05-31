using System.Net.Sockets;
using sandwicherie.application_core;
using sandwicherie.domain;

namespace sandwicherie.adapters.primary;

public class CLI
{
    private readonly DefaultOrderService _defaultOrderService;

    public CLI(DefaultOrderService defaultOrderService)
    {
        _defaultOrderService = defaultOrderService;
    }

    public void StartCLI()
    {
        
        
    }

    public void MakeOrder()
    {
        //TODO parseOrderConsoleInput(string consoleInputString)

        IDictionary<string, SandwicheId> order = new Dictionary<string, SandwicheId>();
        //fake parsed input
        order.Add("A", SandwicheId.Of(1));
        order.Add("B", SandwicheId.Of(2));
        order.Add("C", SandwicheId.Of(1));

        OrderRequest orderRequest = new OrderRequest(order);
        _defaultOrderService.ProceedOrder(orderRequest);
    }
    
}