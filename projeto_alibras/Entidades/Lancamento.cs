using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_alibras.Entidades
{
     public class Lancamento
    {
        public int Id { get; set; }
        [Required]
        public DateTime CriadoEm { get; set; }
        [Required]
        public int Tipo { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public int CaixaId { get; set; }
        [Required]
        public int ClienteContaCorrenteId { get; set; }
        [Required]
        public int ComandaId { get; set; }
        [Required]
        public int FormaDePagamentoId { get; set; }
        [Required]

    }
}
