using sandwicherie.domain;

namespace sandwicherie.application_core;

public static class SandwichAdapter
{
    public static Sandwich adapt(SandwichEntity sandwichEntity)
    {
        List<Ingredient> ingredients = new List<Ingredient>();
        sandwichEntity.Ingredients.ForEach(ingredient =>
        {
            ingredients.Add(IngredientFactory.createIngredient(ingredient.Name, ingredient.Amount, ingredient.QuantityInGrammes));
        });

            Price price;
        if (sandwichEntity.Price.Devise.Contains("USD"))
            price = Price.Of(sandwichEntity.Price.Value, Devise.Dollars);
        else if (sandwichEntity.Price.Devise.Contains("EUR"))
            price = Price.Of(sandwichEntity.Price.Value, Devise.Euros);
        else
            throw new ArgumentException("Devise not supported");

        return Sandwich.Of(sandwichEntity.Name, ingredients, price);
    }
}