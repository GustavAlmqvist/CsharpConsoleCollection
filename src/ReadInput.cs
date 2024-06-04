public class ReadInput
{
    double validNumber;
    string? ConsoleInput;
    
    public string? ReadConsoleInput()
    {
        ConsoleInput = Console.ReadLine();
            
        if (ConsoleInput == "")
        {
            Console.WriteLine("Please enter a valid value");
            ConsoleInput = Console.ReadLine();
        }
        if (ConsoleInput != null)
        {
            ConsoleInput.Trim();
            ConsoleInput.ToLower();
        }
        
        return ConsoleInput;
    }
    public double ReadNumberInput()
    {

        ConsoleInput = Console.ReadLine();
        //Get rid of warning by putting the contains "," in seperatate if statement?
        if (ConsoleInput == "" || ConsoleInput.Contains(",") == true)
        {
            Console.WriteLine("Please enter a valid value, non-null, '3' not 'three' and use '.' as decimal");
            ReadNumberInput();
        }
        
        bool validNumberInput = double.TryParse(ConsoleInput, out validNumber);
        
        if (validNumberInput == false)
        {
            Console.WriteLine("Please enter a valid value, non-null, '3' not 'three' and use '.' as decimal");
            ReadNumberInput();
        }

        return validNumber;
    }
}