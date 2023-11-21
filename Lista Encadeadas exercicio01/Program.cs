


var lista = new ListaSimplesmenteEncadeada();

Console.WriteLine("Elementos");
lista.AdicionarNoInicio(10); //10
lista.AdicionarNoInicio(4);  // 5 10
lista.AdicionarNoFinal(3);  // 5 10 20
lista.AdicionarNoFinal(30);  // 5 10 20 30


Imprimir();

Console.WriteLine("Removendo no final:");
lista.RemoverNoFinal();
Imprimir();

Console.WriteLine("Removendo no início:");
lista.RemoverNoInicio();
Imprimir();

void Imprimir()
{
    lista.ParaCada(x => Console.Write($"{x}  "));

    Console.WriteLine();
}