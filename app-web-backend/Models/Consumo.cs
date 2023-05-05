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

        [Required(ErrorMessage = "Obrigatório Informar a data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o KM!")]
        public int Km { get; set; }
               
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Obrigatório Informar o valor!")]
        public decimal Valor { get; set; }

        [Display(Name = "Tipo de Combustível")]
        [Required(ErrorMessage = "Obrigatório Informar o tipo de combustível!")]
        public TipoCombustivel Tipo { get; set; }

        //-- FK - Relacionamento com a tabela Veiculo
        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório Informar o veículo!")]
        public int VeiculoId { get; set; }  // 1º cria a propriedade
        [ForeignKey("VeiculoId")]           // 2º cria a FK
        public Veiculo Veiculo { get; set; } // 3º cria a propriedade

    }

    public enum TipoCombustivel {
        Gasolina = 1,
        Alcool = 2,
        Diesel = 3,
        GNV = 4
    }
}
