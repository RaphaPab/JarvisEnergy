using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JarvisEnergy.Models
{
    [Table("TJD_JS_RELATORIO")]
    public class Relatorio
    {
        [Key]
        [Column("ID_RELATORIO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRelatorio { get; set; }


        [Column("TP_RELATORIO")]
        [MaxLength(100)]
        public string TipoRelatorio { get; set; }

        [Column("NM_RELATORIO")]
        [MaxLength(100)]
        public string NomeRelatorio { get; set; }

        [Column("NR_RELATORIO")]
        [Required]
        public long NumeroRelatorio { get; set; }

        [Column("DS_RELATORIO")]
        [MaxLength(200)]
        public string DescricaoRelatorio { get; set; }


    }

}