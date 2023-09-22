using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {


            IArmor armor = new Leather("Elven Leather Armor", 12);
            IWeapon sword = new Sword("Long sword", 5);
            // new armor and new weapon

            IArmor newArmor = new Leather("Space Armor", 25);
            IWeapon newWeapon = new Sword("Light Saber", 100);

            
            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            // newCombatant
            ICombatant badGuy = new Fighter("Scary Monster", armor, sword);

            ICombatant jedi = new Fighter("Luke Skywalker", newArmor, newWeapon);

            jedi.Attack(badGuy);


        }

    }

}
