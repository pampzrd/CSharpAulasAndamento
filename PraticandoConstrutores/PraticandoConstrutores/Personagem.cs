using System;

namespace PraticandoConstrutores
{
	public class Personagem
	{
		//Construtor
		public Personagem(int idade, string nome) 
		{
			//props
			Nome = nome;
			Idade= idade;
		}
		
		private string _nome;//variável de encapsulamento
        public string Nome 
		{ 
			get
			{
				return Nome = _nome.ToUpper();
			}
			set
			{
                if (value == "") { 
                    throw new ArgumentException("O nome não pode ser vazio");
                }
				_nome = value;	
            }
			}

		private int _idade;//variável de encapsulamento
		public int Idade {
			get =>_idade; set
			{ 
				if(value<0)
				{
					throw new ArgumentException("O valor não pode ser negativo.");
				}
				_idade = value;
			} }

		public void Fala()
		{
			Console.WriteLine($" Nome: {Nome} | Idade: {Idade} ");
		}
	} 
}
