namespace sandwicherie.domain;

public class SandwichEntity
{
    public string Name { get; }

    public List<IngredientEntity> Ingredients { get; }

    public PriceEntity Price { get; }
    
    
    private SandwichEntity(string name, List<IngredientEntity> ingredients, PriceEntity price)
    {
        Name = name;
        Ingredients = ingredients;
        Price = price;
    }

    public static SandwichEntity Of(string name, List<IngredientEntity> ingredients, PriceEntity price)        // Named constructor, never modifying the "original" constructor, manage multiple instanciation possibility
    {
        return new SandwichEntity(name, ingredients, price);
    }
}