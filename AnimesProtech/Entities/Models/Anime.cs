using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Anime
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo para o nome é 50 caracteres")]
        public string? Nome { get; set; }
        
        [Required(ErrorMessage = "O nome do diretor é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo para este campo é 50 caracteres")]
        public string? Diretor { get; set; }

        [Required(ErrorMessage = "O resumo do filme é obrigatório")]
        [MaxLength(200, ErrorMessage = "O tamanho máximo para o resumo é 200 caracteres")] 
        public string? Resumo { get; set; }
        public bool Ativo { get; set; }
    }
}
