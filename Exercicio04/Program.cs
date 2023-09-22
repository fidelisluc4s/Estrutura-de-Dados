using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
/*Questão 1) Faça uma função recursiva que receba um número inteiro por parâmetro e retorne true se o número 
for um número perfeito ou false caso contrário. Um número perfeito é um número natural para o qual a soma de 
todos os seus divisores naturais é igual ao próprio número. Esta função não pode utilizar comandos de repetição.*/



class Program{
    static void Main(string[] args){
        int check = numeroPerfeito(6,1,0);
        Console.WriteLine(check);
        
    }
    static int numeroPerfeito(int numero, int i, int somaDivisores){
        if (i>=numero)
        {
            if (somaDivisores==numero){
                return numero;
            }else{
                return -1;
            }
        }
        if(numero%i==0){
            somaDivisores+=i;
        }
        return numeroPerfeito(numero,i+1,somaDivisores);
    }
}