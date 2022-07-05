using System;
namespace CursoCSharp.EstruturasDeControle
{
    public class UsandoBreak
    {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}", numero);

            for (int i = 1; i <= 50; i++) {
                Console.WriteLine("{0} é número que queremos", i);

                if (i == numero) {
                    Console.WriteLine("Sim");
                    break;
                } else {
                    Console.WriteLine("Não");
                }

                Console.WriteLine("Fim!");
            }
        }
    }
}

