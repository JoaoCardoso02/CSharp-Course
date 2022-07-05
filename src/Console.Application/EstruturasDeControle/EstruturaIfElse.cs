using System;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar() {
            double nota = 7;

            if (nota >= 7) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            } else {
                Console.WriteLine("Recuperação!");
                Console.WriteLine("Que feio!!");
            }
        }
    }
}

