using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokemon
    {
		public Pokemon() 
		{
			this.Nome = "";
			this.Descricao = "";

        }

        public Pokemon(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;

        }
        private String nome;

		public  String Nome
		{
			get { return nome; }
			set {
				String texto = value.ToUpper();
				nome = texto; 
			}
		}


		private String descricao;

		public String Descricao
		{
			get { return this.descricao; }
			set {
				
				this.descricao = value.ToUpper(); 
			}
		}


		public void ExibirDadosPokemon()
		{
			Console.WriteLine("Nome do Pokémon: " + this.Nome);
			Console.WriteLine("Descrição do Pokémon: " + this.Descricao);

		}

        public void ExibirDadosPokemon(Boolean formatado)
        {
			if (formatado ==  true)
			{
                Console.WriteLine("Pokémon: " + this.Nome + ":  " + this.Descricao.ToLower());

            }
			else
			{
                Console.WriteLine("Nome do Pokémon: " + this.Nome);
                Console.WriteLine("Descrição do Pokémon: " + this.Descricao);

            }


        }


    }
}
