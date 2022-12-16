using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_alibras.Entidades
{
    public class ClienteContaCorrente
    {
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public DateTime MovimentoEm { get; set; }
        [Required]
        public decimal Saldo { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]

    }
}
