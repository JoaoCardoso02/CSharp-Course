using System;

namespace CursoCSharp.EstruturasDeControle
{
    public class EstruturaForEach
    {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Paulo", "Pedro" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}

