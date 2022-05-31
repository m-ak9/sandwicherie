namespace sandwicherie.domain;

public class Price
{
    
    public double Value { get; set; }

    public Devise Devise { get; }
    
    private Price(double value, Devise devise)
    {
        this.Value = value;
        this.Devise = devise;
    }

    public static Price Of(double value, Devise devise)
    {
        return new Price(value, devise);
    }

    public void Add(double value)
    {
        this.Value += value;
    }

}