//project to practice conditional logic and comparison operators

int minLength = 8;
string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lowercase = uppercase.ToLower();
string digits = "0123456789";
string specialChars = "!\"£$%^&*()?~#@':;{[]}";

//ask the user to enter a password:
Console.WriteLine("Please enter a password");
string password  = Console.ReadLine();

//scoring the password based on complexity
int score  = 0;
score += (password.Length >= minLength)  ? 1 : 0;
score += (password.Any(char.IsUpper)) ? 1 : 0; //bit of linq used here
score += (password.Any(char.IsLower)) ? 1 : 0; //bit of linq used here
score += (password.Any(char.IsDigit)) ? 1 : 0; //bit of linq used here
score += (password.Any(char.IsSymbol))  ? 1 : 0; //bit of linq used here

switch (score)
{
    case 0:
        Console.WriteLine("Your password did not meet the requirements");
        break;
    case 1:
        Console.WriteLine("Your password is weak");
        break;
    case 2:
        Console.WriteLine("Your password is fair");
        break;
    case 3:
        Console.WriteLine("Your password is ok");
        break;
    case 4:
        Console.WriteLine("Your password is strong");
        break;
    case 5:
        Console.WriteLine("Your password is very strong");
        break;
}

