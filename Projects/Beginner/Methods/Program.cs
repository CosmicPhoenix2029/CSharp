using System;

class Methods { 
    static void Main()
    {
        //calling the example methods
        ExampleMethod();

        //call method with parameter and use its return value
        Console.Write("Enter a number which you would like to find the square root of: ");
        double number = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The square root of {number} is: {GetSquareRoot(number)}");

        //calling a method with and without optional parameters
        DefaultSentence();
        string notDefault = "This is not the default sentence.";
        DefaultSentence(notDefault);

        //calling a method using named arguments
        //if I was to call the method like this: NamedArgumentsMethod(2, 11), this would populate parameters a and b - not b and c
        //instead when calling a method with multiple optional parameters, refer the to parameter names explicitly as done below:
        NamedArgumentsMethod(b: 2, c: 11);

        //calling an overloaded method
        NamePets("blue", "teal");
        NamePets("blue", "teal", "rosie");

        //method call which makes use of the "out" feature
        //this is useful when you want to return multiple values
        string text = Whisper("SOME text", out bool wasMethodCalled);
        Console.WriteLine($"{text}, {wasMethodCalled}");
    }
    //defining a method (best practice is to use pascal case for method names)
    static void ExampleMethod()
    {
        Console.WriteLine("Method call successful");
    }

    //example method with a parameter and return value
    static double GetSquareRoot(double num)
    {
        return Math.Sqrt(num);
    }

    //example method with optional parameters
    static void DefaultSentence(string example = "This is the default sentence.")
    {
        Console.WriteLine(example);
    }

    //named arguments (used when there are multiple optional parameters, and you don't need to specify all of them).
    static void NamedArgumentsMethod(int a = 0, int b = 1, int c = 2)
    {
        Console.WriteLine($"{a} {b} {c}");
    }

    //method overloading 
    //this is the process of writing a differant implementation of an existing method
    static void NamePets(string petOne, string petTwo)
    {
        Console.WriteLine($"Your pets {petOne} and {petTwo} will be joining your voyage across space!");
    }

    static void NamePets(string petOne, string petTwo, string petThree)
    {
        Console.WriteLine($"Your pets {petOne}, {petTwo} and {petThree} will be joining your voyage across space!");
    }

    //method which makes use of out (really good use is for flags eg. function failed or succeeded)
    static string Whisper(string phrase, out bool wasMethodCalled)
    {
        wasMethodCalled = true;
        return phrase.ToLower();
    }
}
