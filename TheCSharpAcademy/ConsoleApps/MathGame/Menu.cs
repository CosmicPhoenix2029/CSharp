namespace MathGame;
public class Menu
{
    //get the gamemode
    public static string GameModeSelector()
    {
        //the @ symbol makes it so the string is treated as "verbatim" (as displayed in the IDE)
        Console.WriteLine(@$"Welcome to my maths game! Please enter an option from the list below:
        A - Addition    
        S - Subtraction
        M - Multiplication
        D - Division
        R - Random");
        string response = Console.ReadLine().ToUpper();
        Console.Clear();

        char[] validAnswers = { 'A', 'S', 'M', 'D', 'R' };
        foreach (char c in validAnswers)
        {
            if (response.Contains(c)) 
            { 
                return response;
            }
        }
        //if it broke out of the loop at this point, the answer was not valid
        Console.WriteLine(@$"{response} is not a valid menu option.
        Valid Options are A, S, M, D or R
        Your gamemode has been set to R");
        Thread.Sleep(5);
        Console.Clear();
        response = "R";
        return response;
    }

    //get the difficulty:
    public static string GetDifficulty()
    {
        Console.WriteLine($@"Please select a difficulty:
        E - Easy
        M - Medium
        H - Hard");
        string difficulty = Console.ReadLine().ToUpper();
        Console.Clear();
        //ensuring the response is valid
        char[] validAnswers = { 'E', 'M', 'H'};
        foreach (char c in validAnswers) {
            if (difficulty.Contains(c)) 
            {
                return difficulty;
            }
        }
        //if it broke out of the loop at this point, the answer was not valid
        Console.WriteLine(@$"{difficulty} is not a valid menu option.
        Valid Options are E, M or H
        Your difficulty has been set to M");
        Thread.Sleep(5);
        Console.Clear();
        difficulty = "M";
        return difficulty;
    }

    //Get the number of questions:
    public static int GetNumberOfQuestions()
    {
        bool convertedToInt = false;
        Console.WriteLine("How many questions would you like to answer?");
        convertedToInt = int.TryParse(Console.ReadLine(), out int numOfQuestions);
        //only return players answer if the response is a positive integer:
        if ((convertedToInt) && (numOfQuestions > 0))
        {
            return numOfQuestions;
        }
        else
        {
            Console.WriteLine("Invalid Input -- defaulting to 5 questions");
            Thread.Sleep(2);
            Console.Clear();
            return 5;
        }
    }
}
