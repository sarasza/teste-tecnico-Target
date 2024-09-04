/* 5) Escreva um programa que inverta os caracteres de um string.
   IMPORTANTE:
   a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
   b) Evite usar funções prontas, como, por exemplo, reverse; */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine();
            string reverso = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                reverso += palavra[i];
            }

            Console.WriteLine("String original: " + palavra);
            Console.WriteLine("String invertida: " + reverso);

        }
    }
}
