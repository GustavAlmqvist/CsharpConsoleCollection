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
        string? methodInput;
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
                    methodInput = lengthMenuOptions.ReadConsoleInput();
                   // CmToFeetAndInches(methodInput);
                    lengthMenuChoice = lengthMenuOptions.ReadConsoleInput();
                    break;
                case "2":
                    Console.WriteLine("Please enter the value you wish to convert in centimeters:");
                    methodInput = lengthMenuOptions.ReadConsoleInput();
                   // CmToFeetAndInches(methodInput);
                    lengthMenuChoice = lengthMenuOptions.ReadConsoleInput();
                    break;
                case "3":
                    Console.WriteLine("Please enter the value you wish to convert in feet and inches:");
                    methodInput = lengthMenuOptions.ReadConsoleInput();
                   // CmToFeetAndInches(methodInput);
                    lengthMenuChoice = lengthMenuOptions.ReadConsoleInput();
                    break;
                default:
                    Console.WriteLine("Invalid entry, please enter an available menu option or type 'exit'");
                    lengthMenuChoice = lengthMenuOptions.ReadConsoleInput();
                    break;
            }
        } while (exit == false);
    }

//     string CmToFeetAndInches(string? cm)
//     {
//         float inches = float.Parse(cm); 
//         return cm;
//     }
}