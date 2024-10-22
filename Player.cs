using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_starter
{
    internal class Player
    {
        private Pokemon pokemon;
        private int itemCount;

        public Player (Pokemon _pokemon)
        {
            pokemon = _pokemon;
            itemCount = 3;
        }

        public void healPokemon()
        {
            if (itemCount > 0)
            {
                itemCount -= 1;
                pokemon.heal(20);
            }
        }

        public bool takeDamage(Pokemon _pokemon)
        {
            return pokemon.takeDamage(_pokemon.getType(), _pokemon.getDamage());
        }

        public int getItemCount()
        {
            return itemCount;
        }

        public Pokemon GetPokemon ()
        {
            return pokemon;
        }
    }
}
