using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class AnimeNotFoundException : NotFoundException
    {
        public AnimeNotFoundException(Guid animeId) : base($"O Anime com o id: {animeId} não existe  na base de dados.")
        {
        }
    }
}
