namespace CalculatorProgram;

class Program
{
    //list to display
    static List<string> recentCalculations = new();
    //list for re-using previous results
    static List<double> recentResults = new();

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
            calculator.DoOperation();
            recentCalculations.Add(FormatOneNumberOperation(calculator));
            recentResults.Add(calculator.Result);
        }
        else 
        {
            double num2 = GetNumber();
            Calculator calculator = new(num1, operationType, num2);
            calculator.DoOperation();
            FormatTwoNumberOperation(calculator);
            recentCalculations.Add(FormatTwoNumberOperation(calculator));
            recentResults.Add(calculator.Result);
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

    static string FormatOneNumberOperation(Calculator calculator)
    {
        return calculator.OperationType switch
        {
            "r" => $"√{calculator.Num1} = {calculator.Result}",
            "i" => $"sin({calculator.Num1}) = {calculator.Result}",
            "c" => $"cos({calculator.Num1}) = {calculator.Result}",
            "t" => $"tan({calculator.Num1}) = {calculator.Result}",
            "x" => $"{calculator.Num1} * 10 = {calculator.Result}",
            _ => $"{calculator.Num1} unknownOperation = {calculator.Result}"
        };   
    }

    static string FormatTwoNumberOperation(Calculator calculator)
    {
        return calculator.OperationType switch
        {
            "a" => $"{calculator.Num1} + {calculator.Num2} = {calculator.Result}",
            "s" => $"{calculator.Num1} - {calculator.Num2} = {calculator.Result}",
            "m" => $"{calculator.Num1} * {calculator.Num2} = {calculator.Result}",
            "d" => $"{calculator.Num1} / {calculator.Num2} = {calculator.Result}",
            "p" => $"{calculator.Num1} ^ {calculator.Num2} = {calculator.Result}",
            _ => $"{calculator.Num1} unknownOperation {calculator.Num2} = {calculator.Result}"
        };
    }

    static void ViewLatestOperations()
    {
        foreach (string operation in recentCalculations)
        {
            Console.WriteLine($"{operation}");
            //Console.WriteLine($"{operation.Num1} {operation.OperationType} {operation.Num2}");
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