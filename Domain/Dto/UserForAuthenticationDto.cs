using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
