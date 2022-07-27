using System.Text;
using sandwicherie.domain;

namespace sandwicherie.adapters.secondary;

public class BillingGenerator
{
    public string generateBill(Order order)
    {
        /* string builder */
        StringBuilder bill = new StringBuilder();
        foreach (var orderedSandwich in order.orderedSandwiches)
        {
            bill.AppendLine(orderedSandwich.Key + " " + orderedSandwich.Value.Name);
            foreach (var ingredient in orderedSandwich.Value.Ingredients)
            {
                bill.AppendLine("\t" + ingredient.getName());
            }
        }
        
        return bill.ToString();
    }
}