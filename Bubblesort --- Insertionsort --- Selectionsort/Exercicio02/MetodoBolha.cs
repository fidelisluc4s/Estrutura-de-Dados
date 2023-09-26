using System;
using System.Collections.Generic;


/*Faça uma função que ordene um vetor de inteiros passado por
parâmetro utilizando o método bolha e retorne o número de trocas realizadas.*/

/*class MetodoBolha
{
    static void Main(string[] args)
    {
        int[] vet = new int[] { 1, 5, 7, -1, 0 };

        int cont = Bolha(vet);

        foreach (var item in vet)
        {
            Console.Write($"{item} ");
        }
        System.Console.WriteLine("\nNúmeros de trocas: " + cont);

    }
    static int Bolha(int[] vet)
    {
        int fim = vet.Length - 1;
        int pos = 0;
        int cont = 0;
        bool troca = true;
        while (troca)
        {
            troca = false;
            for (int i = 0; i < fim; i++)
                if (vet[i] > vet[i + 1])
                {
                    Troca(vet, i, i + 1);
                    pos = i;
                    troca = true;
                    cont++;
                }
            fim = pos - 1;
        }
        return cont;

    }
    static void Troca(int[] vet, int i, int j)
    {
        int aux = vet[i];
        vet[i] = vet[j];
        vet[j] = aux;
    }
}*/