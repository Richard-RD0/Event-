using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domains
{
    [Table("ComentarioEventos")]
    public class ComentarioEvento
    {

        [Key]
        public Guid IdComentarioEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "de uma descrição sobre o evento e OBRIGATORIO!")]
        [StringLength(100)]
        public string? comentarCEvento { get; set; }


        [Column(TypeName = "BOO")]
        [Required(ErrorMessage = "Exibir")]
       
        public string?ExibeCEvento { get; set; }


    }
}
