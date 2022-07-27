namespace sandwicherie.domain;

public class IngredientWithAmount: Ingredient
{

    private readonly string Name;
    
    private readonly double Amount;

    private IngredientWithAmount(string name, double amount)
    {
        this.Name = name;
        this.Amount = amount;
    }

    public static IngredientWithAmount Of(string name, double amount)
    {
        return new IngredientWithAmount(name, amount);
    }

    public string getName()
    {
        return this.Name;
    }
    public double getAmount()
    {
        return this.Amount;
    }
    public int getQuantity()
    {
        throw new NotImplementedException();
    }
}