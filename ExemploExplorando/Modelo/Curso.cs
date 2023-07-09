using System;
using System.Collections.Generic;
using Modelo.MyNamespace;
using ExemploExplorando;

namespace Modelo.MyNamespace
{
	public class Curso
	{

		public string Nome { get; set; }

		public List<Pessoa> Alunos { get; set; }


		public void AdicionarAluno(Pessoa aluno)
		{
			Alunos.Add(aluno);
		}

		public int ObterQuantidadeDeAlunosMatriculados()
		{
			int quantidade = Alunos.Count;
			return quantidade;
		}

		public bool RemoverAluno(Pessoa aluno)
		{
			return Alunos.Remove(aluno);
		}

		public void ListarAlunos()
		{
			Console.WriteLine($"\n\nAlunos do curso de {Nome}:");
			Console.WriteLine("");

			for(int count=0;count <Alunos.Count;count++) 
			{
				int exibicao = count + 1;

                string texto = $"N°  {exibicao} - {Alunos[count].NomeCompleto}";//

                Console.WriteLine(texto);
			}
			//foreach (Pessoa aluno in Alunos)
			//{
			//	Console.WriteLine(aluno.NomeCompleto);
			//}
		}

	}
}
