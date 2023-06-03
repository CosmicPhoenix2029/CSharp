namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //using another class (creating an instance of a class)
            Forest forest = new Forest();
            //setting the instances fields
            forest.Name = "Amazon";
            forest.Biome = "tropical rainforest";
            forest.Trees = 10400653;
            forest.Age = 4400;
        }
    } 
}
