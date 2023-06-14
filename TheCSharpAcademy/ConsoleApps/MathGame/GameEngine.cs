using System.Numerics;

namespace MathGame;
public class GameEngine
{
    //gameEngine properties:
    public string GameMode { get; set; }
    public string Difficulty { get; set; }
    public int NumberOfQuestions { get; set; }
    //only allow this class to add and set results
    private List<GameItem> Results { get; set; }
    //keep track of the score
    private int Score { get; set; }
    //construct a new game
    public GameEngine(string gameMode, string difficulty, int numberOfQuestions)
    {
        GameMode = gameMode;
        Difficulty = difficulty;
        NumberOfQuestions = numberOfQuestions;
        Results = new List<GameItem> { };
    }
    //iterate through the number of questions, passing the GameMode and Difficulty onto the GameItem class
    public void StartGame()
    {
        for (int i = 0; i < NumberOfQuestions; i++)
        {
            GameItem question = new GameItem(GameMode, Difficulty);
            question.AskQuestion();
            Results.Add(question);
        }
    }
}
