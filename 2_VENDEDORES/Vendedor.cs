using System;

namespace _2_VENDEDORES
{
    class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double PercComissao { get; set; }
        public Venda[] AsVendas { get; set; }

        public Vendedor(int id, string nome, double percComissao)
        {
            Id = id;
            Nome = nome;
            PercComissao = percComissao;
            AsVendas = new Venda[31]; // Um mês
        }

        public void RegistrarVenda(int dia, Venda venda)
        {
            if (dia < 1 || dia > 31)
            {
                Console.WriteLine("Dia inválido!");
                return;
            }
            AsVendas[dia - 1] = venda;
        }

        public double ValorVendas()
        {
            double total = 0;
            foreach (var venda in asVendas)
            {
                if (venda != null)
                {
                    total += venda.ValorMedio();
                }
            }
            return total;
        }

        public double ValorComissao()
        {
            return ValorVendas() * PercComissao / 100;
        }
    }
}