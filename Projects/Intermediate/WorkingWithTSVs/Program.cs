using System;
using System.Collections.Generic; //need it for lists
using System.IO; //need it to read and write to the TSV
using System.Linq;

namespace WorkingWithTSVs;
class Program
{
    static void Main()
    {
        //create a list of Language objects (each Language object (multi-value array) is a line in the TSV file)
        List<Language> languages = File.ReadAllLines("./languages.tsv") //this is basically a foreach line in tsv (uses the System.IO namespace)
                                                                        //using LINQ to convert each line into a seperate language object, then store all of the objects in a single List
          .Skip(1) //ignore the headers in the TSV file
          .Select(line => Language.FromTsv(line)) //lambda expression (this passes the currently selected line to the Languages class, by calling its FromTSV method)
          .ToList(); //convert the output to a list item

        //print the whole List of Language objects (formatted by the prettify method)
        //foreach (Language language in languages) { Console.WriteLine(language.Prettify()); }

        //find a specific language in the list:
        var language = languages.Where(l => l.Name == "C#");
        //as language is of type (IEnumerable), I need to iterate through each Language inside it
        //foreach (Language l in language) { Console.WriteLine(l.Prettify()); } --method replaces this
        PrettyPrintAll(language);

        //find all languages that Microsoft created:
        var microsoftLanguages = languages.Where(l => l.ChiefDeveloper == "Microsoft");
        //foreach (Language l in microsoftLanguages) {  Console.WriteLine(l.Prettify()); } --method replaces this
        PrettyPrintAll(microsoftLanguages);
        //find the number of that descend from Lisp
        var lispLanguages = languages
            .Where(l => l.Name.Contains("Script"))
            .Select(l => l.Name)
            .Count();
        Console.WriteLine($"There are {lispLanguages} languages which descend from Lisp");

        //find the languages created between 1995 and 2005
        var languagesRange = languages
            .Where(l => (l.Year >= 1995) && (l.Year <= 2005))
            .Select(l => $"{l.Name} was invented in {l.Year}");
        //foreach (string row in languagesRange) { Console.WriteLine(row); } --method replaces this
        PrintAll(languagesRange);

        //method to print multiple formatted language objects
        void PrettyPrintAll(IEnumerable<Language> output)
        {
            foreach (Language l in output) { Console.WriteLine(l.Prettify()); }
            Console.WriteLine();
        }

        //method to print all query results
        void PrintAll(IEnumerable<Object> obj)
        {
            foreach (Object o in obj) { Console.WriteLine(o); }
            Console.WriteLine();
        }
    }   
}
