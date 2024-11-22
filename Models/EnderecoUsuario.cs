using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JarvisEnergy.Models
{
    [Table("TJD_JS_ENDERECO_USUARIO")]
    public class EnderecoUsuario
    {
        [Key]
        [Column("ID_ENDERECO_CLIENTE")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEndereco { get; set; }

        [Required]
        [Column("ID_USUARIO")]
        public int UsuarioId { get; set; }

        [Column("NM_RUA")]
        [MaxLength(50)]
        public string Rua { get; set; }

        [Column("NR_RESIDENCIA")]
        [MaxLength(50)]
        public string Residencia { get; set; }
        
        [Column("NM_BAIRRO")]
        [MaxLength(30)]
        public string Bairro { get; set; }

       
    }
}
