using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bibliotecaCrud.Models
{
    public class Livro
    {
        [Key]
        public int IdLivro { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }

        public int AutorId { get; set; }

        [ForeignKey("AutorId")]
        public Autor? Autor { get; set; }
    }
}
