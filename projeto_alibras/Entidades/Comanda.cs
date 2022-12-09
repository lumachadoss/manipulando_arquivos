using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_alibras.Entidades
{
    public class T_Comanda
    {
        public int Id { get;  set; }
        [Required]
        public string ClienteId { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public DateTime AlteradoEm { get; set; }
        [Required]
        public DateTime FinalizadoEm { get; set; }
        [Required]
        public decimal ValorPago { get; set; }
        [Required]
        public decimal ValorTotal { get; set;}
        [Required]

    }
}
