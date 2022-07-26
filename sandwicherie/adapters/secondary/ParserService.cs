namespace sandwicherie.adapters.primary;

public class ParserService
{
    public IDictionary<string, string> parseOrderInput(String orderInputString)
    {
        IDictionary<string, string> orderMap = new Dictionary<string, string>();
        var splittedString = orderInputString.Split(',');
        foreach (var s in splittedString)
        {
            var str = s.TrimStart();
            var clientName = str.Substring(0, str.IndexOf(' ') + 1);
            var sandwichName = str.Remove(0, str.IndexOf(' ') + 1);
            orderMap.Add(clientName, sandwichName);
        }

        return orderMap;
    }
}