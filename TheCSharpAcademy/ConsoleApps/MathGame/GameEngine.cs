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

    //ask a question (takes in the gamemode, difficulty and an operand as params)
    //if the player chooses random gamemode, then generate a random number and use that to index into the operations array
    public void AskQuestion()
    {
        string question;
        int playerAnswer;
        int answer;
        char[] operations = { '+', '-', '*', '/'};
        Random randomNumber = new Random();
        //generate 4 random numbers
        int numOne = randomNumber.Next(1, 100);
        int numTwo = randomNumber.Next(1, 100);
        int numThree = randomNumber.Next(1, 100);
        int numFour = randomNumber.Next(1, 100);
        //switch through the gamemode, and then the difficulty
        switch (this.GameMode) 
        {
            case "A": //Addition GameMode:
                switch (this.Difficulty)
                {
                    case "E": //Easy Difficulty:
                        question = $"What is: {numOne} + {numTwo}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne + numTwo;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;

                    case "M": //Medium Difficulty:
                        question = $"What is: {numOne} + {numTwo} + {numThree}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne + numTwo + numThree;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;

                    case "H": //Hard Difficulty:
                        question = $"What is: {numOne} + {numTwo} + {numThree} + {numFour}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne + numTwo + numThree + numFour;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;
                }
                break;

            case "S": //Subtract gamemode:
                switch (this.Difficulty)
                {
                    case "E": //Easy Difficulty:
                        question = $"What is: {numOne} - {numTwo}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne - numTwo;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;

                    case "M": //Medium Difficulty:
                        question = $"What is: {numOne} - {numTwo} - {numThree}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne - numTwo - numThree;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;

                    case "H": //Hard Difficulty:
                        question = $"What is: {numOne} - {numTwo} - {numThree} - {numFour}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne - numTwo - numThree - numFour;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;
                }
                break;

            case "M": //Multiplication gameMode:
                switch (this.Difficulty)
                {
                    case "E": //Easy Difficulty:
                        question = $"What is: {numOne} * {numTwo}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne * numTwo;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;

                    case "M": //Medium Difficulty:
                        question = $"What is: {numOne} * {numTwo} * {numThree}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne * numTwo * numThree;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;

                    case "H": //Hard Difficulty:
                        question = $"What is: {numOne} * {numTwo} * {numThree} * {numFour}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne * numTwo * numThree * numFour;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;
                }
                break;

            case "D": //Division gameMode:
                switch (this.Difficulty)
                {
                    case "E": //Easy Difficulty:
                        question = $"What is: {numOne} / {numTwo}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne / numTwo;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;

                    case "M": //Medium Difficulty:
                        question = $"What is: {numOne} / {numTwo} / {numThree}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne / numTwo / numThree;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;

                    case "H": //Hard Difficulty:
                        question = $"What is: {numOne} / {numTwo} / {numThree} / {numFour}";
                        Console.WriteLine(question);
                        playerAnswer = int.Parse(Console.ReadLine());
                        answer = numOne / numTwo / numThree / numFour;
                        Results.Add(@$"The Question was: {question}
                        You Answered: {playerAnswer}
                        The correct Answer was: {answer}");
                        break;
                }
                break;

            case "R":
                switch (this.Difficulty)
                {
                    case "E":
                        break;
                    case "M":
                        break;
                    case "H":
                        break;
                }
                break;
        }
    }
}
