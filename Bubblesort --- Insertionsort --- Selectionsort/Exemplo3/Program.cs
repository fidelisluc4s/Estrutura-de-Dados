using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var vet = new double[]{1.4,-4,0,7.8,1};

        Selecao(vet);

        foreach(var item in vet){
            System.Console.Write($"{item} / ");
        }

        
    }
    static void Selecao(double[] vetor)
    {
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            int indMenor = i;

            for(int j = i + 1; j < vetor.Length; j++)
            {
                if(vetor[j] < vetor[indMenor])
                {
                    indMenor = j;
                }
            }
            if(i != indMenor)
                Troca(vetor, i, indMenor);
        }
    }
    static void Troca(double[] vet, int j, int i)
    {
        double aux = vet[i];
        vet[i] = vet[j];
        vet[j] = aux;
    }
}