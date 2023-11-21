class ListaSimplesmenteEncadeada
{
    private No? primeiro = null;
    private No? ultimo = null;
  
    public void AdicionarNoInicio(double valor){
        var novoNo = new No {Valor = valor };

        if(primeiro == null)
            primeiro = ultimo = novoNo;
        else{
            novoNo.Proximo = primeiro;
            primeiro = novoNo;
        }
    }

    public void AdicionarNoFinal(double valor){

        var novoNo = new No { Valor = valor };

        if(ultimo == null)
            primeiro = ultimo = novoNo;
        else{
            ultimo.Proximo = novoNo;
            ultimo = novoNo;
        }
    }

    public void RemoverNoInicio(){

        if(primeiro == null)
            throw new Exception ("Não é possivel remover elementos de uma lista vazia. ");
        if(primeiro == ultimo)
            primeiro = ultimo = null;
        else
            primeiro = primeiro.Proximo;
    }
    public void RemoverNoFinal(){

        if(ultimo == null)
            throw new Exception ("Não é possivel remover elementos de lista vazia. ");
        if(primeiro == ultimo)
            ultimo = primeiro = null;
        else{
            var penultimo = primeiro;

            while (penultimo?.Proximo?.Proximo != null)
                penultimo = penultimo.Proximo;
            
            if(penultimo != null)
            {
                penultimo.Proximo = null;
                ultimo = penultimo;
            }
        }             
    }

    public void ParaCada(Action<double> acao){
        var atual = primeiro;
        while (atual != null){
            acao(atual.Valor);
            atual = atual.Proximo;
        }
    }
    
    public void AdicionarVariosNoFinal(ListaSimplesmenteEncadeada lista){
        lista.ParaCada(x => AdicionarNoFinal(x));
    }

    public void AdicionarVariosNoInicio(ListaSimplesmenteEncadeada lista){
        var listaAux = new ListaSimplesmenteEncadeada();

        lista.ParaCada(x => listaAux.AdicionarNoInicio(x));

        listaAux.ParaCada(x => AdicionarNoInicio(x));
    }

    public void Ordenar()
    {
        if(primeiro == null)
        return;

        No atual;
        bool houveTroca;

        do{
            houveTroca = false;
            atual = primeiro;

            while(atual.Proximo != null)
            {
                if(atual.Valor > atual.Proximo.Valor)
                {
                    TrocarValor(atual, atual.Proximo);
                    houveTroca = true;
                }
                atual = atual.Proximo;
            }
        } while (houveTroca);
    }
    private void TrocarValor(No no1, No no2){
        var aux = no1.Valor;
        no1.Valor = no2.Valor;
        no2.Valor = aux;
    }

   

}