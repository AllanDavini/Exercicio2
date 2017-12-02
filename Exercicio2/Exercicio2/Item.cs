using System;
using System.Diagnostics;

namespace Exercicio2
{
    public class Item
    {
        public Item(int id, string nome, double preco, int validade, double custoCompra, int volumeOcupado, bool refrigerado, int riscoVencer)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Validade = validade;
            CustoCompra = custoCompra;
            VolumeOcupado = volumeOcupado;
            Refrigerado = refrigerado;
            RiscoVencer = riscoVencer;
            Custo = CalcularCusto();
        }
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Custo { get; set; }
        public double Preco { get; set; }
        public int Validade { get; set; }
        public double CustoCompra { get; set; }
        public int VolumeOcupado { get; set; }
        public bool Refrigerado { get; set; }
        public int RiscoVencer { get; set; }

        internal double Formula(double custo, int validade)
        {
            if (validade < 5)
            {
                return custo * 1.5;
            }

            return custo * 3;
        }

        private double CalcularCusto()
        {
            var custo = Refrigerado
                ? (CustoCompra * VolumeOcupado) * 1.25 / 10
                : (CustoCompra * VolumeOcupado) / 10;

            switch (RiscoVencer)
            {
                case 1:
                    return custo * 2;
                case 2:
                    return custo * 1.75;
                case 3:
                    return custo * 1.50;
                case 4:
                    return custo * 1.25;
                default:
                    return custo;
            }

        }
    }
}