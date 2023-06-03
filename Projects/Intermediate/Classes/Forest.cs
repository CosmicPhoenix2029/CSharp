namespace Classes
{
    public class Forest
    {
        //declaring some fields --best practice to use lowercase 
        private string name;
        private string biome;
        private int age;

        //example of a static field (static is accessed via the class itself, not the instance of the class)
        private static int forestsCreated;
        private static string treeFacts;
        //here is an example of a constructor
        public Forest(string name, string biome)
        {
            //using the "this" keyword to show that the properties are set on the specific instance of the Forest class
            this.Name = name;
            this.Biome = biome;
            this.Age = 0;
            //keeps track of the number of instances of Forest
            ForestsCreated++;
        }

        /*overloading the constructor:
         - this constructor is used when only the first parameter was passed in when creating a new Forest object
         - Using an optional parameter (string name = "unknown") in this case is not possible as there is additional behavior in the overloaded constructor
         - Note here we are using the ": this" syntax to reference the original constructor
         - This will call the original constructor, passing in the provided name parameter, and a default value of unknown as the "biome" parameter*/
        public Forest(string name) : this(name, "unknown")
        {
            Console.WriteLine("WARNING! name not provided. Defaulting the value to unknown.");
        }

        //static constructor (used to set the values of static fields and properties)
        //This update the values each time a new object is created
        static Forest()
        {
            treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";   
            ForestsCreated = 0;
        }

        //static properties
        public static int ForestsCreated
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }

        public static string TreeFacts
        {
            get { return treeFacts; }
        }

        //basic property with no input validation --best practice is uppercase
        public string Name 
        {
            get { return name; }
            //this uses the value keyword to set the value of name to the provided value
            set { name = value; }
        }

        //property with input validation:
        public string Biome 
        {
            get { return biome; }
            //using the ternary operator to make it cleaner than an if or switch case
            set { biome = (value == "Tropical" || value == "Temperate" || value == "Boreal") ? value : "Unknown"; }
        }
        public int Trees
        {
            //shorthand syntax (automatic property)
            get; set;
        }
        //read only method (when accessing outside of this class)
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public int Grow()
        {
            Trees = Trees + 30;
            Age++;
            return Trees;
        }

        public int Burn()
        {
            Trees = Trees - 20;
            Age++;
            return Trees;
        }
        public static void PrintTreeFacts()
        {
            Console.WriteLine(treeFacts);
        }
    }
}