using sandwicherie.domain;

namespace sandwicherie.adapters.secondary;

public class FakeSandwichRepository
{
    private static readonly Sandwich Sandwich1 = Sandwich.Of(
        "Jambon beurre",
        new List<Ingredient>()
        {
            Ingredient.WithAmountOnly("pain", 1),
            Ingredient.WithAmountOnly("tranche de jambon", 1),
            Ingredient.WithQuantityOnly("beurre", 10)
        },
        Price.Of(3.50, Devise.Euros)
    );

    private static readonly Sandwich Sandwich2 = Sandwich.Of(
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
        Price.Of(5, Devise.Euros)
    );

    private static readonly Sandwich Sandwich3 = Sandwich.Of(
        "Dieppois",
        new List<Ingredient>()
        {
            Ingredient.WithAmountOnly("pain", 1),
            Ingredient.WithQuantityOnly("thon", 50),
            Ingredient.WithAmountOnly("tomate", 0.5),
            Ingredient.WithQuantityOnly("mayonnaise", 10),
            Ingredient.WithQuantityOnly("salade", 10),
        },
        Price.Of(4.50, Devise.Euros)
    );


    public List<Sandwich> data { get; } = new List<Sandwich>()
    {
        {Sandwich1},
        {Sandwich2},
        {Sandwich3}
    };

    public Sandwich FindSandwichByName(string sandwichName)
    {
        Sandwich res = null;
        foreach (var sandwich in data)
        {
            if (sandwich.Name.ToLower().Trim().Replace(" ", "") == sandwichName.ToLower().Trim().Replace(" ", ""))
                res = sandwich;
        }
        
        if (res == null)
            throw new KeyNotFoundException("Sandwich not found: " + sandwichName);
        else
            return res;
    }

}