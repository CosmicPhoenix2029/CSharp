namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");

            // set the questions, answers and responses arrays up
            string[] questions = new string[] { "The atomic number for lithium is 17", "An octopus has three hearts", "The black box in a plane is black", "Thomas Edison discovered gravity", "There are 14 bones in a human foot" };
            bool[] answers = new bool[] { false, true, false, false, false};

            //check if there are the same number of questions and answers
            if (questions.Length != answers.Length)
            {
                if (questions.Length < answers.Length)
                {
                    Console.WriteLine("WARNING! There are more questions than answers");
                }
                else
                {
                    Console.WriteLine("WARNING! There are less questions than answers");
                }
            }
            else
            {
                //example of method chaining
                Console.WriteLine(checkAnswers(RunQuiz(questions), answers));
            }
        }
        public static bool[] RunQuiz(string[] questions)
        {
            bool[] responses = new bool[questions.Length];
            //iterate through each question and capture user's input
            int askingIndex = 0;
            foreach (string question in questions)
            {
                bool isBool;
                bool inputBool;
                Console.WriteLine($"\n{question}\nTrue or False?");
                string input = Console.ReadLine();

                //check if the users input can be converted to boolean
                //this sets the inputBool to either true or false, but sets isBool to false if conversion fails
                isBool = bool.TryParse(input, out inputBool);

                //if the users answer cannot be converted to bool - ask the question again
                while (!isBool)
                {
                    Console.WriteLine("Please respond with either 'true' or 'false'");
                    Console.WriteLine($"\n{question}\nTrue or False?");
                    input = Console.ReadLine();
                    isBool = bool.TryParse(input, out inputBool);
                }
                //add the users response to the responses array
                responses[askingIndex] = inputBool;
                askingIndex++;
            }
            return responses;
        }
        public static string checkAnswers(bool[]responses, bool[] answers)
        {
            //now we need to compare the users responses to the answers
            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            return ($"You scored {score} out of {answers.Length}!");
        }
    }
}
