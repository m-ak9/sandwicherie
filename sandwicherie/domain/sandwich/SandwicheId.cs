namespace sandwicherie.domain;

public class SandwicheId
{
    public int Value { get; }

    private SandwicheId(int value)
    {
        Value = value;
    }

    public static SandwicheId Of(int value)
    {
        return new SandwicheId(value);
    }

    protected bool Equals(SandwicheId other)
    {
        return Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((SandwicheId)obj);
    }

    public override int GetHashCode()
    {
        return Value;
    }
}