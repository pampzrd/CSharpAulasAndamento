
//Desafio

//Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.
//Entrada

//A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.
//Saída

//Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

//Exemplo de Entrada: 	

//4
//56234523485723854755454545478690 78690
//5434554 543
//1243 1243
//54 64545454545454545454545454545454554

//Exemplo de Saída:
//encaixa
//nao encaixa
//encaixa
//nao encaixa


int qt = int.Parse(Console.ReadLine());//qtos testes?
// TODO: Crie as outras condições necessárias para a resolução do desafio:
int MAX = 1000;
if (qt>MAX)
{
    qt = int.Parse(Console.ReadLine());
}

    string[] v = {"",""};
v[0]= Console.ReadLine();

if (v[0] > MAX)
{
    v[0] = (Console.ReadLine());
}
v[1] = Console.ReadLine();

for (int i=0; i<=qt;i++)
{

    string a = v[0];
    string b = v[1];

    if (int.Parse(b)>int.Parse(a))
        Console.WriteLine("nao encaixa");

    else if (int.Parse(b)<int.Parse(a))
        Console.WriteLine("encaixa");
    else
        Console.WriteLine("nao encaixa");

}
