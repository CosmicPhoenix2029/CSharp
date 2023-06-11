namespace MathGame;
public class GameEngine
{
    //gameEngine properties:
    public string GameMode { get; set; }
    public string Difficulty { get; set; }
    public int NumberOfQuestions { get; set; }
    //only allow this class to add and set results
    private List<string> Results { get; set; }
    //keep track of the score
    private int Score { get; set; }
    //construct a new game
    public GameEngine(string gameMode, string difficulty, int numberOfQuestions)
    {
        GameMode = gameMode;
        Difficulty = difficulty;
        NumberOfQuestions = numberOfQuestions;
    }

    public void AdditionQuestion(string difficulty)
    {
        string question;
        int playerAnswer;
        int answer;
        Random randomNumber = new Random();
        int numOne = randomNumber.Next(1, 100);
        int numTwo = randomNumber.Next(1, 100);
        int numThree = randomNumber.Next(1, 100);
        int numFour = randomNumber.Next(1, 100);

        switch (difficulty) 
        {
            case "E":
                question = $"What is {numOne} + {numTwo}?";
                answer = numOne + numTwo;
                playerAnswer = int.Parse(Console.ReadLine());
                Results.Add(@$"The Question was: {question}
                You Answered: {playerAnswer}
                The correct Answer was: {answer}");
                break;

            case "M":
                question = $"What is {numOne} + {numTwo} + {numThree}?";
                answer = numOne + numTwo + numThree;
                playerAnswer = int.Parse(Console.ReadLine());
                Results.Add(@$"The Question was: {question}
                You Answered: {playerAnswer}
                The correct Answer was: {answer}");
                break;

            case "H":
                question = $"What is {numOne} + {numTwo} + {numThree} + {numFour}?";
                answer = numOne + numTwo + numThree + numFour;
                playerAnswer = int.Parse(Console.ReadLine());
                Results.Add(@$"The Question was: {question}
                You Answered: {playerAnswer}
                The correct Answer was: {answer}");
                break;
        }       

    }
}
