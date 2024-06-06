public class TemperatureConversions
{
    public void ChooseTempConversion()
    {
        Display();
        Choose();
        
    }
    void CtoF(double TempC)
    {
        double F = TempC * 1.8 + 32;
        Console.WriteLine($"Result: {TempC} Celsius equals {F:F} Fahrenheit.");
    }
    double CtoK(double TempC)
    {
        double K = TempC + 273.15;
        Console.WriteLine($"Result: {TempC} Celsius equals {K:F} Kelvin.");
        return K;
    }
    double FtoC(double TempF)
    {
        double C = (TempF - 32) * 1.8;
        Console.WriteLine($"Result: {TempF} Fahrenheit equals {C:F} Celsius.");
        return C;
    }
        double FtoK(double TempF)
    {
        double K = (TempF - 32) * 1.8 + 273.15;
        Console.WriteLine($"Result: {TempF} Fahrenheit equals {K:F} Kelvin.");
        return K;
    }
        double KtoC(double TempK)
    {
        double C = TempK - 273.15;
        Console.WriteLine($"Result: {TempK} Kelvin equals {C:F} Celsius.");
        return C;
    }
        double KtoF(double TempK)
    {
        double F = (TempK - 273.15) * 1.8 + 32;
        Console.WriteLine($"Result: {TempK} Kelvin equals {F:F} Fahrenheit.");
        return F;
    }
    void Display()
    {
        Console.WriteLine("Please select which units of temperature you are converting between:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Celsius to Kelvin");
        Console.WriteLine("3. Fahrenheit to Celsius");
        Console.WriteLine("4. Fahrenheit to Kelvin");
        Console.WriteLine("5. Kelvin to Celsius");
        Console.WriteLine("6. Kelvin to Fahrenheit");
    }
    void SubMenuPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Choose a menu option, type 'menu' to show the menu, or type 'exit' to go back to the mainmeu.");
    }
    void Choose()
    {

        bool exit = false;
        ReadInput tempMenuOptions = new ReadInput();
        MainMenu DisplayMainMenu = new MainMenu();
        double methodInput;
        string? tempMenuChoice = tempMenuOptions.ReadConsoleInput();
        //Make methods for conversion and enter into switch statements
        do
        {
            switch (tempMenuChoice)
            {
                case "exit":
                    DisplayMainMenu.Display();
                    DisplayMainMenu.Choose();
                    exit = true;
                    return;
                case "menu":
                    Display();
                    Choose();
                    break;
                case "1":
                    Console.WriteLine("Please enter the temperature in Celsius:");
                    methodInput = tempMenuOptions.ReadNumberInput();
                    CtoF(methodInput);
                    SubMenuPrompt();
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "2":
                    Console.WriteLine("Please enter the temperature in Celsius:");
                    methodInput = tempMenuOptions.ReadNumberInput();
                    CtoK(methodInput);
                    SubMenuPrompt();
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "3":
                    Console.WriteLine("Please enter the temperature in Fahrenheit:");
                    methodInput = tempMenuOptions.ReadNumberInput();
                    FtoC(methodInput);
                    SubMenuPrompt();
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "4":
                    Console.WriteLine("Please enter the temperature in Fahrenheit:");
                    methodInput = tempMenuOptions.ReadNumberInput();
                    FtoK(methodInput);
                    SubMenuPrompt();
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "5":
                    Console.WriteLine("Please enter the temperature in Kelvin:");
                    methodInput = tempMenuOptions.ReadNumberInput();
                    KtoC(methodInput);
                    SubMenuPrompt();
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "6":
                    Console.WriteLine("Please enter the temperature in Kelvin:");
                    methodInput = tempMenuOptions.ReadNumberInput();
                    KtoF(methodInput);
                    SubMenuPrompt();
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                default:
                    Console.WriteLine("Invalid entry, please enter an available menu option or type 'exit'");
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
            }
        } while (exit == false);
    }
}

