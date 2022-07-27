using sandwicherie.application_core;
using sandwicherie.domain;

namespace sandwicherie.adapters.secondary;

public class FakeSandwichRepository : SandwichRepository
{
    private static readonly SandwichEntity Sandwich1 = SandwichEntity.Of(
        "Jambon beurre",
        new List<IngredientEntity>()
        {
            IngredientEntity.Of("pain", 1, null),
            IngredientEntity.Of("tranche de jambon", 1, null),
            IngredientEntity.Of("beurre", null, 10)
        },
        PriceEntity.Of(3.50, "EUR")
    );

    private static readonly SandwichEntity Sandwich2 = SandwichEntity.Of(
        "Poulet crudités",
        new List<IngredientEntity>()
        {
            IngredientEntity.Of("pain", 1, null),
            IngredientEntity.Of("oeuf", 1, null),
            IngredientEntity.Of("tomate", 0.5, null),
            IngredientEntity.Of("tranche de poulet", 1, null),
            IngredientEntity.Of("mayonnaise", null,  10),
            IngredientEntity.Of("salades",null, 10)
        },
        PriceEntity.Of(5, "EUR")
    );

    private static readonly SandwichEntity Sandwich3 = SandwichEntity.Of(
        "Dieppois",
        new List<IngredientEntity>()
        {
            IngredientEntity.Of("pain", 1, null),
            IngredientEntity.Of("thon", null, 50),
            IngredientEntity.Of("tomate", 0.5, null),
            IngredientEntity.Of("mayonnaise", null, 10),
            IngredientEntity.Of("salade", null, 10),
        },
        PriceEntity.Of(4.50, "EUR")
    );


    public List<SandwichEntity> data { get; } = new List<SandwichEntity>()
    {
        {Sandwich1},
        {Sandwich2},
        {Sandwich3}
    };
    

    public Sandwich FindByName(string name)
    {
        SandwichEntity res = null;
        foreach (var sandwich in data)
        {
            if (sandwich.Name.ToLower().Trim().Replace(" ", "") == name.ToLower().Trim().Replace(" ", ""))
                res = sandwich;
        }
        
        if (res == null)
            throw new KeyNotFoundException("Sandwich not found: " + name);
        else
            return SandwichAdapter.adapt(res);
    }
}