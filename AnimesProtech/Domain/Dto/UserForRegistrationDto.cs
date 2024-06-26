﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Dto
{
    public record UserForRegistrationDto
    {
        public string? FirstName { get; set; }
        public string? Lastname { get; set; }
        
        [Required(ErrorMessage = "Username é obrigatório")]
        public string? UserName { get; set; }
        
        [Required(ErrorMessage = "A password é obrigatória")]
        public string? Password { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public ICollection<string>? Roles { get; set;}
    }
}
