namespace sandwicherie.domain;

public class Order
{
    
    public IDictionary<string, Sandwiche> orderedSandwiches { get; }

    public Price TotalPrice { get; }
    private Order(IDictionary<string, Sandwiche> orderedSandwiches, Price totalPrice)
    {
        this.orderedSandwiches = orderedSandwiches;
        this.TotalPrice = totalPrice;
    }

    public static Order Of(IDictionary<string, Sandwiche> sandwiches, Price totalPrice)
    {
        return new Order(sandwiches, totalPrice);
    }
}