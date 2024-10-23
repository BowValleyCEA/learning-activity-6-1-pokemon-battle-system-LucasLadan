using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace game1401_la_starter
{
    internal class FireType : Pokemon
    {

        private int maxHealth;
        private int health;
        private int damage;
        private string name;
        private Enum type;
        private Enum effective;
        private bool burned;
        public FireType(int HP, int _damage, string _name, Enum _type, Enum _effective) : base(HP, _damage, _name, _type, _effective)
        {
        }

        public bool attack(Pokemon target)
        {
            Random random = new Random();

            if (random.Next(1,5) == 3)
            {
                target.setBurn(true);
            }

            if (string.Equals(effective.ToString(), target.getType().ToString()))
            {
                Console.WriteLine("Super effective! They took " + (damage * 2) + " damage!");
                target.takeDamage(damage * 2);
            }
            else
            {
                Console.WriteLine("They took " + damage + " damage!");
                target.takeDamage(damage);
            }

            if (target.getHealth() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
