using System;
namespace CursoCSharp.ClassesEMetodos
{
	public class CalculadoraEstatica {
		public int Somar(int a, int b) {
			return a + b;
        }

		public static int Multiplcar(int a, int b) {
			return a * b;
        }
    }

	public class MetodosEstaticos
	{
		public static void Executar() {
			var resultado = CalculadoraEstatica.Multiplcar(2, 2);
			Console.WriteLine("Resultado: {0}", resultado);

			CalculadoraEstatica calc = new CalculadoraEstatica();

            Console.WriteLine(calc.Somar(resultado, 8));
            Console.WriteLine(CalculadoraEstatica.Multiplcar(resultado, 8));
		}
	}
}

