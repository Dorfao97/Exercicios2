int numero = 0, contador = 1;

Console.WriteLine("informe um numero inteiro para calcular seu fatorial!");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    contador = contador * i;
    Console.Write(i);

    if (i < numero)
    {
        Console.Write(" X ");
    }
}

Console.WriteLine($" = {contador}");
