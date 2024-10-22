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
        private Enum weakness;

        public Pokemon(int HP, int _damage, string _name, Enum _type, Enum _weakness)
        {
            maxHealth = HP;
            health = HP;
            name = _name;
            type = _type;
            weakness = _weakness;
            damage = _damage;
        }

        public bool takeDamage(Enum attackerType, int damageTaken)
        {

            if (string.Equals(weakness.ToString(), attackerType.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                health -= damageTaken * 2;
            }
            else
            {
                health -= damageTaken;
            }

            if (health > 0)
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
