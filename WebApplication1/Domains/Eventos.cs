using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domains
{
    public class Eventos
    {
        [Key]
        public Guid IdEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        [StringLength(50)]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "DATETIME(8)")]
        [Required(ErrorMessage = "A data do evento é obrigatório")]
        [StringLength(8)]
        public string? DataEvento { get; set; }

        [Column(TypeName = "DATETIME(60)")]
        [Required(ErrorMessage = "A hora do evento é obrigatório")]
        [StringLength(60)]

        public string? HoraEvento { get; set; }

     
    }
}
