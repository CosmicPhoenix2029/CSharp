namespace SupernaturalInheritanceProject;
public class Mage : Pupil
{
    //no need for the title property here as its inherited from the pupil class

    //constructor (invokes the Pupil constructor)
    public Mage(string Title) : base(Title)
    { 
        
    }

    //methods
    public virtual Storm CastRainStorm()
    {
        Storm rainStorm = new Storm(Title, "rain", false);
        return rainStorm;
    }
}
