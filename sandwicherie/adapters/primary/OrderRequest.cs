namespace sandwicherie.adapters.primary;

public class OrderRequest
{
    public IDictionary<string, string> Order { get; }

    public OrderRequest(IDictionary<string, string> order)
    {
        this.Order = order;
    }
}