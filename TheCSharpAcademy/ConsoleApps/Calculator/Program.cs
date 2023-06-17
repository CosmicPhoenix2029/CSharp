namespace CalculatorProgram;

class Program
{
    static List<Calculator> recentCalculations = new();

    static void Main()
    {     
        MainMenu();
    }

    static void MainMenu()
    {
        Console.WriteLine(@"Please Select an option from the list below:
        1. New Calculation
        2. View latest calculations
        3. Delete the previous calculations
        Press any other key to exit: ");

        string response = Console.ReadLine()!;

        switch (response)
        {
            case "1": NewCalculation(); break;
            case "2": ViewLatestOperations(); break;
            case "3": ClearList(); break;
            default: break;
        }
    }

    static void NewCalculation()
    {
        double num1 = GetNumber();
        string operationType = GetOperationType();

        string[] singleNumberOperations = { "r", "x", "i", "c", "t"};
        if (singleNumberOperations.Contains(operationType))
        {
            Calculator calculator = new(num1, operationType); 
            recentCalculations.Add(calculator);
        }
        else 
        {
            double num2 = GetNumber();
            Calculator calculator = new(num1, operationType, num2);
            recentCalculations.Add(calculator);
        }
        MainMenu();
    }

    static double GetNumber()
    {
        Console.Write("Type a number, and then press Enter: ");
        string input = Console.ReadLine();
        double num;

        while (!double.TryParse(input, out num))
        {
            Console.Write("This is not valid input. Please enter an integer value: ");
            input = Console.ReadLine();
        }
        return num;
    }

    static string GetOperationType()
    {
        string[] validOptions = { "a", "s", "m", "d", "r", "p", "x", "i", "c", "t" };
        string response;

        do
        {
            //get the operation type
            Console.WriteLine("choose an operation from the list below:\n"
            + "a - Add\n"
            + "s - Subtract\n"
            + "m - Multiply\n"
            + "d - Divide\n"
            + "r - Square root\n"
            + "p - Power of\n"
            + "x - x10\n"
            + "i - Sine\n"
            + "c - Cosine\n"
            + "t - Tangent\n");
            response = Console.ReadLine().ToLower();
        }
        while (!(validOptions.Contains(response)));

        return response;
    }

    static void ViewLatestOperations()
    {
        foreach (Calculator operation in recentCalculations)
        {
            Console.WriteLine($"{operation.Num1} {operation.OperationType} {operation.Num2}");
        }

        Console.WriteLine("Press any key to return to the main menu");
        Console.ReadKey();
        MainMenu();
    }

    static void ClearList()
    {
        recentCalculations.Clear();
        Console.WriteLine("List cleared successfully");
        MainMenu();
    }
}