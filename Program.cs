using System;

namespace human_NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            human playerKnight = new human("Paladin", 75, 25, 25, 350);
            human playerWizard = new human("Wizard", 20, 90, 15, 200);

            playerWizard.attack(playerKnight);
            Console.WriteLine($"{playerKnight.health}");

        }
    }
}
