using System;

/*
 A basic application which contains a todo list and a password manager
 The body of this method is basically just me testing that the outputs are correctly formatted and work.
 */
namespace AppInterfacesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Display();

            PasswordManager pm = new PasswordManager("iluvpie", true);
            pm.Display();
            pm.Reset();
            pm.Display();

            pm.ChangePassword("", "TESTING123");
            pm.Display();
        }
    }
}
