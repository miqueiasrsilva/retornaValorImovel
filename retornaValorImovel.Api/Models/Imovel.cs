using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace retornaValorImovel.Models
{
    public class Imovel
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(10, 10000, ErrorMessage = "A quantidade de metros quadrados deve estar entre 10 e 10.000")]
        public decimal qtdeM2 { get; set; }

        [HiddenInput(DisplayValue = false)]
        public decimal valorM2 { get; set; }

        public decimal valorTotal
        {
            get
            {
                return qtdeM2 * valorM2;
            }
        }

    }
}