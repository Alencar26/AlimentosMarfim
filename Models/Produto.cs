using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models
{
    public class Produto
    {
        [Display(Description = "Código do Produto")]
        public int Id { get; set; }


        [Display(Description = "Nome do Produto")]
        public string nomeProduto { get; set; }


        [Display(Description = "Descrição")]
        public string descicao { get; set; }


        [Display(Description = "Quantidade")]
        public int quantidade { get; set; }


        [Display(Description = "Valor Unitário")]
        public double valorUnitario { get; set; }

    }
}
