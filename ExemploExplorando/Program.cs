using Modelo.MyNamespace;
using ExemploExplorando;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using ExemploExplorando.Modelo;









// DateTime dataAtual=DateTime.Now;
// //SERIALIZAÇÃO

// //Criar uma coleção de vendas
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritório", 26.50M,dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 126.00M,dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas,Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);



////IF TERNÁRIO
//int numero = 20;
//bool ehpar = false;

//ehpar = numero % 2 == 0;

//Console.WriteLine($"O número {numero} é " + (ehpar ? "par" : "ímpar"));

////IF COMUM
////if(numero %2 == 0)
////{
////    Console.WriteLine($"O número {numero} é par");
////}
////else
////{
////    Console.WriteLine($"O número {numero} é ímpar");
////        }

//Console.ReadLine();

//p.budega();

//p2.Apresentar();

//p1.NomeCompleto = "Nome"; //Dá erro pois não tem o SET para poder atribuir valor

//p1.Apresentar();




//Pessoa p2 = new Pessoa("Pica-Pau","Biruta",50);
//Pessoa p1 = new Pessoa(nome:"Chapolin",sobrenome:"Colorado",idade:27);
//Pessoa p3 = new Pessoa("Elvis", "Presley",17);

//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Inglês";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.AdicionarAluno(p3);

//cursoDeIngles.ListarAlunos();
//cursoDeIngles.RemoverAluno(p2);
//cursoDeIngles.ListarAlunos();

//string numero1 = "10";
//string numero2 = "20";
//string resultado = numero1+ numero2;

//Console.WriteLine(resultado);

//decimal valorMonetario = 82.40M;
//Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

//double porcentagem = .3421;
//Console.WriteLine(porcentagem.ToString("P"));



// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None,out DateTime data);//tentar converter em uma data válida. Se for inválida a entrada, ele gera data 00000

// if(sucesso)  //se é verdadeiro.
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }





// //Para fazer a leitura de um arquivo
// try{
// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
// string[] pica = File.ReadAllLines("Arquivos/picapau.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// foreach (string el in pica)
// {
//     Console.WriteLine(el);
// }
// }
// catch(FileNotFoundException ex)//Exceção específica
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)//Exceção específica
// {
//     Console.WriteLine("Ocorreu um erro de leitura do arquivo. Caminho da pasta não encontrado. \n"+ ex.Message);
// }
// catch(Exception ex)//Exceção genérica
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui BB! :3");
// }



//Usando o Throw

//new ExemploExcecao().Metodo1();

//Console.WindowWidth = 100; // De 0 a 100




////FILA NA PRÁTICA

//Queue<int> fila  = new Queue<int>();

//fila.Enqueue(1);
//fila.Enqueue(2);
//fila.Enqueue(3);
//fila.Enqueue(4);

//Console.WriteLine("Enfileirando-  \n");
//Console.Write("=      ");
//foreach (int i in fila)
//{
//    Console.Write(" "+i + " ");
//}

//Console.WriteLine($"\n\nTotal: {fila.Count} valores\n");

////Tira dois elementos da fila (os adicionados primeiro)
//Console.WriteLine($"\n\nRemovendo os elementos  {fila.Dequeue()}   e   {fila.Dequeue()}  (Os primeiros que foram adicionados)\n\n\n");



//Console.WriteLine("Desfileirando-  \n");
//Console.Write("=      ");
//// Vai p final da fila fila.Enqueue(25);
//foreach (int i in fila)
//{
//    Console.Write(" " + i + " ");
//}

//Console.WriteLine($"\n\nTotal: {fila.Count} valores\n");

//Console.WriteLine("\n");






////PILHA NA PRÁTICA

//Stack<int> pilha= new Stack<int>();

//pilha.Push(6);
//pilha.Push(10);
//pilha.Push(2);



//Console.WriteLine("\n\nEmpilhando\n");
//foreach (int i in pilha)
//{
//    Console.WriteLine(i);
//}


//pilha.Pop();
//pilha.Push(122);

//Console.WriteLine("\n\nDesempilhando\n");
//foreach (int i in pilha)
//{
//    Console.WriteLine(i);
//}









////DICTIONARY
//Dictionary<string,string> estados = new Dictionary<string,string>();

//estados.Add("SP", "São Paulo");
//estados.Add("BA", "Bahia");
//estados.Add("MG", "Minas Gerais");

//foreach(KeyValuePair<string,string> item in estados) //Ou ao invés de KeyValuePair use a palavra var
//{
//    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
//}

////estados.Remove("BA");
//estados["SP"] = "São Paulo valor alterado.";
//Console.WriteLine("--------------------");
//foreach (KeyValuePair<string, string> item in estados) //Ou ao invés de KeyValuePair use a palavra var
//{
//    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
//}

//string chave = "BA";
//Console.WriteLine($"Verificando se já existe o elemento no dictionary : {chave}");

//if(estados.ContainsKey(chave))
//{
//    Console.WriteLine($"Valor existente: {chave}");
//}
//else
//{
//    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
//}

////Acessando um valor
//Console.WriteLine(estados["MG"]);


////TUPLAS NA PRÁTICA

////Tipos dos dados que tu precisa representar entre parênteses e Nome_variável (dados)

//(int, string, string,decimal) tupla = (1, "Pica-pau", "Sandoval",1.80M);
////Outra forma de representar uma tupla
//ValueTuple<int,string,string,decimal> outroExemploTupla = (1, "Pica-pau", "Sandoval", 1.80M);
////Outra forma de representar uma tupla
//var TuplaExemplo2Create = Tuple.Create(1, "Pica-pau", "Sandoval", 1.80M);

//Console.WriteLine($"ID: {tupla.Item1}");
//Console.WriteLine($"Nome: {tupla.Item2}");
//Console.WriteLine($"Sobrenome: {tupla.Item3}");
//Console.WriteLine($"Altura: {tupla.Item4}");


////TUPLAS EM MÉTODOS

//LeituraArquivo arquivo = new LeituraArquivo();

//var (sucesso,linhasArquivo, _)= arquivo.LerArquivo("Arquivos/picapau.txt");

//if (sucesso)
//{
//    //Console.WriteLine("Quantidade de Linhas do Arquivo" + quantidadeLinhas);

//    foreach(string linha in linhasArquivo)
//    {
//        Console.WriteLine(linha);
//    }
//}else
//{
//    Console.WriteLine("Não foi possível ler o arquivo");
//}

////USANDO O DECONSTRUCT
//Pessoa p1= new Pessoa("Pam","Rod",29); //construtor
//(string nome, string sobrenome) = p1; //deconstrutor

//Console.WriteLine($"{nome} {sobrenome}");





//DESERIALIZANDO UM OBJETO///////////////////////////////////////////////////////////////////////

//string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

//List<Venda1> listaVenda = JsonConvert.DeserializeObject<List<Venda1>>(conteudoArquivo);

//foreach (Venda1 venda in listaVenda)
//{
//    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
//}


//Console.ReadLine();
















