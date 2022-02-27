using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Anagrama
    {
        static void Main(string[] args)
        {
            /*
             Duas palavras podem ser consideradas anagramas de si mesmas se as letras de uma palavra podem ser realocadas 
            para formar a outra palavra. Dada uma string qualquer, desenvolva um algoritmo que encontre o número de pares 
            de substrings que são anagramas.
             */
            const int MAX = 256;

            string p1 = "BACDGABCDA";
            string p2 = "ABCD";

            Buscar(p2, p1);

            bool Comparar(char[] arr1, char[] arr2)
            {
                for (int i = 0; i < MAX; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            // essa função busca por valores similares entre a variavel de entrada path e txt
            void Buscar(string pat, string txt)
            {
                int M = pat.Length;
                int N = txt.Length;

                // countP[]: contem o tamanho total de uma string char
                // countTW[]: contem o tamanho total de uma string char
                // window of text
                char[] countP = new char[MAX];
                char[] countTW = new char[MAX];
                for (int i = 0; i < M; i++)
                {
                    (countP[pat[i]])++;
                    (countTW[txt[i]])++;
                }

                // busca pelos valores restantes no array de N
                for (int i = M; i < N; i++)
                {
                    // comparando elementos dos arrays e verificando se são similares
                    if (Comparar(countP, countTW))
                    {
                        Console.WriteLine("Found at Index " + (i - M) + $" ");
                    }

                    // adicionando o proximo elemento
                    (countTW[txt[i]])++;

                    // removendo o primeiro elemento do array do loop atual 
                    countTW[txt[i - M]]--;
                }

                // verificando se a interação possui elementos similares
                if (Comparar(countP, countTW))
                {
                    Console.WriteLine("Found at Index " + (N - M));
                }
            }
            Console.ReadLine();
        }
    }
}
