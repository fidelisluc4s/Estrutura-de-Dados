using System;
using System.Collections.Generic;
/*Questão 3: Faça um procedimento que receba o montante reservado para a aposentadoria de uma pessoa
 e a quantia que ela pretende retirar por mês. 
O montante reservado é corrigido a cada mês com a taxa de 0,55%, aplicada logo após a retirada.
 O procedimento deve imprimir o montante (após a retirada e a correção),mês a mês. 
O procedimento também deve imprimir o número de meses em que a pessoa conseguirá fazer a sua retirada. */

// valor, retirada,taxa,rValor,meses


class Program{
    static void Main(string[] args){
        double montante = 800.00;
        double retirada = 20.00;
        double tempo = 0;
        retiradaV(montante,retirada,tempo);
        

    }    
    static void retiradaV(double montante, double retirada, double tempo){
        
        if(montante <= 0){
            Console.WriteLine("dinheiro acabou. Em {0} meses",tempo);
            return;
        }
        if(montante > 0){

            montante -= retirada;
            montante *=  1.0055;
        }
            retiradaV(montante,retirada,tempo+1);

    }
}