using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domains
{
    public class TipoUsuario
    {
       
            [Key]
            public Guid IdTipoUsuario { get; set; }

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "o tipo do Usuario e OBRIGATORIO!")]
        [StringLength(100)]
        
        public string? TituloTipoUsuario { get; set; }
        }
}
