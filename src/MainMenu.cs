public class MainMenu
{
    public void Display()
    {
        Console.WriteLine("Welcome to my collection of console applications!");
        Console.WriteLine("1. Temperature conversions");
        //Done
        Console.WriteLine("2. Length conversions");
        //Lengths to convert between, cm to feet and inches, km to miles, metres to yards
        Console.WriteLine("3. Currency conversions");
        //Look into APIs to use for this
        Console.WriteLine("Chose a program by entering the corresponding number or type 'exit':");
        Console.WriteLine();
    }

    public void Choose()
    {
        ReadInput mainMenuOptions = new ReadInput();
        MainMenu DisplayMainMenu = new MainMenu();
        string? mainMenuChoice = mainMenuOptions.ReadConsoleInput();
        bool exit = false;

        do
        {
            switch (mainMenuChoice)
            {
                case "exit":
                    exit = true;
                    System.Environment.Exit(0);
                    return;
                case "1":
                    TemperatureConversions tempMainOption = new TemperatureConversions();
                    tempMainOption.ChooseTempConversion();
                    break;
                case "2":
                    LengthConversions lengthMainOption = new LengthConversions();
                    lengthMainOption.ChooseLengthConversion();
                    break;
                case "3":
                    DisplayMainMenu.Display();
                    Console.WriteLine("Under construction, please check back at a later date.");
                    mainMenuChoice = mainMenuOptions.ReadConsoleInput();
                    break;
                default:
                    DisplayMainMenu.Display();
                    Console.WriteLine("Invalid number, please enter an available menu option or type 'exit'");
                    mainMenuChoice = mainMenuOptions.ReadConsoleInput();
                    break;
            }
        } while (exit == false);
    }
}