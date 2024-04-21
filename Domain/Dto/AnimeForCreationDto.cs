using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public record AnimeForCreationDto(string Nome, string Diretor, string Resumo)
    {
    }
}
