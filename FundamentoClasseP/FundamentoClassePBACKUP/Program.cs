//Feito no VS
using FundamentoClasseP.Model;


//Calculadora calc = new Calculadora();












////Fazendo um menu
//string opcao;
//bool exibirMenu = true;

//while(exibirMenu)
//{
//    //Console.Clear(); //Limpa o menu imediatamente depois do loop e por isso o print da opção não é visualizada
//    Console.WriteLine("Digite a sua opção:");
//    Console.WriteLine("1 - Cadastrar cliente");
//    Console.WriteLine("2 - Buscar Cliente");
//    Console.WriteLine("3 - Apagar Cliente");
//    Console.WriteLine("4 - Encerrar");

//    opcao = Console.ReadLine();

//    switch(opcao)
//    {
//        case "1":
//            Console.WriteLine("Cadastro de cliente");
//            break;
//        case "2":
//            Console.WriteLine("Busca de cliente");
//            break;
//        case "3":
//            Console.WriteLine("Apagar cliente");
//            break;
//        case "4":
//            Console.WriteLine("Encerrar");
//            exibirMenu= false; //Para de exibir o loop e exibe o código que estiver fora do loop while.
//            //Environment.Exit(0);//Encerra o programa
//            break;

//            default: Console.WriteLine("Opção Inválida.");
//            break;

//    }
//}


////DO WHILE

//int soma=0,numero = 0;

//do
//{
//    Console.WriteLine("Digite um número (0 para parar)");
//    numero= Convert.ToInt32(Console.ReadLine());//Converter o string do readline
//    soma += numero;
//}while(numero!=0);

//Console.WriteLine($"A soma total é {soma}");
//Console.ReadLine();


//WHILE E WHILE COM BREAK
//int numero = 5;
//int contador = 0;

//    while(contador<=10)
//    {
//    Console.WriteLine($"{numero} x {contador} = {numero*contador}");
//    contador++;

//    if(contador==5)
//    { break; }

//    }
//    Console.ReadLine();

//int numero = 5;

//for(int contador = 0;contador<=10;contador++)
//{
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}
//Console.ReadLine();

////Raíz Quadrada
//calc.RaizQuadrada(9);
//Console.ReadLine();

////Incremento e Decremento

//int numero = 10,numeroDecremento = 10;
//Console.WriteLine(numero);
//Console.WriteLine("Incrementando o 10");
////numero = numero+1;
//numero++;
//Console.WriteLine(numero);

//Console.WriteLine("Decrementando o 10");
//numeroDecremento--;
//Console.WriteLine(numeroDecremento);
//Console.ReadLine();

//calc.Dividir(5, 2);
//calc.Potencia(3, 3);
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);


//// Operador NOT !

//bool choveu = false;
//bool estaTarde = false;

//if(!choveu && !estaTarde)
//{
//    Console.WriteLine("Vou pedalar");
//}
//else
//{
//    Console.WriteLine("Vou pedalar um outro dia");
//}

//Console.ReadLine();

////Operador AND &&

//bool possuiPresencaMinima = true;
//double media = 7.5;

//if(possuiPresencaMinima && media>=7)
//{
//    Console.WriteLine("Aprovado");
//}
//else
//{
//    Console.WriteLine("Reprovado");
//}


//Console.ReadLine(); 


////Operador OR Pipe ||

//bool ehMaiorDeIdade = true;
//bool possuiAutorizacaoDoResponsavel = false;

//if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
//{
//    Console.WriteLine("Entrada Liberada");
//}
//else
//{
//    Console.WriteLine("Entrada não liberada.");
//}

//Testar se é vogal ou consoante

//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();

//switch(letra)
//{
//    case "a": 
//    case "e": 
//    case "i":
//    case "o":
//    case "u": 
//        Console.WriteLine("É uma vogal"); 
//        break;

//        default: 
//        Console.WriteLine("Não é uma vogal"); 
//        break;
//}

//Console.ReadLine();

//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();

//if (letra == "a"|| letra == "e" || letra == "i" || letra == "o" || letra == "u") // Sinal"pipe"||
//{
//    Console.WriteLine("É uma Vogal");
//}
//else
//{
//    Console.WriteLine("Não é uma vogal.");
//}

//Console.ReadLine();



//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();

//if(letra=="a")
//{
//    Console.WriteLine("É uma Vogal");
//}
//else if (letra=="e")
//{
//    Console.WriteLine("É uma Vogal");
//}
//else if (letra=="i")
//{
//    Console.WriteLine("É uma Vogal");
//}
//else if(letra=="o")
//{
//    Console.WriteLine("É uma Vogal");
//}
//else if(letra=="u")
//{
//    Console.WriteLine("É uma Vogal");
//}
//else
//{
//    Console.WriteLine("Não é uma vogal.");
//}

//Console.ReadLine();

//int quantidadeEstoque =10;//Aula de Operadores Condicionais
//int quantidadeCompra = 4;
//bool possivelVenda = quantidadeCompra>0 && quantidadeEstoque >= quantidadeCompra;

//Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
//Console.WriteLine($"Quantidade comprada: {quantidadeCompra}");
//Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


//if (quantidadeCompra == 0) { Console.WriteLine("Venda inválida."); }
//else if (possivelVenda)//variável que verifica se é true ou false a condição.
//{
//    Console.WriteLine("Venda realizada.");
//}
//else
//{
//    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
//}


//Console.ReadLine();

//string a = "15";
//int b = Convert.ToInt32(a);

//double a = 4 / 2 + 2;

//int a = 5;
//double b = a;
//long c = long.MaxValue;
//int inteiro = 5;
//string a = inteiro.ToString();

//int a = Convert.ToInt32("5");
//Casting conversão de tipo
//int a = int.Parse("6");

//int a = 10;
//int b = 20;
//int c = a;
//b += c;
//b -= c;
//b /= c;
//b *= c;
//Console.WriteLine(b);



//DateTime dataAtual = DateTime.Now.AddDays(5);

//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
//Console.ReadLine();


//string apresentacao = "Olá, seja bem-vindo! ";
//int quantidade = 1;
//double altura = 1.80;

//Console.WriteLine(apresentacao+altura.ToString("0.00")); //Essa conversão mostrará o valor natural mas nesse formato.
//Console.ReadLine();


/*
Pessoa p = new Pessoa();
p.Nome = "Bob Esponja";//Console.ReadLine();
p.Idade = 26;
p.Apresentar();
Console.ReadLine();
*/