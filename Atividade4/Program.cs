bool Primo (int numero)
{
    int contador = 0;
    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            contador++;
        }
    }
    return contador == 2;
}

Console.WriteLine("digite ate que numero quer ver os numero primos");
int limite = int.Parse(Console.ReadLine());

Console.WriteLine($"Numeros primos ate {limite}");

for (int i = 1; i <= limite; i++)
{
    if (Primo(i))
    {
        Console.Write(i + " ");
    }

}



