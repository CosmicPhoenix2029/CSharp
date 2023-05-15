//To increment by 1 use the below syntax
Console.WriteLine("Please enter a number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Starting number: {num}");
int incrementByOne = num++;
Console.WriteLine($"Number incrementing by one: {incrementByOne}");

//adding a number greater than one
int incrementByMoreThanOne = num+= 5;
Console.WriteLine($"Number incrementing by 5 {incrementByMoreThanOne}");

//decrement by one
int decrementByOne = num--;
Console.WriteLine($"Number decrementing by 1: {decrementByOne}");

//decrement by more than one
int decrementByMoreThanOne = num-= 5;
Console.WriteLine($"Number decrementing by 5: {decrementByMoreThanOne}");