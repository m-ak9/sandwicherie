namespace sandwicherie.adapters.primary;

public class CLI
{
    private readonly ConsoleCommand _consoleCommand;

    public CLI(ConsoleCommand consoleCommand)
    {
        _consoleCommand = consoleCommand;
    }
    
    public void StartCLI()
    {
        var inputString = "";

        Console.WriteLine("Bonjour !");
        do
        {
            Console.WriteLine("Veuillez passer commande => A Sandwich1, B Sandwich2, ... , X Sandwich3");
            inputString = Console.ReadLine();
            try
            {
                handleCLIInput(inputString);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }
        } while (true);

    }
    
    private void handleCLIInput(string inputString)
    {
        _consoleCommand.createOrder(inputString);
    }
}