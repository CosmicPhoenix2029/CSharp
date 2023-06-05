using System.Globalization;

namespace SupernaturalInheritanceProject;
public class Storm
{
    //properties
    public string Essence { get; private set; }
    public bool IsStrong { get; private set; }
    public string Caster { get; private set; }

    //Constructor
    public Storm(string caster, string essence, bool isStrong)
    {
        Caster = caster;
        Essence = essence;
        IsStrong = isStrong;
    }

    //methods
    public string Announce()
    {
        string strength = (IsStrong) ? "strong" : "weak";
        return $"{Caster} cast a {strength} {Essence} storm!";   
    }
}
