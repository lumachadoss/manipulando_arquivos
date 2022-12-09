using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_alibras.Entidades
{
    public class Cliente
    {
          
        public int Id { get; internal set; }
        [Required]
        public string Matricula { get; set; }
        [StringLength(30)]
        public int Status { get; set; }
        [Required]

    }
}

