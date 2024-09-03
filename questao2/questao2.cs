/* 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que
   desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
   IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código; */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int A = 0, B = 1, aux = 0;

            while (B < N)
            {
                aux = A;
                A = B;
                B = aux + B;
            }

            if (B == N)
            {
                Console.WriteLine("O número " + N + " pertence à sequência de Fibonacci!");
            }
            else
            {
                Console.WriteLine("O número " + N + " não pertence à sequência de Fibonacci!");
            }
            Console.ReadLine();
        }
    }
}
