public class ReadInput
{
    public string? ReadConsoleInput()
    {
        string? ConsoleInput;

        ConsoleInput = Console.ReadLine();
        if (ConsoleInput != null)
        {
            ConsoleInput.Trim();
            ConsoleInput.ToLower();
        }
        if (ConsoleInput == "")
        {
            Console.WriteLine("Please enter a non-null value");
        }
        return ConsoleInput;
    }
}