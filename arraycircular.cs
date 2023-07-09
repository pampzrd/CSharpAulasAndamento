using System;

int[] circular = new int[4] { 1, 2, 3, 4 };
int novoNum = 0;
int MAX_LENGTH = circular.Length;
int cont = 0;


while (int novoNum != 0){ //Se digitar 0 o programa encerra.

    Console.WriteLine("=== Bem-Vindo! ===");//WriteLine é um print
    Console.WriteLine("Esta é sua Lista:");
    foreach (int valor in circular)
    {
        //Imprimir a lista toda.
        Console.Write($" {valor} ");
    }

    Console.WriteLine("\nInsira o novo valor:");
    //Ler a nova entrada
    novoNum = Console.ReadLine();//ReadLine é um scan

    //Adicionar a nova entrada ao índice atual
    circular[cont] = novoNum;
    //Pular para a próxima posição do array
    cont++;

    //Verifica se a posição excede o máximo da array e volta para a posição 0.
    if (circular[cont] > MAX_LENGTH)
    {
        cont = 0;
    }

    Console.WriteLine("Novo valor adicionado!");

}

//Encerramento

Console.WriteLine("Esta é sua array final :");
foreach (int valor in circular)
{
    //Imprimir a lista toda.
    Console.Write($" {valor} ");
}

Console.ReadLine();