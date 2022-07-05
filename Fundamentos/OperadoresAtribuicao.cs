using System;
using System.Dynamic;

namespace CursoCSharp.Fundamentos {
    public class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 1;
            num1 *= 3;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");

            dynamic c = new ExpandoObject();
            c.nome = "João";

            //dynamic d = c;

            //d.nome = "Maria";

            //Console.WriteLine(c.nome);
        }
    }
}
