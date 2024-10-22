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

        public Pokemon(int HP, int _damage, string _name, Enum _type, Enum _effective)
        {
            maxHealth = HP;
            health = HP;
            name = _name;
            type = _type;
            effective = _effective;
            damage = _damage;
        }

        public bool attack(Pokemon target)
        {
            if (target.getType() == effective)
            {
                target.takeDamage(damage*2);
            }
            else
            {
                target.takeDamage(damage);
            }

            if (target.health > 0)
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
        public void heal(int healing)
        {
            health += healing;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }
    }
}
