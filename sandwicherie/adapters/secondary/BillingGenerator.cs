using sandwicherie.domain;

namespace sandwicherie.adapters.secondary;

public class BillingGenerator
{
    public void displayBill(Order order)
    {
        foreach (var orderedSandwich in order.orderedSandwiches)
        {
            Console.WriteLine(orderedSandwich.Key + " " + orderedSandwich.Value.Name);
            foreach (var ingredient in orderedSandwich.Value.Ingredients)
            {
                Console.WriteLine("\t" + ingredient.Name);
            }
        }
    }
}