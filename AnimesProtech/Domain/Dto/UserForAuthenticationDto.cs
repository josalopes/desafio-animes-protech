using System.ComponentModel.DataAnnotations;

namespace Domain.Dto
{
    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "A password é obrigatória")]
        public string? Password { get; set; }
    }
}
