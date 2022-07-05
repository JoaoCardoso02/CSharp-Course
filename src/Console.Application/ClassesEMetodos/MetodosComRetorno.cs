using System;

namespace CursoCSharp.ClassesEMetodos
{
	class CalculadoraComum {
        public int Somar(int a, int b) {
			return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;

            return this;
        }

        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;

            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;

            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;

            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);

            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    public class MetodosComRetorno
	{
		public static void Executar() {
			CalculadoraComum calculadoraComum = new CalculadoraComum();
			var resultado = calculadoraComum.Somar(2, 3);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(10, 8));
            Console.WriteLine(calculadoraComum.Multiplicar(9, 88));

            CalculadoraCadeia calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(7821).Subtrair(821).Imprimir().Limpar().Imprimir();
            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
            
        }
    }
}

