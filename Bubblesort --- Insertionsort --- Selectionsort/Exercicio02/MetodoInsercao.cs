/*using System;
using System.Collections.Generic;*/


/*Faça uma função que ordene um vetor de inteiros passado por
parâmetro utilizando o método bolha e retorne o número de trocas realizadas.*/


class MetodoInsercao
{
    static void Main(string[] args)
    {
        var vet = new int[] { 1, 5, 7, -1, 0 };

        int trocas = Insercao(vet);

        foreach (var item in vet)
        {
            Console.Write($"{item} ");
        }
        System.Console.WriteLine("\nNúmero de trocas: "+trocas);
    }  
    
    static int Insercao(int[] vet)
    {
        int trocas = 0;
        for (int i = 1; i < vet.Length; i++)
        {
            int chave = vet[i];
            int j = i - 1;

            while (j >= 0 && chave < vet[j])
            {
                vet[j + 1] = vet[j];
                j--;
                trocas++;
            }
            vet[j + 1] = chave;
        }
        return trocas;
    }
}
