﻿﻿// <auto-generated/>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
/* Veja abaixo um exemplo de algoritmo iterativo para cálculo dos divisores de um
número natural.*/
/*class program
{
    static void Main(string[] args)
    {
        int numero;

        ImprimirDivisores(150);

    }
    
    static void ImprimirDivisores(int numero)
    {      
        for(int divisor = 1; divisor <= numero; divisor++)
        {
            if(numero % divisor == 0)
            Console.Write($"{divisor} ");
        }        
    }
}*/
/* Seguindo os cinco passos para transformar esse procedimento em um procedimento
recursivo, temos:*/

/*Substitua o comando for ou o comando do..while pelo comando while.*/
/*class program
{
    static void Main(string[] args)
    {
        int numero;

        ImprimirDivisores(150);
    }    
    static void ImprimirDivisores(int numero)
    {      
        int divisor = 1;
        while(divisor <= numero)
        {
            if(numero % divisor == 0)
            Console.Write($"{divisor} ");

             divisor++;
        }        
    }
}*/

/* Altere a sub-rotina para passar a receber por parâmetro o valor a ser
processado */

/*class program
{
    static void Main(string[] args)
    {
        int numero;

        ImprimirDivisores(150,1);
    }    
    static void ImprimirDivisores(int numero,int divisor)
    {   
        while(divisor <= numero)
        {
            if(numero % divisor == 0)
            Console.Write($"{divisor} ");

             divisor++;
        }        
    }
}*/

/*. Substitua o comando de atualização da variável de controle do comando
while pela chamada recursiva passando por parâmetro o próximo valor dessa
variável.*/

/*class program
{
    static void Main(string[] args)
    {
        int numero;

        ImprimirDivisores(150,1);
    }    
    static void ImprimirDivisores(int numero,int divisor)
    {   
        while(divisor <= numero)
        {
            if(numero % divisor == 0)
            Console.Write($"{divisor} ");

            ImprimirDivisores(numero, divisor+1);
        }        
    }
}*/

/*Substitua o comando while por um comando if.*/

/*class program
{
    static void Main(string[] args)
    {
        int numero;

        ImprimirDivisores(150,1);
    }    
    static void ImprimirDivisores(int numero,int divisor)
    {   
        if(divisor <= numero)
        {
            if(numero % divisor == 0)
            Console.Write($"{divisor} ");

            ImprimirDivisores(numero, divisor+1);
        }        
    }
}*/

/*Crie uma função empacotadora para fazer a primeira chamada à sub-rotina
recursiva.*/

/*class program
{
    static void Main(string[] args)
    {
        int numero;

        ImprimirDivisores(150);
    }    
    static void ImprimirDivisores(int numero,int divisor)
    {   
        if(divisor <= numero)
        {
            if(numero % divisor == 0)
            Console.Write($"{divisor} ");

            ImprimirDivisores(numero, divisor+1);
        }        
    }
    static void ImprimirDivisores(int numero)
    {
        ImprimirDivisores(numero,1);
    }
}*/

/*Se você não quiser criar a sub-rotina empacotadora, em C# você pode definir o valor
padrão para um argumento de uma sub-rotina se o mesmo não for passado. Adicionando
o valor 1 como padrão para o argumento divisor da nossa função, ao não passarmos esse
parâmetro, será assumido o valor 1 para o mesmo. Dessa forma, podemos chamar a
função passando apenas o valor para o parâmetro chamado numero e deixando o
parâmetro chamado divisor ser passado somente nas chamadas recursivas. Veja o único
procedimento abaixo.*/

class program
{
    static void Main(string[] args)
    {
        int numero;

        ImprimirDivisores(150,1);
    }    
    static void ImprimirDivisores(int numero,int divisor)
    {   
        if(divisor <= numero)
        {
            if(numero % divisor == 0)
            Console.Write($"{divisor} ");

            ImprimirDivisores(numero, divisor+1);
        }        
    }
}