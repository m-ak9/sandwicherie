using sandwicherie.adapters.primary;
using sandwicherie.adapters.secondary;
using sandwicherie.application_core;

namespace sandwicherie;

//Architecture pattern => Inversion Of Control via Constructor dependecy injection
public class Configuration
{
    // Configuration
    public static FakeSandwichRepository FakeSandwichRepository()
    {
        return new FakeSandwichRepository();
    }
    
    public static BillingGenerator BillingGenerator()
    {
        return new BillingGenerator();
    }
    
    public static OrderService OrderService()
    {
        return new OrderService(FakeSandwichRepository(), BillingGenerator());
    }
    
    public static ParserService ParserService()
    {
        return new ParserService();
    }
    
    public static ConsoleCommand ConsoleCommand()
    {
        return new ConsoleCommand(OrderService(), ParserService());
    }
    
    public static CLI CLI()
    {
        return new CLI(ConsoleCommand());
    }
    
}