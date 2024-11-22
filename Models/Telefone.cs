using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JarvisEnergy.Models
{
    [Table("TJD_JS_TELEFONE")]
    public class Telefone
    {
        [Key]
        [Column("ID_TELEFONE")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTelefone { get; set; }

        [Required]
        [Column("ID_USUARIO")]
        public int UsuarioId { get; set; }

        [Required]
        [Column("NR_TELEFONE")]
        public long NumeroTelefone { get; set; }

        [Required]
        [Column("NR_DDD")]
        public int Ddd { get; set; }

        [MaxLength(50)]
        [Column("DS_TELEFONE")]
        public string Descricao { get; set; }

        
    }
}
