namespace Entities.Models.Builders
{
    public class AnimeBuilder
    {
        private readonly Anime _anime;

        public AnimeBuilder(Anime anime)
        {
            _anime = new Anime();
            _anime = anime;
        }
        public AnimeBuilder()
        {
            _anime = new Anime();
            _anime.Ativo = true;
        }
        public void Deactivate()
        {
            _anime.Ativo = false;
        }

        public Anime Build() => _anime;
    }
}
