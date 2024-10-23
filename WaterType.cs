using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_starter
{
    internal class WaterType : Pokemon
    {

        public WaterType(int HP, int _damage, string _name, Enum _type, Enum _effective) : base(HP, _damage, _name, _type, _effective)
        {
        }

        public override bool attack(Pokemon target)
        {
            Random random = new Random();

            if (random.Next(1, 5) == 3)
            {
                setDamage(getDamage()+1);
            }

            if (string.Equals(getEffective().ToString(), target.getType().ToString()))
            {
                Console.WriteLine("Super effective! They took " + (getDamage() * 2) + " damage!");
                target.takeDamage(getDamage() * 2);
            }
            else
            {
                Console.WriteLine("They took " + getDamage() + " damage!");
                target.takeDamage(getDamage());
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
