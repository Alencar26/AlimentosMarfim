using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models
{
    public class Cliente
    {

        [Display(Description = "CNPJ do Cliente")]
        public string Id { get; set; }


        [Display(Description = "Nome")]
        public string nomeCliente { get; set; }


        [Display(Description = "Telefone")]
        public string telefone { get; set; }


        [Display(Description = "CEP")]
        public string CEP { get; set; }


        [Display(Description = "Endereço")]
        public string endereco { get; set; }


        [Display(Description = "Número da Casa")]
        public int numeroCasa { get; set; }


        [Display(Description = "Cidade")]
        public string cidade { get; set; }


        [Display(Description = "UF")]
        public string uf { get; set; }

    }
}
