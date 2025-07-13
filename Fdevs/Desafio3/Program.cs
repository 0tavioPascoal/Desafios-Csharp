//Desenvolva uma calculadora simples em C# que permita ao usuário realizar operações de soma, subtração, multiplicação e divisão.
//O programa deve solicitar dois números e a operação desejada. Exiba o resultado no console.

using System;

namespace Calculator {
    class Program {
        static void Main(string[] args) {

            String[] signs = { "+", "-", "*", "/" };

            double result;

            Console.WriteLine("Bem-vindo à Calculadora Simples!");

            Console.WriteLine("Digite o primeiro número:");
            if (!double.TryParse(Console.ReadLine(), out double firstNumber)) {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }

            Console.WriteLine("Digite o segundo número:");
            if (!double.TryParse(Console.ReadLine(), out double secondNumber)) {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
            }


            Console.WriteLine("Escolha a operação desejada (+, -, *, /):");
            string operation = Console.ReadLine();

            bool operacaoValida = false;

            for (int i = 0; i < signs.Length; i++) {
                if (operation == signs[i]) {
                    operacaoValida = true;
                    Console.WriteLine($"Operação selecionada: {operation}");
                    break;
                }
            }

            if (!operacaoValida) {
                Console.WriteLine("Operação inválida. Por favor, escolha entre +, -, * ou /.");
                return;
            }



            switch (operation) {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"Resultado: {result}");
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"Resultado: {result}");
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Resultado: {result}");
                    break;

                case "/":
                    if (secondNumber == 0) {
                        Console.WriteLine("Erro: divisão por zero não é permitida.");
                    }
                    else {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"Resultado: {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
        }
    }
}

