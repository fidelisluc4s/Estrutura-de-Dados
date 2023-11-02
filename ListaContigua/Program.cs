//Program.cs:
/*
Action<int, int> somar = (int a, int b) => 
    Console.WriteLine(a + b);;

somar(5, 2);

Func<int, int, int> fSomar = (int a, int b) => a + b;;

Console.WriteLine(fSomar(10, 5));
*/


var lista = new ListaContigua();

lista.AdicionarNoInicio(10); //10
lista.AdicionarNoInicio(5);  // 5 10
lista.AdicionarNoFinal(20);  // 5 10 20
lista.AdicionarNoFinal(30);  // 5 10 20 30

Console.WriteLine($"Tamanho da lista: {lista.Tamanho}");

Imprimir();

Console.WriteLine("Removendo no final:");
lista.RemoverNoFinal();
Imprimir();

Console.WriteLine("Removendo no início:");
lista.RemoverNoInicio();
Imprimir();

Console.WriteLine($"Tamanho da lista: {lista.Tamanho}");

var soma = 0;

lista.ParaCada(x => soma += x);

Console.WriteLine($"Soma dos elementos: {soma}.");

void Imprimir()
{
    lista.ParaCada(x => Console.Write($"{x}  "));

    Console.WriteLine();
}