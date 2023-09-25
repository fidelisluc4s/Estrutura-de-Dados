using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var vet = new double[]{1.4,2.3,0,-1,7.8};
        
        Insercao(vet);

        foreach(var item in vet)
        {
            Console.Write($"{item} / ");
        }
        
    }
    static void Insercao(double[] vetor)
    {
        for (int i = 1; i < vetor.Length; i++)
        {
            double chave = vetor[i];
            int j = i-1;

            while (j >= 0 && chave < vetor[j])
            {
                vetor[j + 1] = vetor[j];
                j--;                
            }
            vetor[j + 1] = chave;            
        }
    }

    
}