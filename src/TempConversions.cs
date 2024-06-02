public class TemperatureConversions
{
    public void ChooseTempConversion()
    {
        Console.WriteLine("Please select which units of temperature you are converting between:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Celsius to Kelvin");
        Console.WriteLine("3. Fahrenheit to Celsius");
        Console.WriteLine("4. Fahrenheit to Kelvin");
        Console.WriteLine("5. Kelvin to Celsius");
        Console.WriteLine("6. Kelvin to Fahrenheit");

        bool exit = false;
        ReadInput tempMenuOptions = new ReadInput();
        MainMenu DisplayMainMenu = new MainMenu();
        string? methodInput;
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
                case "1":
                    Console.WriteLine("Please enter the temperature in Celsius:");
                    methodInput = tempMenuOptions.ReadConsoleInput();
                    CtoF(methodInput);
                    //Sends you back to tempmenu - add functionality of staying in this option if entry in invalid.
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "2":
                    Console.WriteLine("Please enter the temperature in Celsius:");
                    methodInput = tempMenuOptions.ReadConsoleInput();
                    CtoK(methodInput);
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "3":
                    Console.WriteLine("Please enter the temperature in Fahrenheit:");
                    methodInput = tempMenuOptions.ReadConsoleInput();
                    FtoC(methodInput);
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "4":
                    Console.WriteLine("Please enter the temperature in Fahrenheit:");
                    methodInput = tempMenuOptions.ReadConsoleInput();
                    FtoK(methodInput);
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "5":
                    Console.WriteLine("Please enter the temperature in Kelvin:");
                    methodInput = tempMenuOptions.ReadConsoleInput();
                    KtoC(methodInput);
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                case "6":
                    Console.WriteLine("Please enter the temperature in Kelvin:");
                    methodInput = tempMenuOptions.ReadConsoleInput();
                    KtoF(methodInput);
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
                default:
                    Console.WriteLine("Invalid entry, please enter an available menu option or type 'exit'");
                    tempMenuChoice = tempMenuOptions.ReadConsoleInput();
                    break;
            }
        } while (exit == false);
    }
    void CtoF(string? TempC)
    {
        //double C = Convert.ToDouble(TempC);
        bool inputConversion = double.TryParse(TempC, out double C);
        
        if (inputConversion == true)
        {
        double F = C * 1.8 + 32;
        Console.WriteLine($"Result: {TempC} Celsius equals {F:F} Fahrenheit.");
        }
        else
        {
            Console.WriteLine("Conversion of your input failed, please enter it in a valid format e.g. '3' not 'three'");
        }
    }
    double CtoK(string? TempC)
    {
        double C = Convert.ToDouble(TempC);
        double K = C + 273.15;
        Console.WriteLine($"Result: {TempC} Celsius equals {K:F} Kelvin.");
        return K;
    }
    double FtoC(string? TempF)
    {
        double F = Convert.ToDouble(TempF);
        double C = (F - 32) * 1.8;
        Console.WriteLine($"Result: {TempF} Fahrenheit equals {C:F} Celsius.");
        return C;
    }
        double FtoK(string? TempF)
    {
        double F = Convert.ToDouble(TempF);
        double K = (F - 32) * 1.8 + 273.15;
        Console.WriteLine($"Result: {TempF} Fahrenheit equals {K:F} Kelvin.");
        return K;
    }
        double KtoC(string? TempK)
    {
        double K = Convert.ToDouble(TempK);
        double C = K - 273.15;
        Console.WriteLine($"Result: {TempK} Kelvin equals {C:F} Celsius.");
        return C;
    }
        double KtoF(string? TempK)
    {
        double K = Convert.ToDouble(TempK);
        double F = (K - 273.15) * 1.8 + 32;
        Console.WriteLine($"Result: {TempK} Kelvin equals {F:F} Fahrenheit.");
        return F;
    }
}

