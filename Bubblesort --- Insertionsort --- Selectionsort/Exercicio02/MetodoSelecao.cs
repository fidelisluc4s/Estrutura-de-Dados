using System;
using System.Collections.Generic;

/*Faça uma função que ordene um vetor de inteiros passado por
parâmetro utilizando o método bolha e retorne o número de trocas realizadas.*/
class MetodoSelecao
{
    static void Main(string[] args)
    {
        int[] vet = new int[] { 1, 5, 7, -1, 0 };

        int cont = Selecao(vet);

        foreach (var item in vet)
        {
            System.Console.Write($"{item} ");
        }
        System.Console.WriteLine("\nNúmero de trocas: " + cont);

    }
    static void Troca(int[] vet, int i, int j)
    {
        int aux = vet[i];
        vet[i] = vet[j];
        vet[j] = aux;
    }

    static int Selecao(int[] vet)
    {
        int cont = 0;
        for (int i = 0; i < vet.Length - 1; i++)
        {
            int iMenor = i;
            for (int j = i + 1; j < vet.Length; j++)
            {
                if (vet[j] < vet[iMenor])
                {
                    iMenor = j;
                    cont++;
                }
            }
            if (i != iMenor)
                Troca(vet, i, iMenor);
        }
        return cont;
    }
}