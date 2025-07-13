// Desenvolva um programa em C# que utilize uma estrutura de repetição for para calcular a soma dos números de 1 a 10. Exiba o resultado no console.

using System;

namespace Desafio1 {
       class Program {
        static void Main() {

            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            Console.WriteLine($"A soma dos numeros do Array são : {sum}");
        }
    }
}

