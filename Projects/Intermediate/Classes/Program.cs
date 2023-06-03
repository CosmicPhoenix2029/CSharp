namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //using another class (creating an instance of a class)
            Forest forest = new Forest("Amazon", "Temperate");
            //accessing static information
            Forest.PrintTreeFacts();
            Console.WriteLine(Forest.ForestsCreated);
        }
    } 
}
