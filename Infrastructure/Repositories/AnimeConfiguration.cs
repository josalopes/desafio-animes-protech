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
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Kimi No Na Wa",
                    Resumo = "Vencedor de vários prêmios, dentre os quais o Japan Awards, Your Name conta a história de Mitsuha, uma garota que vive no campo e deseja conhecer Tóquio, e Taki, um garoto qu vive na capital. Certo dia, Mitsuha leva seu desejo a um templo religioso. E é atendida. Ela acorda no corpo de Taki, e ele no corpo dela!",
                    Diretor = "Makoto Shinkai",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Olhos de Gato",
                    Resumo = "Embarque em uma encantadora jornada de anime com 'Olhos de Gato', um novo conto de fadas que promete cativar corações. Miyo, uma apaixonada adolescente, encontra-se envolvida em uma trama mágica quando uma misteriosa máscara adquirida em um festival de inverno a transforma em uma adorável gatinha branca. Enquanto desenrola-se a história romântica com seu colega Hinode, o filme também abraça temas delicados como bullying, pressões familiares e a dor da perda. Prepare-se para uma experiência cinematográfica que transcende os limites do amor, explorando as complexidades da vida e oferecendo um vislumbre encantador do extraordinário.",
                    Diretor = "Junichi Satô, Tomotaka Shibayama",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Princesa Mononoke",
                    Resumo = "Outra obra-prima do Studio Ghibli e do Diretor Hayao Miyazaki (o mesmo de A Viagem de Chihiro), Princesa Mononoke narra a história de um príncipe que, assombrado por uma maldição, resolve deixar seu povo e procurar cura em outro lugar. No oeste, em meio a uma batalha, conhece San, uma garota que vive entre os deuses-lobo.",
                    Diretor = "Hayao Miyazaki",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Meu Amigo Totoro",
                    Resumo = "Uma família se muda para uma casa no campo, com um enorme e misterioso jardim. A casa fica próxima ao hospital onde a mãe de Mei e Satsuki está internada. Certo dia, explorando o vasto jardim da casa, a pequena Mei conhece o incrível monstro Totoro.",
                    Diretor = "Hayao Miyazaki",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "A Voz do Silêncio",
                    Resumo = "A jovem Shouko Nishimiya é deficiente auditiva e só consegue se comunicar através da língua dos sinais. Em sua nova escola, começa a ser perseguida e sofrer bullying de Ishida, um garoto verdadeiramente sem limites.",
                    Diretor = "Naoko Yamada",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "O Castelo Animado",
                    Resumo = "Do mesmo Diretor de A Viagem de Chihiro, este anime conta a dramática história de Sofia, uma adolescente que, devido a uma maldição, é condenada a ter 90 anos. Resta à Sofia partir numa jornada em busca do Castelo Animado do feiticeiro Hauru, que talvez possa ajudá-la.",
                    Diretor = "Hayao Miyazaki",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Crianças Lobo",
                    Resumo = "Vencedor do Japan Academy Prize de 2013, Crianças Lobo traz às telas um romance entre uma garota e um lobisomem. Após o nascimento do segundo filho, o lobisomem morre, deixando à mãe a difícil tarefa de criar dois filhos que possuem a mesma condição do pai.",
                    Diretor = "Mamoru Hosoda",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "O Conto da Princesa Kaguya",
                    Resumo = "Encontrada por um camponês dentro de um tronco mágico de bambu, a menina Kaguya logo é chamada de princesa por seus pais. Tempos depois, no mesmo bosque, o camponês encontra uma enorme quantidade de ouro. E a menina nascida do bambu se torna de fato uma princesa.",
                    Diretor = "Isao Takahata",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "O Fantasma do Futuro",
                    Resumo = "Se Akira se passa em 2019, O Fantasma do Futuro foi um pouco mais adiante: 2029. Neste futuro não tão distante, pessoas são capazes de usar seu ciber-cérebros para acessar redes virtuais de informações. É nesse contexto que a agente Motoko precisa conter um hacker que invade o ciber-cérebro das pessoas.",
                    Diretor = "Mamoru Oshii",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Akira",
                    Resumo = "Akira é um clássico da animação, tendo influenciado outras produções posteriores do gênero ficção científica. A história se passa numa Tóquio do futuro, completamente destruída por uma explosão que marcou o início da III Guerra Mundial. O ano? 2019. O protagonista é Kaneda, líder de uma gangue de motoqueiros.",
                    Diretor = "Katsuhiro Otomo",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Dragon Ball Super: Broly",
                    Resumo = "Goku mantém-se em treinamento, apesar de se viver um clima de paz e tranquilidade. Ele parece adivinhar que o guerreiro Broly, o mais cruel e agressivo saiyajin, está de volta. Será que Goku e Vegeta serão capazes de derrotar esse vilão?",
                    Diretor = "Tatsuya Nagamine",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "A Garota que Conquistou o Tempo",
                    Resumo = "Quem não curte uma história de viagem no tempo? Em A Garota que Conquistou o Tempo, assistimos ao dia a dia meio atrapalhado de uma estudante de Ensino Médio que, certo dia, após passar por uma experiência trágica, decobre que tem a capacidade de manipular o tempo.",
                    Diretor = "Mamoru Hosoda",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Vidas ao Vento",
                    Resumo = "Mais uma maravilha do Estúdio Ghibli está disponível na Netflix. Desta vez, a história do engenheiro aeronáutico japonês Jiro Horikoshi (1903-1982). O filme explora sua relação com Naoko e seu trabalho como projetista de aviões durante o período histórico mais turbulento do século XX.",
                    Diretor = "Hayao Miyazaki",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "As Memórias de Marnie",
                    Resumo = "Indicada ao Oscar de Melhor Animação, esta animação japonesa narra a história de Anna, uma garota de 12 anos que, além de sofrer de asma, é bastante solitária. Enviada por seus tutores à casa dos tios no litoral, ela se torna amiga de Marnie, uma menina que vive numa mansão misteriosa.",
                    Diretor = "Hiromasa Yonebayashi",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Ponyo: Uma Amizade que Veio do Mar",
                    Resumo = "Aclamado pela crítica e adorado pelo público, Ponyo: Uma Amizade que Veio do Mar é uma das produções mais famosas do Estúdio Ghibli. O filme narra a belíssima história do menino Sosuke e Ponyo, um peixinho dourado que Sosuke salva à beira-mar. Absolutamente fantástico!",
                    Diretor = "Hayao Miyazaki",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Paprika",
                    Resumo = "Na realidade futurista de Paprika, os sonhos podem ser vistos por outras pessoas. Isso mesmo! Um programa desenvolvido por um centro de pesquisas permite que seu usuário tenha acesso ao material onírico de qualquer paciente. O conflito se instaura quando a chefe desse centro de pesquisas começa a usar esse dispositivo de forma clandestina.",
                    Diretor = "Satoshi Kon",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Cinco Centímetros por Segundo",
                    Resumo = "Uma frase para introduzir este longa de animação: uma belíssima e comovente história de amor. Cinco Centímetros por Segundo, acompanhamos a relação de Takaki e Akari, dois jovens super grudados que são obrigados a viver distantes um do outro devido às circunstâncias da vida.",
                    Diretor = "Makoto Shinkai",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "O Jardim das Palavras",
                    Resumo = "Durante a estação chuvosa em Tóquio, Takao Akizuki e Yukari Yukino se encontram no jardim de Shinjuku Gyoen. Ele, que sonha em se tornar designer de sapatos, vai lá para cabular aulas. Ela encontra no jardim um refúgio para seus problemas pessoais e profissionais.",
                    Diretor = "Makoto Shinkai",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "O Hino do Coração",
                    Resumo = "A pequena Jun Naruse sonha em se tornar uma princesa. Certo dia, ela vê seu pai saindo de um castelo ao lado de uma mulher. Empolgada, ela conta tudo o que viu em casa, desencadeando grandes conflitos familiares. Sentindo-se culpada, ela encontra um ovo mágico, que tem o poder de selar suas palavras.",
                    Diretor = "Tatsuyuki Nagai",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Da Colina Kokuriko",
                    Resumo = "O pai de Umi desapareceu em alto-mar. Desde então, ela abre bandeiras no quintal de sua casa, que fica no alto de uma colina, para enviar sinais ao mar. Devido a esse hábito, ela se aproxima de Shun, um garoto que trabalha no clube de jornalismo da escola. A descoberta de um segredo vem mudar completamente a relação entre eles.",
                    Diretor = "Goro Miyazaki",
                    Ativo = true
                },
                new Anime
                {
                    Id = new Guid(Guid.NewGuid().ToString()),
                    Nome = "Big Fish& Begonia",
                    Resumo = "Shun vive numa espécie de realidade paralela, habitada por criaturas míticas. Quando completa 16 anos, ela ganha o passaporte para a nossa realidade, vindo sob a forma de um golfinho. Quando está voltando para seu mundo, Shun é surpreendida por uma rede e é salva pelo humano Kun, que acaba morrendo afogado. Inconformada, Shun quer trazer seu salvador de volta à vida.",
                    Diretor = "Xuan Liang, Chun Zhang",
                    Ativo = true
                }
            );
        }
    }
}
