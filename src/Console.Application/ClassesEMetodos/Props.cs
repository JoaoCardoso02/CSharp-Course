using System;
namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional {
        double desconto = 0.1;
        string nome;

        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // Lambda
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

    }

    public class Props
    {
        public static void Executar() {
            var opcional1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(opcional1.PrecoComDesconto);

            //opcional1.PrecoComDesconto = 3000;

            var opcional2 = new CarroOpcional();
            opcional2.Nome = "Direção Elétrica";
            opcional2.Preco = 3499.9;

            Console.WriteLine(opcional2.Nome);
            Console.WriteLine(opcional2.Preco);
            Console.WriteLine(opcional2.PrecoComDesconto);
        }
    }
}

