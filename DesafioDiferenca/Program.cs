int n = int.Parse(Console.ReadLine());
int limite = Convert.ToInt32(Math.Pow(10, 5));
int[] divisor = new int[5] { 10, 100, 1000, 10000, 100000 };
int[] unidades = new int[5] { 0, 0, 0, 0, 0 };
int[] valores = new int[5] { 0, 0, 0, 0, 0 };
int p = 1, s = 0;

while (n > 0 && n < limite)
{
    int x = 0;
    int i = 0;
    while (i <= 5 && x <= 4)
    {
        unidades[i] = n % divisor[x];
        i++;
        x++;
    }

    valores[0] = unidades[0];
    valores[1] = (unidades[1] - unidades[0]) / divisor[0];
    valores[2] = (unidades[2] - unidades[1]) / divisor[1];
    valores[3] = (unidades[3] - unidades[2]) / divisor[2];
    valores[4] = (unidades[4] - unidades[3]) / divisor[3];

    s += valores[3] + valores[2] + valores[1] + valores[0];

    for (int j = 0; j < 5; j++)
    {
        if (valores[j] == 0)
        {
            valores[j] = 1;
        }
    }

    p *= valores[3] * valores[2] * valores[1] * valores[0];

    Console.WriteLine(p - s);

    break;
}
Console.ReadLine();