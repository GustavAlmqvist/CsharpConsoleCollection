//TBC
public class LengthConversions()
{
    public void ChooseLengthConversion()
    {
        Console.WriteLine("Please select which units you are converting between:");
        Console.WriteLine("1. Centimeters to feet and inches");
        Console.WriteLine("2. Centimeters to inches");
        Console.WriteLine("3. Feet and inches to centimeters");
        Console.WriteLine("4. Meters to yards and feet");
        Console.WriteLine("5. Yards to meters");
        Console.WriteLine("6. Kilometers to miles");
        Console.WriteLine("7. Miles to kilometers");

        bool exit = false;
        ReadInput lengthMenuOptions = new ReadInput();
        MainMenu DisplayMainMenu = new MainMenu();
        double methodInput;
        string? lengthMenuChoice = lengthMenuOptions.ReadConsoleInput();
        //Make methods for conversion and enter into switch statements
        do
        {
            switch (lengthMenuChoice)
            {
                case "exit":
                    DisplayMainMenu.Display();
                    DisplayMainMenu.Choose();
                    exit = true;
                    return;
                case "1":
                    Console.WriteLine("Please enter the value you wish to convert in centimeters:");
                    methodInput = lengthMenuOptions.ReadNumberInput();
                    Console.WriteLine($"{CmToFeetAndInches(methodInput)}");
                    lengthMenuChoice = lengthMenuOptions.ReadConsoleInput();
                    break;
                case "2":
                    Console.WriteLine("Please enter the value you wish to convert in centimeters:");
                    methodInput = lengthMenuOptions.ReadNumberInput();
                    Console.WriteLine($"Result: {methodInput}cm is {CmToInches(methodInput):F2} inches.");
                    lengthMenuChoice = lengthMenuOptions.ReadConsoleInput();
                    break;
                default:
                    Console.WriteLine("Invalid entry, please enter an available menu option or type 'exit'");
                    lengthMenuChoice = lengthMenuOptions.ReadConsoleInput();
                    break;
            }
        } while (exit == false);
    }

    double CmToFeet(double cm)
    {
        double feet = cm / 30.48;
        return feet;
    }
        double CmToInches(double cm)
    {
        double inches = cm / 2.54;
        return inches;
    }
    string CmToFeetAndInches(double cm)
    {
        string result;
        double feet = 0;
        double inches = 0;
        double cmCalc = 0;

        feet = (int) CmToFeet(cm);
        cmCalc = cm - (feet * 30.48);
        inches = CmToInches(cmCalc);
        result = $"Result: {cm}cm is {feet} feet and {inches:F2} inches.";

        return result;
    }
}