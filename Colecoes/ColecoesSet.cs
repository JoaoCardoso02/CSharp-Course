using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    public class ColecoesSet
    {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8˚ Temporada de Game of Thrones", 99.9),
                new Produto("Poster", 100),
                new Produto("Poster", 100),
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

            //Console.WriteLine(carrinho.Contains(livro));
            //carrinho.Clear();
            //Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.GetType());
            //Console.WriteLine(carrinho);
            // carrinho.AddRange(combo);

        }
    }
}

