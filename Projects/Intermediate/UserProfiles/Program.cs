/*
 !CODEACADEMY PROJECT!
 This program will allow users to create there own profiles with the following information:
 - name
 - age
 - city
 - country
 - pronouns
 - hobbies

This will allow the user perform the follwing actions:
 - create a new profile
 - add hobbies
 - view profile
 */

namespace UserProfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            //here using the new string[] we can build an array inside a method call
            sam.SetHobbies(new string[] {"listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"});
            Console.WriteLine(sam.ViewProfile());
        }
    }
}
