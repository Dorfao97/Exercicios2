int numero = 0, a = 0, b = 1, contador = 0;

Console.WriteLine("Informe um numero inteiro, esse numero é a posição ate onde a sequencia fibonacci sera exibida");
numero = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < numero; i++)
{
    Console.WriteLine(a);
    contador = a + b;
    a = b;
    b = contador;
    
}