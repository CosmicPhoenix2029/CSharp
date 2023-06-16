using System.Diagnostics;
using System.Security.Cryptography;

namespace MathGame;
public class GameEngine
{
    //gameEngine properties:
    public string GameMode { get; set; }
    public string Difficulty { get; set; }
    public int NumberOfQuestions { get; set; }
    public int Score { get; private set; }
    //using stopwatch to get the time elapsed in game
    public TimeSpan TimeTaken { get; set; }
    //list to store the game history:
    public List<string> Results { get; set; }
    
    //construct a new game
    public GameEngine(string gameMode, string difficulty, int numberOfQuestions)
    {
        GameMode = gameMode;
        Difficulty = difficulty;
        NumberOfQuestions = numberOfQuestions;
        Results = new List<string> { };
        Score = 0;
    }

    //iterate through the number of questions, passing the GameMode and Difficulty onto the GameItem class
    public string StartGame()
    {
        long startTime = Stopwatch.GetTimestamp();
        for (int i = 0; i < NumberOfQuestions; i++)
        {
            GameItem question = new GameItem(GameMode, Difficulty);
            string result = question.AskQuestion();
            Results.Add(result);
            //increment the score if correct:
            if (question.PlayerAnswer == question.CorrectAnswer) { Score++; }
        }
        TimeTaken = Stopwatch.GetElapsedTime(startTime);
        return RecordGame();
    }

    public string RecordGame()
    {
        string gameMode = "";
        string difficulty = "";
        //switch through the gamemodes to add to results
        switch (GameMode) 
        {
            case "A": gameMode = "Addition"; break;
            case "S": gameMode = "Subtraction"; break;
            case "M": gameMode = "Multiplication"; break;
            case "D": gameMode = "Division"; break;
            case "R": gameMode = "Random"; break;
        }

        switch (Difficulty) 
        {
            case "E": gameMode = "Easy"; break;
            case "M": gameMode = "Medium"; break;
            case "H": gameMode = "Hard"; break;
        }

        string gameResults = $"GameMode: {gameMode}\n"
            + $"Difficulty: {difficulty}\n"
            + $"Number of questions: {NumberOfQuestions}\n"
            + $"Total score: {Score}\n"
            + $"Time taken: {TimeTaken}\n"
            + "Listed below are the questions and answers:\n";
        //add each result to the game record
        foreach (string result in Results)
        {
            gameResults += result;  
        }
        return gameResults;
    }
}
