//Crie um programa em C# que calcule o Índice de Massa Corporal (IMC). Solicite ao usuário que insira seu peso (em quilogramas) e sua altura (em metros).
//O IMC é calculado pela fórmula:
//IMC = peso / (altura * altura)
//Exiba o resultado no console indicando a faixa de classificação.

using System;

namespace IMCCalculator {
    class Program {
        static void Main() {
            double peso, altura, imc;

            Console.WriteLine("Cálculo do Índice de Massa Corporal (IMC)");

            Console.Write("Digite seu peso (em kg): ");
            if (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0) {
                Console.WriteLine("Erro: Peso inválido. Deve ser um número positivo ou maior que 0.");
                return;
            }

            Console.Write("Digite sua altura (em metros): ");
            if (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0) {
                Console.WriteLine("Erro: Altura inválida. Deve ser um número positivo ou maior que 0.");
                return;
            }

            imc = CalcularImc(peso, altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}");
            Console.WriteLine("Classificação: " + ClassificarIMC(imc));
        }

        static double CalcularImc(double peso, double altura) {
            return peso / (altura * altura);
        }

        static string ClassificarIMC(double imc) {
            if (imc < 18.5)
                return "Abaixo do peso";
            else if (imc < 24.9)
                return "Peso normal";
            else if (imc < 29.9)
                return "Sobrepeso";
            else if (imc < 34.9)
                return "Obesidade grau 1";
            else if (imc < 39.9)
                return "Obesidade grau 2";
            else
                return "Obesidade grau 3 (mórbida)";
        }
    }
}
