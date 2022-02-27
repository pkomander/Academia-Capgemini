using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Questao2SenhaForte
    {
        static void Main(string[] args)
        {
            /*
             Débora se inscreveu em uma rede social para se manter em contato com seus amigos. A página de cadastro exigia o preenchimento dos campos de nome e senha, porém a senha precisa ser forte. O site considera uma senha forte quando ela satisfaz os seguintes critérios:
            °Possui no mínimo 6 caracteres.
            °Contém no mínimo 1 dígito.
            °Contém no mínimo 1 letra em minúsculo.
            °Contém no mínimo 1 letra em maiúsculo.
             */
            //questão 2
            //https://www.c-sharpcorner.com/article/c-sharp-regex-examples/
            //https://csharp.net-tutorials.com/pt/418/expressoes-regulares-regex/buscando-com-a-classe-regex/
            List<string> listaSenhas = new List<string>
            {
                "Paul1@","asdfF2","Qew?1F","asdwqe","123456"
            };

            foreach (var item in listaSenhas)
            {
                string enviaSenha = ValidaSenha(item);
                Console.WriteLine(enviaSenha);


            }

            string ValidaSenha(string senha)
            {
                string retorno = senha + " - ";
                if (senha.Length > 6)
                {
                    retorno = "Senha possui mais de 6 caracteres. \n";
                    return retorno;
                }

                Regex senhaMinuscula = new Regex("[a-z]+");
                Regex senhaMaiuscula = new Regex("[A-Z]+");
                Regex senhaNumeros = new Regex("[0-9]+");
                Regex senhaEspeciais = new Regex("(?=.*[}{,.^?~#!@=+\\-_\\/*\\-+.\\|])");
                if (senhaMinuscula.IsMatch(senha))
                {
                    //Console.WriteLine(true);
                }
                else
                {
                    retorno += "Senha deve possuir uma letra Minuscula. \n";
                }

                if (senhaMaiuscula.IsMatch(senha))
                {
                    //Console.WriteLine(true);
                }
                else
                {
                    retorno += "Senha deve possuir uma letra Maiuscula. \n";
                }

                if (senhaNumeros.IsMatch(senha))
                {
                    //Console.WriteLine(true);
                }
                else
                {
                    retorno += "Senha deve possuir um Numero. \n";
                }

                if (senhaEspeciais.IsMatch(senha))
                {
                    //Console.WriteLine(true);
                }
                else
                {
                    retorno += "Senha deve possuir um caractere especial. \n";
                }

                if (retorno == (senha + " - "))
                {
                    retorno += "senha valida \n";
                }

                return retorno;
            }


            //senha forte
            List<string> listaSenhaForte = new List<string>
            {
                "a1s","abc123","a1b2c"
            };

            foreach (var item in listaSenhaForte)
            {
                var enviaSenha = ValidaSenhaForte(item);
                Console.WriteLine(enviaSenha);
            }

            string ValidaSenhaForte(string senha)
            {
                string retorno = "";
                if (senha.Length < 6)
                {
                    int quantidadeCaracteres = senha.Length;
                    int quantidadeCaracteresFalta = 6 - quantidadeCaracteres;
                    retorno = $"Sua senha possui {quantidadeCaracteres} caracteres ela deve possuir no minimo 6 caracteres para ser considerada forte! \nAdicione mais {quantidadeCaracteresFalta} caracteres!\n";
                }
                else
                {
                    retorno = "senha valida!\n";
                }

                return retorno;
            }

            Console.ReadLine();
        }
    }
}
