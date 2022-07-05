using System;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaIf
    {
        public static void Executar() {
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            bool bomComportamento = entrada.ToLower() == 's'.ToString();

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}

