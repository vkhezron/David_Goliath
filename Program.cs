using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Goliath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> goliathArmour = new List<string>() { "Helmet", "Shield" };
            List<string> goliathWeapons = new List<string>() { "Spear", "Sword" };

            List<string> davidsArmour = new List<string>() { "Talith", "Shechina" };
            List<string> davidsWeapon = new List<string>() { "Sling", "Stone" };

            Goliath goliath = new Goliath("Goliath", "Plishtim", "cretian", 198, 85.5, goliathArmour, goliathWeapons );
            David david = new David("David", "Bney Israel", "hebrew", 167, 65.5, davidsArmour, davidsWeapon);

            goliath.Speak("Hellas Dagon!");
            Console.ReadKey();
            goliath.Attack(goliathWeapons[0] + "\n");
            Console.ReadKey();
            david.Intervine();
            Console.ReadKey();
            david.Speak("Shma Israel");
            Console.ReadKey();
            david.Attack(davidsWeapon[0] + " and " + davidsWeapon[1] + "\n");
            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
