class Program 
{
    static void main()
    {
        Console.WriteLine(GameModeSelector);    
    }
    public static string GameModeSelector()
    {
        //the @ symbol makes it so the string is treated as "verbatim" (as displayed in the IDE)
        Console.WriteLine(@$"Welcome to my maths game! Please enter an option from the list below:
        A - Addition    
        S - Subtraction
        M - Multiplication
        D - Division
        R - Random");
        return Console.ReadLine();
    }
}