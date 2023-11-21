class ListaCircular
{
    private No primeiro = null;
    private No ultimo = null;
    private int tamanho = 0;
    public int Tamanho { get; private set; }
    public void AdicionarNoInicio(int valor)
    {
        var novoNo = new No { Valor = valor };
        if (primeiro == null)
            primeiro = ultimo = novoNo;
        else
        {
            primeiro.Anterior = novoNo;
            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }
        primeiro.Anterior = ultimo;
        ultimo.Proximo = primeiro;
        tamanho++;
    }
    public void AdicionarNoFinal(int valor)
    {
        var novoNo = new No { Valor = valor };
        if (primeiro == null)
            primeiro = ultimo = novoNo;
        else
        {
            novoNo.Anterior = ultimo;
            ultimo.Proximo = novoNo;
            ultimo = novoNo;
        }
        primeiro.Anterior = ultimo;
        ultimo.Proximo = primeiro;
        tamanho++;
    }

    public void RemoverNoInicio()
    {
        if (primeiro != null)
        {
            if (primeiro == ultimo)
                primeiro = ultimo = null;
            else
            {
                primeiro = primeiro.Proximo;
                primeiro.Anterior = null;
            }
            primeiro.Anterior = ultimo;
            ultimo.Proximo = primeiro;
            tamanho--;
        }
    }
    public void RemoverNoFinal()
    {
        if (primeiro != null)
        {
            if (primeiro == ultimo)
                primeiro = ultimo = null;
            else
            {
                ultimo.Anterior.Proximo = null;
                ultimo = ultimo.Anterior;
            }
            primeiro.Anterior = ultimo;
            ultimo.Proximo = primeiro;
            tamanho--;
        }
    }

}