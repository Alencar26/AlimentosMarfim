using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models
{
    public class Setor
    {

        [Display(Description = "Código do Setor")]
        public int Id { get; set; }


        [Display(Description = "Nome do Setor")]
        public string nomeSetor { get; set; }

    }
}
