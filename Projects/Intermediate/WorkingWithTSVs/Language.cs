namespace WorkingWithTSVs;
public class Language
{
    //method to read a line from the TSV and convert the values to a multi-value array (store in and return a language object)
    public static Language FromTsv(string tsvLine)
    {
        //bringing in data from a TSV
        //this creates a new multi-value array, serperated by tabs (and stores each line in a Language object)
        //this also contructs a language object from the passed in data
        string[] values = tsvLine.Split('\t');
        Language lang = new Language(
          Convert.ToInt32(values[0]), //first value in array is an int
          Convert.ToString(values[1]), //second value is a string
          Convert.ToString(values[2]), //third value is a string
          Convert.ToString(values[3])); //fourth value is a string
        return lang;
    }

    //properties for the language object
    public int Year
    { get; set; }

    public string Name
    { get; set; }

    public string ChiefDeveloper
    { get; set; }

    public string Predecessors
    { get; set; }

    //constructor
    public Language(int year, string name, string chiefDeveloper, string predecessors)
    {
        Year = year;
        Name = name;
        ChiefDeveloper = chiefDeveloper;
        Predecessors = predecessors;
    }

    //method to return a formatted row 
    public string Prettify()
    {
        return $"{Year}, {Name}, {ChiefDeveloper}, {Predecessors}";
    }
}
