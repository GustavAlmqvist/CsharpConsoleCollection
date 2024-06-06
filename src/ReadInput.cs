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
            ReadConsoleInput();
        }
        if (ConsoleInput != null)
        {
            ConsoleInput = ConsoleInput.Trim();
            ConsoleInput = ConsoleInput.ToLower();
        }
        
        return ConsoleInput;
    }
    public double ReadNumberInput()
    {

        ConsoleInput = Console.ReadLine();
        if (ConsoleInput == "")
        {
            Console.WriteLine("Please enter a valid value, non-null, '3' not 'three' and use '.' as decimal");
            ReadNumberInput();
        }
        if (ConsoleInput != null)
        {
            bool validNumberInput = double.TryParse(ConsoleInput, out validNumber);
        
            if (validNumberInput == false || ConsoleInput.Contains(",") == true)
            {
                Console.WriteLine("Please enter a valid value, non-null, '3' not 'three' and use '.' as decimal");
                ReadNumberInput();
            }
        }
        return validNumber;
    }
    //Could just use numberinput twice? First for feet then once more for inches.
    
    // public double ReadImperialInput()
    // {
    //     double ValidFeet;
    //     double ValidInches;
    //     ConsoleInput = Console.ReadLine();

    //     if (ConsoleInput == "")
    //     {
    //         Console.WriteLine("Please enter a valid value, non-null, '3' not 'three' and use '.' as decimal");
    //         ReadImperialInput();
    //     }

    //     return ValidFeet, ValidInches;
    // }
}