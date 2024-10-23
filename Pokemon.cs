using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace game1401_la_starter
{
    internal class Pokemon
    {
        private int maxHealth;
        private int health;
        private int damage;
        private string name;
        private Enum type;
        private Enum effective;
        private bool burned;

        public Pokemon(int HP, int _damage, string _name, Enum _type, Enum _effective)
        {
            maxHealth = HP;
            health = HP;
            name = _name;
            type = _type;
            effective = _effective;
            damage = _damage;
            burned = false;
        }

        public bool attack(Pokemon target)
        {
            if (string.Equals(effective.ToString(),target.getType().ToString()))
            {
                Console.WriteLine("Super effective! They took " + (damage * 2) + " damage!");
                target.takeDamage(damage*2);
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

        public Enum getType()
        {
            return type;
        }

        public void printHealth()
        {
            Console.WriteLine(name+"'s health:"+health+"/"+maxHealth);
        }

        public int getDamage()
        {
            return damage;
        }

        public void takeDamage(int _damage)
        {
            health -= _damage;
        }

        public int getHealth()
        {
            return health;
        }

        public bool isBurned()
        {
            return burned;
        }
        public void heal(int healing)
        {
            health += healing;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }

        public void setBurn (bool burning)
        {
            burned = burning;
        }

    }
}
