using projeto_alibras.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_alibras.Contexto
{
    public class AlibrasDbContext : DbContext
    {
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteCartaodeCredito> ClienteCartaodeCredito { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItemComanda> Itemcomanda { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<Lancamento> Lancamento { get; set; }
        public DbSet<ClienteContaCorrente> ClienteContaCorrente { get; set; }
    }
}
