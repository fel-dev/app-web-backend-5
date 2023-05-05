using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models {
    [Table("Consumo")]
    public class Consumo {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório Informar a descrição!")]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public int Km { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
    }
}
