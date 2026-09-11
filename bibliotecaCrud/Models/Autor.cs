using System.ComponentModel.DataAnnotations;

namespace bibliotecaCrud.Models
{
    public class Autor
    {
        [Key]
        public int IdAutor { get; set; }

        [Required(ErrorMessage = "O nome do autor é obrigatório")]
        public string Nome { get; set; }

        public string Nacionalidade { get; set; }
    }
}
