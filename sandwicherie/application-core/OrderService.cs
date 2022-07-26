using sandwicherie.adapters.primary;
using sandwicherie.adapters.secondary;
using sandwicherie.domain;

namespace sandwicherie.application_core;

public class OrderService
{
    private readonly FakeSandwichRepository _fakeSandwichRepository;
    private readonly BillingGenerator _billingGenerator;

    public OrderService(FakeSandwichRepository fakeSandwichRepository, BillingGenerator billingGenerator)
    {
        this._fakeSandwichRepository = fakeSandwichRepository;
        this._billingGenerator = billingGenerator;
    }

    public void ProceedOrder(OrderRequest orderRequest)
    {
        IDictionary<string, Sandwich> sandwiches = new Dictionary<string, Sandwich>();
        Price totalOrderPrice = Price.Of(0, Devise.Euros);
        
        foreach (var orderedSandwiche in orderRequest.Order)
        {
            var sandwiche = _fakeSandwichRepository.FindSandwichByName(orderedSandwiche.Value);
            sandwiches.Add(orderedSandwiche.Key, sandwiche);
            totalOrderPrice.Add(sandwiche.Price.Value);
        }
        

        Order order = Order.Of(sandwiches, totalOrderPrice);

        _billingGenerator.displayBill(order);
    }
}