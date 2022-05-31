using sandwicherie.adapters.primary;
using sandwicherie.adapters.secondary;
using sandwicherie.domain;

namespace sandwicherie.application_core;

public class DefaultOrderService
{
    private readonly FakeSandwichRepository _fakeSandwichRepository;
    private readonly BillingGenerator _billingGenerator;

    public DefaultOrderService( FakeSandwichRepository fakeSandwichRepository, BillingGenerator billingGenerator)
    {
        this._fakeSandwichRepository = fakeSandwichRepository;
        this._billingGenerator = billingGenerator;
    }

    public void ProceedOrder(OrderRequest orderRequest)
    {
        IDictionary<string, Sandwiche> sandwiches = new Dictionary<string, Sandwiche>();
        Price totalOrderPrice = Price.Of(0, Devise.Euros);
        
        foreach (var orderedSandwiche in orderRequest.Order)
        {
            var sandwiche = _fakeSandwichRepository.FindSandwicheById(orderedSandwiche.Value);
            sandwiches.Add(orderedSandwiche.Key, sandwiche);
            totalOrderPrice.Add(sandwiche.Price.Value);
        }
        

        Order order = Order.Of(sandwiches, totalOrderPrice);

        _billingGenerator.displayBill(order);
    }
}