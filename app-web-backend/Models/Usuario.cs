using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_web_backend.Models {
    [Table("Usuarios")]
    public class Usuario {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo E-mail recebe no máximo 100 caracteres")]
        [EmailAddress(ErrorMessage = "O campo E-mail é inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [MaxLength(100, ErrorMessage = "O campo Senha recebe no máximo 100 caracteres")]
        public string Senha { get; set;}

        [Required(ErrorMessage = "O campo Perfil é obrigatório")]
        public Perfil perfil { get; set; }
    }

    public enum Perfil {
        Admin,
        User
    }
}
