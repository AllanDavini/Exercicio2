using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            var listItens = new List<Item>
            {
                new Item(1, "Coca-Cola", 0, 1.5, 365),
                new Item(2, "Salgadinho Doritos", 0, 3, 35),
                new Item(3, "Salame", 0, 10, 12),
                new Item(4, "Pão de Forma", 0, 2, 4),
                new Item(5, "Bolacha", 0, 1, 20)
            };

            Console.WriteLine("qual item deseja calcular o preço ? (Utilize o Número referente ao Item)");

            foreach (var x in listItens)
            {
                Console.WriteLine(x.id + " - " + x.nome);
            }

            var key = Console.Read();

            if (listItens.FindAll(c => c.id == key))
            {
                
            }
        }

    }
}
