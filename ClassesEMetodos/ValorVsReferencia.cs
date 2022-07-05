using System;
namespace CursoCSharp.ClassesEMetodos
{
    public struct Dependente {
        public string Nome;
        public int Idade;
    }
    public class ValorVsReferencia
    {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20,
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 32;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            string text = "Algum texto";
            string text1 = text;

            Console.WriteLine($"{text} {text1}");

            text = "Mudou";

            Console.WriteLine($"{text} {text1}");

        }
    }
}

