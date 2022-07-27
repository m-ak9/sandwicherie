namespace sandwicherie.domain;

public interface SandwichRepository
{
    Sandwich FindByName(string name);
}