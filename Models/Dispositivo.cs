using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JarvisEnergy.Models
{
    [Table("TJD_JS_DISPOSITIVO")]
    public class Dispositivo
    {
        [Key]
        [Column("ID_DISPOSITIVO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDispositivo { get; set; }

        [Required]
        [Column("NM_DISPOSITIVO")]
        [MaxLength(150)]
        public string NomeDispositivo { get; set; }

        [Column("DS_DISPOSITIVO")]
        [MaxLength(200)]
        public string DescricaoDispositivo { get; set; }


        [Column("NR_VOLTAGEM")]
        [MaxLength(100)]
        public string Voltagem { get; set; }

        [Column("DS_STATUS")]
        [MaxLength(100)]
        public string Status { get; set; }

        
        public string Temperatura { get; set; }

        
        
        public string ConsumoWatts { get; set; }


    }
}