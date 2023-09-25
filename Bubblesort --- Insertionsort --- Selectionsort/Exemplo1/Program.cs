using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        double[] vetor = new double[5] { 2, 5, -1, 3, 4 };

        BublleSort(vetor);

    }
    static void Troca(double[] vetor, int i, int j)
    {
        double aux = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = aux;
    }

    static void BublleSort(double[] vetor)
    {

        int fim = vetor.Length - 1;
        int pos = 0;
        bool troca = true;
        while (troca)
        {
            troca = false;
            for (int i = 0; i < fim; i++)
                if (vetor[i] > vetor[i + 1])
                {
                    Troca(vetor, i, i + 1);
                    pos = i;
                    troca = true;
                }
            fim = pos - 1;
        }


    }
}