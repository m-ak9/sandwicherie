namespace sandwicherie.domain;

public class Order
{
    
    public IDictionary<string, Sandwich> orderedSandwiches { get; }

    public Price TotalPrice { get; }
    private Order(IDictionary<string, Sandwich> orderedSandwiches, Price totalPrice)
    {
        this.orderedSandwiches = orderedSandwiches;
        this.TotalPrice = totalPrice;
    }

    public static Order Of(IDictionary<string, Sandwich> sandwiches, Price totalPrice)
    {
        return new Order(sandwiches, totalPrice);
    }
}