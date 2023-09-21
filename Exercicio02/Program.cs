using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
/*7) Faça uma função recursiva que receba um número inteiro 𝑛 por parâmetro e
retorne a soma dos números inteiros entre zero e 𝑛. A função deve funcionar
adequadamente tanto para 𝑛 positivo quanto para negativo. Para esse exercício
não se pode utilizar as estruturas de repetição (for, while e do while).*/

class Program
{    
    static void Main(string[] args)
    {
        int soma = somaNumeros(-1);
        Console.WriteLine(soma);
    }
    static int somaNumeros(int n)
    {        
        if (n > 0)                   
            return n + somaNumeros(n - 1);        
        else if (n < 0)
            return n + somaNumeros(n+1);
        else
          return 0;        
    }
}