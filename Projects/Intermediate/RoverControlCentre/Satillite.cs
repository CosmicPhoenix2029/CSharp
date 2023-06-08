namespace RoverControlCentre;
public class Satillite : IDirectable
{
    //properties
    public string Alias
    { get; private set; }

    public int YearLaunched
    { get; private set; }

    //constuctor
    public Satillite(string alias, int yearLaunched)
    {
        Alias = alias;
        YearLaunched = yearLaunched;
    }

    public string GetInfo()
    {
        return $"Alias: {Alias}, YearLaunched: {YearLaunched}";
    }

    public virtual string Explore()
    {
        return "Satellite is exploring the far reaches of space!";
    }

    public virtual string Collect()
    {
        return "Satellite is collecting photographic evidence!";
    }
}
