using System;
using System.Collections.Generic;

/*Faça um procedimento recursivo que receba por parâmetro um vetor 𝑣𝑒𝑡 de
números reais e, multiplique por −1 todos os elementos negativos desse vetor.
Para esse exercício não se pode utilizar as estruturas de repetição (for, while e do
while).*/


class Program
{

    static void Main(string[] args)
    {
        int[] vet = new int[4] { -1, -2, 3, -4 };
        int i = 0;
        virePositivo(vet, i);

    }
    static void virePositivo(int[] vet, int i)
    {
        if (i < vet.Length)
        {
            if (vet[i] <= 0)
            {
                vet[i] *= -1;
            System.Console.WriteLine(vet[i]);
            }
            virePositivo(vet, i + 1);
        }
    }
}