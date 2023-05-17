//if statement (execute if the specified condition is true)
Console.WriteLine("enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine($"{number} is a positive number");
}
else if (number < 0) 
{
    Console.WriteLine($"{number} is a negative number");
}
else
{
    Console.WriteLine($"{number} is neither positive or negative");
}

//switch statment (if several conditions with their own unique output need to be evaluated, this is the perferred method)
Console.WriteLine("select a menu option:\n\r1. Exchange Management\n\r2. Active Directory Managment\n\r3. Server Management");
int menuOption = Convert.ToInt32(Console.ReadLine());
switch (menuOption)
{
    case 1:
        Console.WriteLine("Welcome to Exchange Management");
        break;
    case 2:
        Console.WriteLine("Welcome to Active Directory Management");
        break;
    case 3:
        Console.WriteLine("Welcome to Server Managment");
        break;
    //default handles like an else (catch all)
    default:
        Console.WriteLine("invalid option selected");
        break;
}