using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models
{
    public class Venda
    {

        [Display(Description = "Código da Venda")]
        public int Id { get; set; }


        [Display(Description = "Nome do Cliente")]
        public Cliente nomeComprador { get; set; }


        [Display(Description = "Nome do Vendedor")]
        public Funcionario nomeVendedor { get; set; }


        [Display(Description = "Produto")]
        public List<Produto> listaProduto { get; set; }


        [Display(Description = "Valor Total")]
        public double valorTotal { get; set; }

    }
}
