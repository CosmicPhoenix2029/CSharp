//C# follows the order of operations, to ensure correct calulations, denote equations correctly. E.G. 8 + (9 * 3)

//This program will calculate the users age, on Jupiter

//User Age
Console.WriteLine("Please enter your age:");
int userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Earth Age: {userAge}");

//Jupiter
double jupiterYears = 11.86;
double jupiterAge = userAge / jupiterYears;
Console.WriteLine($"Jupiter Age: {jupiterAge}");

//Mars
double marsYears = 1.882;
double marsAge = userAge / marsYears;
Console.WriteLine($"Mars Age: {marsAge}");

//Saturn
double saturnYears = 29;
double saturnAge = userAge / saturnYears;
Console.WriteLine($"Saturn Age: {saturnAge}");

//Venus
double venusYears = 0.616;
double venusAge = userAge / venusYears;
Console.WriteLine($"Venus Age: {venusAge}");

//Mercury
double mercuryYears = 0.241;
double mercuryAge = userAge / mercuryYears;
Console.WriteLine($"Mercury Age: {mercuryAge}");

//Uranus
double uranusYears = 84;
double uranusAge = userAge / uranusYears;
Console.WriteLine($"Uranus Age: {uranusAge}");

//Neptune
double neptuneYears = 165;
double neptuneAge = userAge / neptuneYears;
Console.WriteLine($"Neptune Age: {neptuneAge}");
