using System;
 
namespace CursoCSharp.Fundamentos
{
    public class OperadorTernario {

        public static void Executar() {
            var nota = 8.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);
        }
    }
}

