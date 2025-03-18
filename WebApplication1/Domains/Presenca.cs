using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domains
{
    [Table("Presenca")]
    public class Presenca
    {

        [Key]
        public Guid IdPresenca { get; set; }

        [Column(TypeName = "BOO")]
        [Required(ErrorMessage = " Falar sobre a siatuação e OBRIGATORIO!")]
        public string? situacaoPresenca { get; set; }
    }
}
