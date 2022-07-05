using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class UsandoContinue
    {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Números para entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }

                Console.Write(i + " ");
            }
        }
    }
}

