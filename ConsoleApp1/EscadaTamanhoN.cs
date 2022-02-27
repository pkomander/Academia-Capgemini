using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class EscadaTamanhoN
    {
        static void Main(string[] args)
        {
            /*
             Escreva um algoritmo que mostre na tela uma escada de tamanho n utilizando o caractere * e espaços. 
             A base e altura da escada devem ser iguais ao valor de n. A última linha não deve conter nenhum espaço.
            entrada = 6;

            saida:
            *
            **
            ***
            ****
            *****
            ******
             */
            //questão 1
            List<string> ListaIcones = new List<string>();
            int n = 6;
            for (var i = 1; i <= n; i++)
            {
                string aux = "";
                for (var j = 1; j <= i; j++)
                {
                    aux += "*";
                }
                ListaIcones.Add(aux);
            }
            foreach (var item in ListaIcones)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
