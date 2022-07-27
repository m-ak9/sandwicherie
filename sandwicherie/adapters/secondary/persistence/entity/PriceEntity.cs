namespace sandwicherie.domain;

public class PriceEntity
{
    
    public double Value { get; set; }

    public string Devise { get; }
    
    private PriceEntity(double value, string devise)
    {
        this.Value = value;
        this.Devise = devise;
    }

    public static PriceEntity Of(double value, string devise)
    {
        return new PriceEntity(value, devise);
    }

    public void Add(double value)
    {
        this.Value += value;
    }

}