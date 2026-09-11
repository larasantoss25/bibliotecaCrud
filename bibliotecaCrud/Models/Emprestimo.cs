using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bibliotecaCrud.Models
{
    public class Emprestimo
    {
        [Key]
        public int IdEmprestimo { get; set; }
        public int LivroId { get; set; }

        [ForeignKey("LivroId")]
        public Livro? Livro { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }

        [Display(Name = "Data de Empréstimo")]
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;

        [Display(Name = "Devolução Prevista")]
        public DateTime DataDevolucaoPrevista { get; set; } = DateTime.Now.AddDays(14);

        [Display(Name = "Devolução Real")]
        public DateTime? DataDevolucaoReal { get; set; }

        [Display(Name = "Status Ativo")]
        public bool StatusAtivo { get; set; } = true;

    }
}
