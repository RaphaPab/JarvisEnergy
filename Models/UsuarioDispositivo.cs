using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JarvisEnergy.Models
{
    [Table("TJD_JS_USUARIO_DISPOSITIVO")]
    public class UsuarioDispositivo
    {
        [Key]
        [Column("ID_USUARIO_DISPOSITIVO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuarioDispositivo { get; set; }

        [Required]
        [Column("ID_USUARIO")]
        public int UsuarioId { get; set; }

        [Required]
        [Column("ID_DISPOSITIVO")]
        public int DispositivoId { get; set; }

        [Column("DT_INICIO")]
        public DateTime DataInicio { get; set; }

        [Column("DT_FIM")]
        public DateTime DataFim { get; set; }

        
    }
}
