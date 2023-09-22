using System;
using System.Collections.Generic;
using System.Text;
/*Questão 2: Faça uma função que receba um vetor de números inteiros por
parâmetro e multiplique por -1 todos os elementos negativos desse vetor. A função
deve retornar o número de elementos negativos encontrados. Restrição: não utilize
comandos de repetição.*/

class Program
{
    static void Main(string[] args)
    {
        int[] numero = new int[4] { -3, 5, 4, -4 };
        int i = 0, contador = 0;
        System.Console.WriteLine(multipliqueNegativo(numero, i, contador));
    }
    static int multipliqueNegativo(int[] numero, int i, int contador)
    {
        if (i < numero.Length)
        {
            if (numero[i] < 0)
            {
                numero[i] *= -1;
                return multipliqueNegativo(numero, ++i, ++contador);
            }
            return multipliqueNegativo(numero, ++i, contador);
        }
        return contador;
    }
}