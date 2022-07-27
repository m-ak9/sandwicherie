namespace sandwicherie.domain;

public class IngredientEntity
{
    
    public string Name { get; }

    public double? Amount { get; }

    public int? QuantityInGrammes { get; }
    
    private IngredientEntity(string name, double? amount, int? quantityInGrammes)
    {
        this.Name = name;
        this.Amount = amount;
        this.QuantityInGrammes = quantityInGrammes;
    }

    public static IngredientEntity Of(string name, double? amount, int? quantityInGrammes)
    {
        return new IngredientEntity(name, amount, quantityInGrammes);
    }
}