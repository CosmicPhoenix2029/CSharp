namespace SupernaturalInheritanceProject;
public class ArchMage : Mage
{
    //no need for the title as its inherited from Mage, which inherits it from pupil (example of an inheritance hierarchy)
    
    //constuctor
    public ArchMage(string Title) : base(Title) 
    {
        
    }

    //methods (this one overrides the rainStorm method in Mage to make it strong)
    public override Storm CastRainStorm()
    {
        Storm rainStorm = new Storm(Title, "rain", true);
        return rainStorm;
    }

    public Storm CastLightningStorm()
    {
        Storm lightningStorm = new Storm(Title, "lightning", true);
        return lightningStorm;
    }
}
