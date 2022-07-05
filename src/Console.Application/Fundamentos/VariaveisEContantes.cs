using System;

namespace CursoCSharp.Fundamentos {
    public class VariaveisEContantes {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            uint menorValorUint = uint.MinValue;
            Console.WriteLine("Poupulação brasileira " + populacaoBrasileira);
            Console.WriteLine("Menor uint" + menorValorUint);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            float minValueFloat = float.MinValue;
            float maxValueFloat = float.MaxValue;
            Console.WriteLine("Preço computador " + precoComputador);
            Console.WriteLine("Menor float " + minValueFloat);
            Console.WriteLine("Maior float " + maxValueFloat);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usados dos reais;
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Curso de C#";
            Console.WriteLine(texto);

        }
    }
}
