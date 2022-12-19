using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using projeto_alibras.Entidades;

namespace projeto_alibras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"C:\projects\Carga-Venda-2022-11-30-2022-12-01-sem-cabecalho.csv");
            foreach (var line in lines)
            {

                string[] arr = line.Split(';');
                string matricula = arr[0];
                decimal valor = Convert.ToDecimal(arr[1]);
                DateTime diaCompra = Convert.ToDateTime(arr[2]);
                Console.WriteLine($" Matrícula: {matricula}, valor: {valor}, dia da compra: {diaCompra}");
            }
            var comanda = new Comanda
            {
                FinalizadoEm = diaCompra,
                Inicio = diaCompra,
                Status = 1,
                ValorPago = valor,
                ValorTotal = valor,
                Itens = new List<ItemComanda>(),
                //ClienteCartaoCredito
            };

            var itemComanda = new ItemComanda
            {
                AlteradoEm = diaCompra,
                CriadoEm = diaCompra,
                Quantidade = 1,
                Status = 1,
                Valor = valor,
                ValorUnitario = valor,
                //ProdutoId = 1
            };

            comanda.Itens.Add(itemComanda);
            Console.ReadKey();

        }
    }
}
