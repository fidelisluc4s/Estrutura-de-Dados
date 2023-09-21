using System;
using System.Collections.Generic;
using System.Text;

/*Faça um procedimento que receba um número n inteiro e positivo. O
procedimento deve imprimir todos os números do intervalo entre 0 e n que são
divisíveis por 2 e por 3 (simultaneamente). Restrição: não utilize comandos de
repetição.*/

class Program{
    static void Main(string[] args){        

        somaIntervalo(7,1);

    }
    static void somaIntervalo(int numero, int i){

        if(i<=numero){
            if(i%2 ==0 && i %3==0){
                Console.WriteLine(i);
            }
            somaIntervalo(numero, i+1);    
        }
    }
}