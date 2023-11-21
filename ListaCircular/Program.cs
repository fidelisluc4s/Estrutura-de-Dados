class Program
{
    static void Main(string[] args)
    {
        ListaCircular lista = new ListaCircular();

        lista.AdicionarNoInicio(1);
        lista.AdicionarNoInicio(2);
        lista.AdicionarNoFinal(3);

        Console.WriteLine("Tamanho da lista: " + lista.Tamanho);

        lista.RemoverNoInicio();
        lista.RemoverNoFinal();

        Console.WriteLine("Tamanho da lista após remoção: " + lista.Tamanho);
    }
}
