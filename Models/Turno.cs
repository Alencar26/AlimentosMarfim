using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models
{
    public class Turno
    {
        [Display(Description = "Código do Turno")]
        public int Id { get; set; }


        [Display(Description = "Turno")]
        public DateTime turno { get; set; }

    }
}
