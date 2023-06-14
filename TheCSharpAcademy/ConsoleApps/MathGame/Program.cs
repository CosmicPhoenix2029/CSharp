namespace MathGame;
class Program 
{
    static void Main(string[] args)
    {
        //add a list to store all results

        //get gamemode and validate input
        string gameMode = Menu.GetGameMode();
        string difficulty = Menu.GetDifficulty();
        int numberOfQuestions = Menu.GetNumberOfQuestions();

        //create a new game
        GameEngine game = new GameEngine(gameMode, difficulty, numberOfQuestions);

        game.StartGame();

    }
}