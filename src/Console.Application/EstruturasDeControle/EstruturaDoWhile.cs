using System;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaDoWhile
    {
        public static void Executar() {
            string entrada;

            do {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja Bem-vindo {0}", entrada);
                Console.WriteLine("Deja continuar? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}

