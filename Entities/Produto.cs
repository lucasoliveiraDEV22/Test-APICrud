using System.ComponentModel.DataAnnotations;

namespace ApiCrud.Entities
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required]
        [StringLength(200)]
        public string DscProduto { get; set; }

        [Required]
        public float VlrUnitario { get; set; }
    }
}



