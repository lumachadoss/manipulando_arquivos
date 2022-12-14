using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_alibras.Entidades
{
     public class ItemComanda
     {
        public int Id { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public DateTime AlteradoEm { get; set; }
        [Required]
        public DateTime CriadoEm { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public decimal ValorUnitario { get; set; }
        [Required]
     }
}
