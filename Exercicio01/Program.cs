using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

/**Faça um procedimento recursivo que receba por parâmetro um vetor 𝑣𝑒𝑡 de
números reais e, multiplique por −1 todos os elementos negativos desse vetor.
Para esse exercício não se pode utilizar as estruturas de repetição (for, while e do
while).*/
class Program
{
    static void Main(string[] args)
    {
        int[] vet = new int[3]{1,3,6};

        multipliqueNegativos (vet,0);
    }
    static void multipliqueNegativos(int[] vet,int i)
    {           
        if(i < vet.Length)
        {
            if(vet[i] % 2 != 0)
            {
                vet[i] *= -1;
                Console.WriteLine($"{vet[i]} ");
                multipliqueNegativos(vet,i+1);            
            }
        }
    }
}