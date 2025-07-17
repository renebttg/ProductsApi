using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApi.Models
{
    [Table("produtos")]
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("nome")]
        public String name { get; set; }

        [Required]
        [Column("preco")]
        public Decimal price { get; set; }

        [Column("descricao")]
        public String description { get; set; }

    }
}
