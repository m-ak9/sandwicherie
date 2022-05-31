namespace sandwicherie.domain;

public class Ingredient
{
    
    public string Name { get; }

    private double Amount { get; }

    private int QuantityInGrammes { get; }
    
    private Ingredient(string name, double amount, int quantityInGrammes)
    {
        this.Name = name;
        this.Amount = amount;
        this.QuantityInGrammes = quantityInGrammes;
    }

    public static Ingredient Of(string name, int amount, int quantityInGrammes)
    {
        return new Ingredient(name, amount, quantityInGrammes);
    }
    
    public static Ingredient WithQuantityOnly(string name, int quantityInGrammes)
    {
        return new Ingredient(name, -1, quantityInGrammes);
    }
    
    public static Ingredient WithAmountOnly(string name, double amount)
    {
        return new Ingredient(name, amount, -1);
    }
}