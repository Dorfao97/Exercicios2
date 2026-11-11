int numero = 0, contador = 11;

Console.WriteLine("Informe um numero inteiro para exibir a tabuada do 1 ao 10!");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i < contador; i++)
{
    Console.WriteLine($"{i} X {numero} = {numero * i}");
}