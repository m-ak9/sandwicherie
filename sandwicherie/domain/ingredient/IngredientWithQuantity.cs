namespace sandwicherie.domain;

public class IngredientWithQuantity: Ingredient
{

    private readonly string Name;
    

    private readonly int QuantityInGrammes;
    
    private IngredientWithQuantity(string name, int quantityInGrammes)
    {
        this.Name = name;
        this.QuantityInGrammes = quantityInGrammes;
    }

    public static IngredientWithQuantity Of(string name, int quantityInGrammes)
    {
        return new IngredientWithQuantity(name, quantityInGrammes);
    }

    public string getName()
    {
        return this.Name;
    }
    public double getAmount()
    {
        throw new NotImplementedException();
    }
    public int getQuantity()
    {
        return this.QuantityInGrammes;
    }
}