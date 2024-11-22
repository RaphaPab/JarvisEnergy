using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JarvisEnergy.Models
{


    [Table("TJD_JS_USUARIO")]
    public class Usuario
    {

        [Key]
        [Column("ID_USUARIO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NM_USUARIO")]
        public string NomeUsuario { get; set; }

        [Required]
        [Column("NR_CPF")]
        public string Cpf { get; set; }

        [Required]
        [Column("NR_RG")]
        public string Rg { get; set; }

        [Required]

        [Column("DT_NASCIMENTO")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(150)]
        [Column("CD_SENHA")]
        public string Senha { get; set; }

        
    }
}