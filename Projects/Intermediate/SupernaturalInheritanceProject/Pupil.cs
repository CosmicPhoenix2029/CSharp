namespace SupernaturalInheritanceProject;
public class Pupil
{
    //properties
    public string Title { get; private set; }

    //constructor
    public Pupil(string title)
    { 
        Title = title;
    }

    //methods
    public Storm CastWindStorm()
    {
        Storm windStorm = new Storm(Title, "wind", false);
        return windStorm;
    }
}
