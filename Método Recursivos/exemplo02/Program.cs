using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

/*1)Qual o resultado da execução do trecho de código abaixo?*/
static void ImprimirTexto(string texto)
{
    Console.WriteLine(texto);
    ImprimirTexto(texto);
}
/*a) O valor da variável texto ficará sendo impresso repetidas vezes sem parar. A
pilha de recursão pode ocupar toda a memória do computador se o sistema
operacional ou o usuário não intervir*/


/*2)Qual o resultado da execução do trecho de código abaixo?*/

static void ImprimirTexto(string texto)
 {
 ImprimirTexto(texto);
 Console.WriteLine(texto);
}
/*b) O programa ficará travado sem apresentar nada ao usuário. A pilha de
recursão pode ocupar toda a memória do computador se o sistema
operacional ou o usuário não intervir*/


/*3) Veja o trecho de código abaixo:*/
class program
{
    static void Main(string[] args)
    {
        A(6);
    }
    static void A(int n)
    {
        if (n > 0)
            A(n - 1);
        Console.Write($"{n} ");
    }
}
/*a) Apresenta um exemplo de recursividade direta.*/


/*4) Veja o trecho de código abaixo:*/

class program
{
    static void Main(string[] args)
    {
        B(6);
    }
    static void B(int n)
    {
        if(n>0)
            C(n);
    }
    static void C(int n)
    {
        B(n-1);
        Console.Write($"{n} ");
    }
}


/*b) Apresenta um exemplo de recursividade indireta.*/

/*A seguir se encontram duas sub-rotinas, sendo a primeira uma sub-rotina
empacotadora da segunda sub-rotina, sendo esta última recursiva. Assinale a
alternativa que indique a finalidade dessas sub-rotinas.*/

class program
{
   static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        int num = Convert.ToInt32(Console.ReadLine());
        
        {
            bool isPrime = X(num);
            if (isPrime)
            {
                Console.WriteLine("O número é primo.");
            }
            else
            {
                Console.WriteLine("O número não é primo.");
            }
        }        
    }
    static bool X(int n)
    {
        if (n < 1)
            throw new Exception("Numero inválido!");

        return X(n, n / 2);
    }
    static bool X(int n, int d)
    {
        if (d > 1)
            if (n % d != 0)
                return X(n, d - 1);
        return d == 1;
        Console.WriteLine(d);
    }
}

/*e) Retornar se o número 𝑛 é um número primo.*/