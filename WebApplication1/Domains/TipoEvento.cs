using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domains
{
    [Table("TipoEvento")]
    public class TipoEvento
    {   
            [Key]
            public Guid IdTipoEvento { get; set; }

            [Column(TypeName = "VARCHAR(180)")]
            [Required(ErrorMessage = "Determine o tipo do evento que vai ocorrer!")]
        [StringLength(180)]
        public string? TituloTipoEvento { get; set; }
        }
    }


