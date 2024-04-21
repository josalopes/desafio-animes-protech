using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class AnimeDto
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Diretor { get; set; }
        public string? Resumo { get; set; }  
    }
}
