namespace sandwicherie.domain;

public class Sandwich
{
    public string Name { get; }

    public List<Ingredient> Ingredients { get; }

    public Price Price { get; }
    
    
    private Sandwich(string name, List<Ingredient> ingredients, Price price)
    {
        Name = name;
        Ingredients = ingredients;
        Price = price;
    }

    public static Sandwich Of(string name, List<Ingredient> ingredients, Price price)        // Named constructor, never modifying the "original" constructor, manage multiple instanciation possibility
    {
        return new Sandwich(name, ingredients, price);
    }
}