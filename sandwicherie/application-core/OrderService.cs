using sandwicherie.adapters.primary;
using sandwicherie.adapters.secondary;
using sandwicherie.domain;

namespace sandwicherie.application_core;

public class OrderService
{
    private readonly SandwichRepository _sandwichRepository;
    private readonly BillingGenerator _billingGenerator;

    public OrderService(SandwichRepository sandwichRepository, BillingGenerator billingGenerator)
    {
        this._sandwichRepository = sandwichRepository;
        this._billingGenerator = billingGenerator;
    }

    public Order createOrder(OrderRequest orderRequest)
    {
        IDictionary<string, Sandwich> sandwiches = new Dictionary<string, Sandwich>();
        Price totalOrderPrice = Price.Of(0, Devise.Euros);
        
        foreach (var orderedSandwiche in orderRequest.Order)
        {
            var sandwiche = _sandwichRepository.FindByName(orderedSandwiche.Value);
            
            sandwiches.Add(orderedSandwiche.Key, sandwiche);
            totalOrderPrice.Add(sandwiche.Price.Value);
        }
        

        Order order = Order.Of(sandwiches, totalOrderPrice);

        return order;
    }
}