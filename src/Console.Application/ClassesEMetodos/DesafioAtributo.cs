using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class DesafioAtributo
    {
        readonly int a = 10;

        public static void Executar () {
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}

