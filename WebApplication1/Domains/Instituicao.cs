using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Domains
{
        [Table("Instituto")]
        [Index(nameof(CNPJ), IsUnique = true)]
    public class Instituicao
    {

        [Key]
        public Guid IdIntituicao { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        [Required(ErrorMessage = "O CNPJ é obrigatório")]
        [StringLength(20)]
        public string? CNPJ { get; set; }

        [Column(TypeName = "VARCHAR(90)")]
        [Required(ErrorMessage = "O nome fantasia é obrigatório")]
        [StringLength(90)]

        public string? NFantasiaInstituicao { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = " O endereço é obrigatório")]
        [StringLength(60)]
        public string? EndereçoIntituicao { get; set; }
    }
}

