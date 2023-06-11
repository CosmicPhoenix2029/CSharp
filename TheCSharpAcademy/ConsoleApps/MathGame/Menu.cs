namespace MathGame;
public class Menu
{
    //get the gamemode
    public static string GameModeSelector()
    {
        string response = String.Empty;
        while (!(response == "A") || (response == "S") || (response == "M") || (response == "D") || (response == "R"))
        {
            Console.WriteLine(@$"Welcome to my maths game! Please enter an option from the list below:
            A - Addition    
            S - Subtraction
            M - Multiplication
            D - Division
            R - Random");
            response = Console.ReadLine().ToUpper();
            Console.Clear();
        }
        return response;
    }

    //get the difficulty:
    public static string GetDifficulty()
    {
        string difficulty = String.Empty;

        //loop through until a valid option is entered:
        while (!(difficulty == "E") || (difficulty == "M") || (difficulty == "H"))
        {
            Console.WriteLine($@"Please select a difficulty:
            E - Easy
            M - Medium
            H - Hard");

            difficulty = Console.ReadLine().ToUpper();
            Console.Clear();
        }
        return difficulty;
    }

    //Get the number of questions:
    public static int GetNumberOfQuestions()
    {
        bool convertedToInt = false;
        int numOfQuestions = 0;
        //loop through until a valid number is entered:
        while ((!convertedToInt) || (numOfQuestions <= 0))
        {
            Console.WriteLine("How many questions would you like to answer?");
            convertedToInt = int.TryParse(Console.ReadLine(), out numOfQuestions);
            Console.Clear();
        }
        return numOfQuestions;   
    }
}
