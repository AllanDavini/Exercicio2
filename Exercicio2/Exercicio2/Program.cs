using System;
using System.Collections.Generic;

namespace Exercicio2
{
    internal class Program
    {
        private static void Main()
        {
            var listItens = new List<Item>
            {
                new Item(1, "Coca-Cola", 0, 365, 1, 10, true, 1),
                new Item(2, "Salgadinho Doritos", 0, 35, 2, 20, false, 2),
                new Item(3, "Salame", 0, 2, 10, 5, false, 5),
                new Item(4, "Pão de Forma", 0, 4, 1, 5, false, 3),
                new Item(5, "Bolacha", 0, 20, 1, 20, false, 2)
            };

            foreach (var iten in listItens)
            {
                iten.Preco = iten.Formula(iten.Custo, iten.Validade);
                Console.WriteLine($"{iten.Id} - {iten.Nome} - R${iten.Preco}");
            }

            Console.ReadKey();
        }
        
    }
}
