namespace sandwicherie.domain;

public class Sandwiche
{
    public string Name { get; }

    public List<Ingredient> Ingredients { get; }

    public Price Price { get; }

    public SandwicheId SandwicheId { get; }
    
    private Sandwiche(string name, List<Ingredient> ingredients, Price price, SandwicheId sandwicheId)
    {
        Name = name;
        Ingredients = ingredients;
        Price = price;
        SandwicheId = sandwicheId;
    }

    public static Sandwiche Of(string name, List<Ingredient> ingredients, Price price, SandwicheId sandwicheId)        // Named constructor, never modifying the "original" constructor, manage multiple instanciation possibility
    {
        return new Sandwiche(name, ingredients, price, sandwicheId);
    }
}