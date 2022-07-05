using System;
namespace CursoCSharp.Colecoes
{
    public class Igualdade
    {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p2 == p3);

            Console.WriteLine(p1.Equals(p2));
        }
    }
}

