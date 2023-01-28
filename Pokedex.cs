using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex() 
        {
            this.InicializaLista();
        }
		private List<Pokemon> pokemons;

		public List<Pokemon> Pokemons
		{
			get { return pokemons; }
		}

		private void InicializaLista()
		{
			this.pokemons = new List<Pokemon>();
			Pokemon p = new Pokemon("Bulbasauro", "pokemon tipo planta");
			this.pokemons.Add(p);
            /* 1*/
            p = new Pokemon("Pikachu", "pokemon tipo raio");
			this.pokemons.Add(p);
            /* 2*/
            p = new Pokemon("Mew", "lendario psiquico");
            this.pokemons.Add(p);
            /* 3*/
            p = new Pokemon("Mewtow", "lendario psiquico");
            this.pokemons.Add(p);
            /* 4*/
            p = new Pokemon("Giratina", "lendario fantasma");
            this.pokemons.Add(p);
            /* 5*/
            p = new Pokemon("Flygon", "pokemon dragão");
            this.pokemons.Add(p);
            /* 6*/
            p = new Pokemon("Metagron", "pokemon tipo metal");
            this.pokemons.Add(p);
            /* 7*/
            p = new Pokemon("Muk", "pokemon tipo metal");
            this.pokemons.Add(p);
            /* 8*/
            p = new Pokemon("Metagross", "pokemon tipo toxico");
            this.pokemons.Add(p);
            /* 9*/
            p = new Pokemon("Charizard", "pokemon dragao de fogo");
            this.pokemons.Add(p);
            /* 10*/
            p = new Pokemon("Squirtle", "pokemon tipo Agua");
            this.pokemons.Add(p);



        }


    }
}
