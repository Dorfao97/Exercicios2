int numero = 0;

Console.WriteLine("Informe um numero inteiro!");
numero = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i <= numero; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine();
for (int j = numero; j <= numero; j--)
{
    if (j >= 0)
    {
        if (j % 2 == 0)
        {
            Console.WriteLine(j);
        }
    }
}

