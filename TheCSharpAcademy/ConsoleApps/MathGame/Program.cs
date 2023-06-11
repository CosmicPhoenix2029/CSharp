namespace MathGame;
class Program 
{
    static void Main(string[] args)
    {
        //get gamemode and validate input
        string gameMode = Menu.GameModeSelector();
        string difficulty = Menu.GetDifficulty();
        int numberOfQuestions = Menu.GetNumberOfQuestions();

        //create a new game
        GameEngine game = new GameEngine(gameMode, difficulty, numberOfQuestions);
    }
}