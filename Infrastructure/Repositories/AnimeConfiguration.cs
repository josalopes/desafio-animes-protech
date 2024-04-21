using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Repositories
{
    public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
    {
        public void Configure(EntityTypeBuilder<Anime> builder)
        {
            builder.HasData
            (
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "A Viagem de Chihiro",
                    Resumo = "Considerada por muitos a maior obra de animação de todos os tempos, A Viagem de Chihiro faturou, entre outros prêmios, o Oscar de Melhor Filme de Animação de 2003. A história é focada em Chihiro, uma garota que precisa se virar sozinha a fim de encontrar o caminho de volta para casa num universo fantástico e sombrio. O filme é simplesmente maravilhoso!",
                    Diretor = "Hayao Miyazaki",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Túmulo dos Vagalumes",
                    Resumo = "Túmulo dos Vagalumes se passa em Kobe, no Japão, durante a II Guerra Mundial. A história é centrada nos irmãos Seita e Setsuko, que lutam pela sobrevivência em meio ao horror dos ataques aéreos e à fome.",
                    Diretor = "Isao Takahata",
                    Ativo = true
                }
            );
        }
    }
}
