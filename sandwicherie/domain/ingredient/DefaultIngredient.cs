namespace sandwicherie.domain;

public class DefaultIngredient: Ingredient
{

    private readonly string Name;
    
    private readonly double Amount;
    
    private readonly int QuantityInGrammes;
    
    private DefaultIngredient(string name, double amount, int quantityInGrammes)
    {
        this.Name = name;
        this.QuantityInGrammes = quantityInGrammes;
    }

    public static DefaultIngredient Of(string name, double amount, int quantityInGrammes)
    {
        return new DefaultIngredient(name, amount, quantityInGrammes);
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
        return this.QuantityInGrammes;
    }
}