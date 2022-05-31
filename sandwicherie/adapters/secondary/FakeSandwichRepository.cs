using sandwicherie.domain;

namespace sandwicherie.adapters.secondary;

public class FakeSandwichRepository
{
    private static readonly Sandwiche Sandwich1 = Sandwiche.Of(
        "Jambon beurre",
        new List<Ingredient>()
        {
            Ingredient.WithAmountOnly("pain", 1),
            Ingredient.WithAmountOnly("tranche de jambon", 1),
            Ingredient.WithQuantityOnly("beurre", 10)
        },
        Price.Of(3.50, Devise.Euros),
        SandwicheId.Of(1)
    );
    
    private static readonly Sandwiche Sandwich2 = Sandwiche.Of(
        "Poulet crudités",
        new List<Ingredient>()
        {
            Ingredient.WithAmountOnly("pain", 1),
            Ingredient.WithAmountOnly("oeuf", 1),
            Ingredient.WithAmountOnly("tomate", 0.5),
            Ingredient.WithAmountOnly("tranche de poulet", 1),
            Ingredient.WithQuantityOnly("mayonnaise", 10),
            Ingredient.WithQuantityOnly("salades", 10)
        },
        Price.Of(5, Devise.Euros),
        SandwicheId.Of(2)
    );
    
    private static readonly Sandwiche Sandwich3 = Sandwiche.Of(
        "Dieppois",
        new List<Ingredient>()
        {
            Ingredient.WithAmountOnly("pain", 1),
            Ingredient.WithQuantityOnly("thon", 50),
            Ingredient.WithAmountOnly("tomate", 0.5),
            Ingredient.WithQuantityOnly("mayonnaise", 10),
            Ingredient.WithQuantityOnly("salade", 10),
        },
        Price.Of(4.50, Devise.Euros),
        SandwicheId.Of(3)
    );

    public IDictionary<SandwicheId, Sandwiche> data { get; } = new Dictionary<SandwicheId, Sandwiche>()
    {
        {Sandwich1.SandwicheId, Sandwich1},
        {Sandwich2.SandwicheId, Sandwich2},
        {Sandwich3.SandwicheId, Sandwich3}
    };

    public Sandwiche FindSandwicheById(SandwicheId sandwicheId)
    {
        return data[sandwicheId];
    }
    
}