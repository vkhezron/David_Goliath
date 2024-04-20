using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Goliath
{
    internal abstract class Warrior : Person
    {
        public int Hieght { get; set; }
        public double Weight { get; set; }
        List<string> Armour { get; set; }
        List<string> Weapons { get; set; }

        public Warrior(string name, string language, string nation ,int height, double weight, List<string> armour, List<string> weapon ) : base(name, language, nation)
        {
            this.Hieght=height;
            this.Weight = weight;
            this.Armour = new List<string>();
            this.Weapons = new List<string>();
        }

        public void AddArmour(string armourPiece)
        {
            Armour.Add(armourPiece);
        }

        public void AddWeapon(string weaponItem)
        {
            Weapons.Add(weaponItem);
        }

        public override void Speak(string phrase)
        {
            Console.WriteLine($"{GetName()} from the nation of {GetNation()} say: \"{phrase}\"");
        }

        public abstract void Attack(string weaponItem);

    }

    internal class Goliath : Warrior
    {
        int GoliathHeight { get; set; }
        double GoliathWeight { get; set; }

        public Goliath(string name, string nation, string language, int height, double weight, List<string> armour, List<string> weapon) : base(name, language, nation, height, weight, armour, weapon)
        {
            GoliathHeight = height;
            GoliathWeight = weight;
        }

        public override void Attack(string weaponItem)
        {
            Console.WriteLine($"{GetName()} attacks with {weaponItem}");
        }
    }
    
    internal class David : Warrior, IG_d
    {
        public David(string name, string nation, string language, int height, double weight, List<string> armour, List<string> weapon) : base(name, language, nation, height, weight, armour, weapon)
        {

        }
        public void Intervine()
        {
            Console.WriteLine($"{GetName()} from {GetNation()} calls for G-ds help");
        }
        public override void Attack(string weaponItem)
        {
            Console.WriteLine($"{GetName()} attacks with {weaponItem}");
        }
    }
}
