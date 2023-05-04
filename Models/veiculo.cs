using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend_5.Models {

    [Table("Veículos")]
    public class Veiculo {

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Obrigadório informar o <nome>")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Obrigadório informar o <placa>")]
        public int placa { get; set; }
    }
}
