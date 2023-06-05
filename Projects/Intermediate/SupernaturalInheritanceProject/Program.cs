using SupernaturalInheritanceProject;

namespace SupernaturalInheritance 
{
    class Program 
    { 
        static void Main(string[] args)
        {
            //creates a new pupil, create a new storm and writes it to console:
            Pupil pupil = new Pupil("Mezil-Kee");
            Storm windStorm = pupil.CastWindStorm();
            Console.WriteLine(windStorm.Announce());

            //creates a new Mage, creates a new rain storm and writes it to console:
            Mage mage = new Mage("Gul'dan");
            Storm rainStorm = mage.CastRainStorm();
            Console.WriteLine(rainStorm.Announce());

            //creates a new Archmage and creates 2 storms and casts them:
            ArchMage archMage = new ArchMage("Nielas Aran");
            Storm powerfulRainStorm = archMage.CastRainStorm();
            Console.WriteLine(powerfulRainStorm.Announce());
            Storm powerfulLightningStorm = archMage.CastLightningStorm();
            Console.WriteLine(powerfulLightningStorm.Announce());
        }
    }
}