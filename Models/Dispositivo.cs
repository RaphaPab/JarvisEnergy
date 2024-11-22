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


        
        [Column("NR_TEMPERATURA")]
        [Required]
        public string Temperatura { get; set; }


        [Column("NR_CONSUMO_WATTS")]
        [Required]
        
        public float ConsumoWatts { get; set; }


        [Column("NR_CUSTO_CONSUMO")]
        [Required]
        public float CustoConsumo { get; set; }
    }
}