//program to demonstrate the uses behind the built-in maths functions

//Use the documentation to find the full list of methods
//https://learn.microsoft.com/en-us/dotnet/api/?view=net-7.0

//Math.Abs() -- returns the absolute value of a number

//Math.Sqrt() -- returns the square root of a number
//Math.Pow() -- raises the first number 

//Math.Floor() -- rounds the number down
//Math.Ceiling() -- rounds the number up

//Math.Min() -- returns the smaller of 2 numbers
//Math.Max() -- returns the larger of 2 numbers

//determine which number is smaller between the square roots of 2 numbers
int numberOne = 12932;
int numberTwo = -2828472;

//find the square root and round the result down
double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

//as Math.Sqrt() can only work with positive numbers, we need to use Math.Abs() to conver numberTwo into a positive integer
double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

//use Math.Min to return the smallest number
Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));


