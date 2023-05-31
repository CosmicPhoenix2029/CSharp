//While: 
//executes while a condition is met
using System.Runtime.CompilerServices;

int emails = 20;
while (emails != 0) 
{
    //delete email
    emails--;
}

//do While:
//this will loop until a stopping condition is met
//a do while loop will always run once, unlike a while loop which only runs while condition is met
bool buttonClick = true;

do
{
    Console.WriteLine("BEEP BEEP BEEP");
}
while (!buttonClick);


//for:
//great if you want the loop to iterate a set number of times
for (int i = 0; i < 10; i++)
{ 
    Console.WriteLine(i);
}

//foreach:
//great for iterating through items inside another object such as an array or list
string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
foreach (string task in todo)
{
    Console.WriteLine($"[] {task}");
}

/*
while loops are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.

do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.

for loops are best if you want something to run a specific number of times, rather than given a certain condition.

foreach loops are the best way to loop over an array, or any other collection.
 */


//flow control:

//break
//this breaks out of the loop when used
bool playerIsAlive = true;
while (playerIsAlive)
{
    // this code will keep running

    if (playerIsAlive == false)
    {
        // eventually if this stopping condition is true, 
        // it will break out of the while loop
        break;
    }
}

// rest of the program will continue

//contimue
//this is used to skip portions of code when used
int bats = 10;

for (int i = 0; i <= 10; i++)
{
    if (i < 9)
    {
        continue;
    }
    // this will be skipped until i is no longer less than 9
    Console.WriteLine(i);
}


//return
//this is used within methods to return to the point where the method was called
class MainClass
{
    public static void Main(string[] args)
    {
        UnlockDoor();

        // after it hits the return statement, it will move on to this method
        PickUpSword();
    }

    static bool UnlockDoor()
    {
        bool doorIsLocked = true;

        // this code will keep running
        while (doorIsLocked)
        {
            bool keyFound = TryKey();

            // eventually if this stopping condition is true,
            // it will break out of the while loop
            if (keyFound)
            {
                // this return statement will break out of the entire method
                return true;
            }
        }
        return false;
    }
}


