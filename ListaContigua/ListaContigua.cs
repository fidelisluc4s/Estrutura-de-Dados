class ListaContigua
{
    public void AdicionarNoInicio(int valor)
    {
        if (inicio == 0)
            throw new Exception("A lista atingiu o limite para inserção no início.");

        elementos[--inicio] = valor;
    }

    public void AdicionarNoFinal(int valor)
    {
        if (final == MAX - 1)
            throw new Exception("A lista atingiu o limite para inserção no final.");
        
        elementos[++final] = valor;
    }

    public void RemoverNoInicio()
    {
        if (inicio > final)
            throw new Exception("Não existem elementos a serem removidos.");
        
        inicio++;
    }

    public void RemoverNoFinal()
    {
        if (inicio > final)
            throw new Exception("Não existem elementos a serem removidos.");

        final--;
    }

    public void ParaCada(Action<int> metodo)
    {
        for (int i = inicio; i <= final; i++)
            metodo(elementos[i]);
    }

    public int this[int i]
    {
        get 
        {
            if (i < 0 || i >= Tamanho)
                throw new Exception("O índice está fora dos limites da lista.");

            return elementos[inicio + i];
        }

        set
        {
            if (i < 0 || i >= Tamanho)
                throw new Exception("O índice está fora dos limites da lista.");

            elementos[inicio + i] = value;
        }
    }

    public int Tamanho { get { return final - inicio + 1; } }

    private const int MAX = 100;
    private int inicio = MAX / 2;
    private int final = MAX / 2 - 1;
    private int[] elementos = new int[MAX];
}