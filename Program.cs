Console.Clear();

int numero;

while (true)
{
    Console.Write("Digite um número: ");
    bool conversaoValida = int.TryParse(Console.ReadLine(), out numero);

    if (!conversaoValida || numero < 0)
    {
        Console.Clear();
        Console.WriteLine("Digite um número inteiro válido!");
    }
    else
    {
        break;
    }
}

Console.Clear();

if (numero % 2 == 0)
{
    Console.WriteLine($"{numero} é par");
}
else
{
    Console.WriteLine($"{numero} é ímpar");
}