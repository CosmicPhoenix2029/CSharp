//required for the use of lists
using System.Collections.Generic;
//required to use Linq
using System.Linq;
//for single operator queries, use method based syntax, for everything else, use query based syntax
namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //list declaration
            List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            //long way of doing a LINQ query (query syntax)
            var shortHeroes = from h in heroes
                              where h.Length < 8
                              select h;
            //printing
            foreach (var hero in shortHeroes) { Console.WriteLine(hero); }

            //LINQ query using lambda expressions (method syntax)
            var longHeroes = heroes.Where(n => n.Length > 8);
            //printing
            foreach (var longHero in longHeroes) { Console.WriteLine(longHero); }

            //performing some formatting on the output:
            var heroTitles = from hero in heroes
                             select $"HERO: {hero.ToUpper()}";
            //printing
            foreach(var heroTitle in heroTitles) { Console.WriteLine(heroTitle); }
        }
    }
}
