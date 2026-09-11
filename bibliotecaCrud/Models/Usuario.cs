using System.ComponentModel.DataAnnotations;

namespace bibliotecaCrud.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
