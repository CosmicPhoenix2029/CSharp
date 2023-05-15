//use "\" when you need to escape characters, such as "
Console.WriteLine("Example of including \"quotes\" in a string");

//String Concatenation
Console.WriteLine("What is your favourite song?");
string favouriteSong = Console.ReadLine();
Console.WriteLine("and Who is the Artist?");
string artist =  Console.ReadLine();

Console.WriteLine("Your favourite song is: " + favouriteSong + " by " + artist + ".");

//String interpolation
Console.WriteLine($"Your favourite song is: {favouriteSong} by {artist}.");

//String methods

//get the legnth of a string
string testing = "Testing";
Console.WriteLine($"The word {testing} is {testing.Length} characters long.");

//find the array position of a character in a string
string findArrayPosition = "testing";
Console.WriteLine($"The character \"i\", in the string {findArrayPosition} is located at array position {findArrayPosition.IndexOf("i")}");

//select parts of a string
string startStrand = "ATGCGATGAGCTTAC";
//find the start position of the matched string:
int tga = startStrand.IndexOf("TGA");
//define the start and endpoints of the search:
int startPoint = 0;
int length = tga + 3; //this increases the char array position by 3, ready to get the string required
//use substring() to get the required string out of the origional string
string dna = startStrand.Substring(startPoint, length);
Console.WriteLine(dna);
