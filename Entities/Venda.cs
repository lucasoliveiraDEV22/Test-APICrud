using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCrud.Entities
{
    public class Venda
    {
        [Key]
        public int IdVenda { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int IdProduto { get; set; }

        [Required]
        public int QtdVenda { get; set; }

        [Required]
        public float VlrUnitarioVenda { get; set; }

        [Required]
        public DateTime DthVenda { get; set; }

        [NotMapped]
        public float VlrTotalVenda => QtdVenda * VlrUnitarioVenda;

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

        [ForeignKey("IdProduto")]
        public Produto Produto { get; set; }
    }
}
