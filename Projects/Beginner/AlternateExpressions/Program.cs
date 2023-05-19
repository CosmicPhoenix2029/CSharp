class AlternateExpressions { 
    static void Main(String[] args) {
        //Expression-bodied definition
        bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        //can be rewritten as:
        bool isEven(int num) => num % 2 == 0;
        //note the => is a replacement for the return keyword.

        //more examples:
        static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");
        static double DaysToRotations(double days) => days / 365;


        //lambda expressions

        //below is an example of the standard method of passing in an array, and a method, into another method
        //using array.Find() to get first word in the array which is more than 8 characters long:
        //this automatically iterates through the array items and passes them into the IsLong() method
        string[] adjectivesOne = { "rocky", "mountainous", "cosmic", "extraterrestrial" };
        static bool IsLong(string word) => word.Length > 8;

        string firstLongAdjectiveOne = Array.Find(adjectivesOne, IsLong);
        Console.WriteLine($"The first long word is: {firstLongAdjectiveOne}.");

        //lamda expressions are great when you need to pass in a method as an argument to another method
        //with Lambda expressions, you define the passed in method, within the method call, as below
        string[] adjectivesTwo = { "rocky", "mountainous", "cosmic", "extraterrestrial" };
        //Note, when defining a method within a lamda expression, the method does not have a name, just the input parameters, and the return data.
        string firstLongAdjectiveTwo = Array.Find(adjectivesTwo, (string word) => word.Length > 8);
        Console.WriteLine($"The first long word is: {firstLongAdjectiveTwo}.");

        //even shorter lambda expressions
        int[] numbers = { 1, 2, 3, 4, 5 };
        bool HasEvenNumbers = Array.Exists(numbers, (int num) => num % 2 == 0);
        //from the expression above, we can remove the int, as we can infer that the num variable is an int, as we are using the modulo operator against an int
        //when there is only one parameter, the () can be removed too
        bool EvenNumbers = Array.Exists(numbers, num => num % 2 == 0);
    }


}

