 //This is a program I made just to practice interpolation and getting user input
 //Full disclaimer this is from the codeAcademy C# tutorials

// Let the user know that the program is starting:
Console.WriteLine("Program Started...");

// Giving the game a title:
string title = "story generator";

Console.WriteLine(title);
// Define user input and variables:
Console.Write("Enter a name: ");
string name = Console.ReadLine();

//adjectives
 Console.WriteLine("Enter adjective one: ");
string firstAdjective = Console.ReadLine();
Console.WriteLine("Enter adjective two: ");
string secondAdjective = Console.ReadLine();
Console.WriteLine("Enter adjective three: ");
string thirdAdjective = Console.ReadLine();

//verbs
Console.WriteLine("Enter a verb: ");
string verb = Console.ReadLine();


//nouns
Console.WriteLine("Enter noun one: ");
string firstNoun = Console.ReadLine();
Console.WriteLine("Enter noun two: ");
string secondNoun = Console.ReadLine();

//misc 
Console.WriteLine("Enter an animal: ");
string animal = Console.ReadLine();
Console.WriteLine("Enter a food: ");
string food = Console.ReadLine();
Console.WriteLine("Enter a fruit: ");
string fruit = Console.ReadLine();
Console.WriteLine("Enter a superhero: ");
string hero = Console.ReadLine();
Console.WriteLine("Enter a country: ");
string country = Console.ReadLine();
Console.WriteLine("Enter a dessert: ");
string dessert = Console.ReadLine();
Console.WriteLine("Enter a year: ");
string year = Console.ReadLine();

// The template for the story:
string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


// Print the story:
Console.WriteLine(story);