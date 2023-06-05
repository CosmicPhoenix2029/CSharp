using System;

namespace AppInterfacesProject
{
    class TodoList : IDisplayable
    {
        //properties and fields
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        //constructor
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        //methods
        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            //use string.join to print each item in a string array
            Console.Write($"\nTodo list\n---------\n{string.Join("\n", Todos)}");
        }
    }
}