using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar() {
            Formatar(mes: 1, ano: 2002, dia: 25);
        }
    }
}

