namespace Entities.Exceptions
{
    public sealed class AnimeNotFoundException : NotFoundException
    {
        public AnimeNotFoundException(Guid animeId) : base($"O Anime com o id: {animeId} não existe  na base de dados.")
        {
        }
    }
}
