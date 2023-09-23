using System;
using System.Collections.Generic;

/*Questão 1) Faça uma função recursiva que receba um número inteiro por parâmetro
int numero
e retorne true se o número for um número perfeito ou false caso contrário.
bool resultado
Um número perfeito é um número natural para o qual a soma de todos os seus divisores naturais é igual ao próprio número.*/


class Program
{
    static void Main(string[] args)
    {
        int numero = 6;
        int somaDivisores = 0;
        int cont = 1;
        bool resultado = numeroPerfeito(numero, cont, somaDivisores);
        Console.WriteLine(resultado);

    }
    static bool numeroPerfeito(int numero, int cont, int somaDivisores)
    {

        if (cont >= numero)
        {
            return somaDivisores == numero;
        }
        if (numero % cont == 0)
        {
            somaDivisores += cont;
        }

        return numeroPerfeito(numero, ++cont, somaDivisores);
    }
}
