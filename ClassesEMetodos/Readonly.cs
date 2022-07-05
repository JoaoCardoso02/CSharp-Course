using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0:D2}/{1:D2}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    public class Readonly
    {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            //novoCliente.Nascimento = new DateTime(2000, 10, 10);
        }
    }
}

