using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domains
{
    public class Usuario;
    
        namespace Event.Domains
    {

        public class Usuario
        {
            [Key]
            public Guid IdUsuario { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "O nome é obrigatório")]
            [StringLength(50)]
            public string? NomeUsuario { get; set; }

            [Column(TypeName = "VARCHAR(50)")]
            [Required(ErrorMessage = "O email é obrigatório")]
            [StringLength(50)]
            public string? EmailUsuario { get; set; }

            [Column(TypeName = "VARCHAR(60)")]
            [Required(ErrorMessage = "A senha é obrigatório")]
            [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve conter no mínimo de 6 caracteres e no máximo 60")]
            public string? SenhaUsuario { get; set; }

            [Required(ErrorMessage = "o tipo do usuario e obrigatorio")]

            public Guid idTipoUsuario { get; set; }

            [ForeignKey("idTipoUsuario")]

            public TipoUsuario? TipoUsuario { get; set; }

        }
    }
}


