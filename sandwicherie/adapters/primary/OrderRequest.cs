using sandwicherie.domain;

namespace sandwicherie.adapters.primary;

public class OrderRequest
{
    public IDictionary<string, SandwicheId> Order { get; }
    
    public OrderRequest(IDictionary<string, SandwicheId> order)
    {
        this.Order = order;
    }
}