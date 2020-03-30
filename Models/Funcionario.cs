using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models
{
    public class Funcionario
    {
        [Display(Description = "Código do Funcionário")]
        public int Id { get; set; }


        [Display(Description = "Nome do Funcionário")]
        public string nomeFuncionario { get; set; }


        [Display(Description = "Telefone")]
        public string telefone { get; set; }


        [Display(Description = "PIS")]
        public string PIS { get; set; }


        [Display(Description = "Cargo do Funcionário")]
        public string cargo { get; set; }


        [Display(Description = "Salário")]
        public double salario { get; set; }


        [Display(Description = "Setor")]
        public string setor { get; set; }


        [Display(Description = "Turno")]
        public string turno { get; set; }

    }
}
