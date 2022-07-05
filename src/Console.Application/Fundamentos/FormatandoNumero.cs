using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo culturaPtBr = new CultureInfo("pt-BR");
            CultureInfo culturaEnUs = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", culturaPtBr));
            Console.WriteLine(valor.ToString("C0", culturaEnUs));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
