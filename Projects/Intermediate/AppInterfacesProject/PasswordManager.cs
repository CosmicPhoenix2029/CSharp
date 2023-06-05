using System;
using System.ComponentModel;

namespace AppInterfacesProject
{
    class PasswordManager : IDisplayable, IResetable
    {
        //properties and fields
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        //constructor
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        //methods
        public void Display()
        {
            //if password is hidden print asterisks instead
            string output = (Hidden == false) ? Password : "**********";
            Console.WriteLine($"Password\n----------\n{output}\n");
        }
        public void Reset() 
        {
            Password = "";
            Hidden = false;
        }
        public bool ChangePassword(string currentPassword, string newPassword)
        {
            if (currentPassword == Password)
            {
                Password = newPassword;
                Hidden = true;
                return true;
            }
            else 
            {
                Console.WriteLine("WARNING! The password could not be changed as the entered password was not correct.");
                return false;
            }
        }
    }
}