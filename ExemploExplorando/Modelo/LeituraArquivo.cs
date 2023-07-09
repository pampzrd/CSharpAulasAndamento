using System;
using System.Linq;
using ExemploExplorando;
using Modelo.MyNamespace;




namespace Modelo.MyNamespace {




public class LeituraArquivo
{
	public (bool Sucesso, string[] Linhas,int QuantidadeLinhas) LerArquivo(string caminho)
	{
			try {
				string[] linhas = File.ReadAllLines(caminho);

				//A leitura deu sucesso? bool Quais as linhas do arquivo? string Quantas linhas existem no arquivo? int
				//Usar as tuplas para retornar varios tipos de retorno
				return (true, linhas, linhas.Count());
            }catch(Exception ex)
			{
				return (false, new string[0], 0); //vai retornar nada por causa do erro inesperado.
			}


    }
}

}