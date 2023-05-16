/*created to practice arithmatic operators

 - bronze coin is worth 1p
 - silver coin is worth 5p
 - gold coin is worth 10p

this program will calculate the minimum number of coins needed for a given number
*/

//get user input
Console.WriteLine("Welcome to the coin calculator!");
Console.WriteLine("Enter an amount to convert to coins:");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{number}p is equal to...");

//define coin values
int gold = 10;
int silver = 5;

//how many gold coins fit into the provided number?
double goldCoins = Math.Floor(number / gold);

//how many coins are remaining?
double remainingCoins = number % gold;

//how many silver coins fit into the remainingCoins?
double silverCoins =  Math.Floor(remainingCoins / silver);

//how many coins are remaining?
double bronzeCoins = Math.Floor(remainingCoins % silver);

//output the final result:
Console.WriteLine($"Gold coins: {goldCoins}\n\r Silver coins: {silverCoins}\n\r Bronze coins: {bronzeCoins}");