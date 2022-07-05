using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(10));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 8));
        }
    }
}

