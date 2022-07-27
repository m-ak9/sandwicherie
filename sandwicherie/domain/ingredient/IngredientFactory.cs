namespace sandwicherie.domain;

public static class IngredientFactory
{
    public static Ingredient createIngredient(string name, double? amount, int? quantity)
    {
        if (amount != null && quantity != null)
            return DefaultIngredient.Of(name, amount.Value, quantity.Value);
        if (amount != null)
            return IngredientWithAmount.Of(name, amount.Value);
        if (quantity != null)
            return IngredientWithQuantity.Of(name, quantity.Value);
        
        throw new ArgumentException("IngredientFactory: createIngredient: amount and quantity are null");
    }
}