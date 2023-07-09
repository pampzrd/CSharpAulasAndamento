using System;


namespace Modelo.MyNamespace;

	public class Pessoa
	{
	//Criando um construtor:
		public Pessoa() { } //Construtor vazio para caso não haja valor inicial
		public Pessoa(string nome, string sobrenome,int idade) 
		{
		Nome = nome;
		Sobrenome = sobrenome;
		Idade = idade;
		} //Que exige os valores

	public void Deconstruct(out string nome,out string sobrenome)
	{
		nome = Nome;
		sobrenome= Sobrenome;
	}

    //Fazendo um campo(variável usada dentro do props)
    private int _idade;

		public int Idade {
		get => _idade; //body expression
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("A idade não pode ser menor que zero.");
			}
			_idade = value;
		}
	}

	//Usando "campo" para encapsular o nome.
		private string _nome;
		public string Nome 
		{ 
			get
			{ 
				return _nome; 
			//Coloca todos em maiúscula
			}
			set
			{ 
				if(value=="")
			{
				throw new ArgumentException("O nome não pode ser vazio");
				//gera esse erro.
			}

			_nome = value;

			}
	}


	public string Sobrenome { get; set; }

	public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //Vai juntar Nome e o Sobrenome

	public void Apresentar()
		{
			Console.WriteLine($"He-he-heeeee!! Sou o {NomeCompleto}! Tenho {Idade} anos! ");
		}
	} 

