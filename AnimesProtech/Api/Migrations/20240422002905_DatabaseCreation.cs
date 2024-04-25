using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Diretor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Resumo = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "Id", "Ativo", "Diretor", "Nome", "Resumo" },
                values: new object[,]
                {
                    { new Guid("041c45a1-bd47-4c92-b76d-a7e0a2b310bf"), true, "Xuan Liang, Chun Zhang", "Big Fish& Begonia", "Shun vive numa espécie de realidade paralela, habitada por criaturas míticas. Quando completa 16 anos, ela ganha o passaporte para a nossa realidade, vindo sob a forma de um golfinho. Quando está voltando para seu mundo, Shun é surpreendida por uma rede e é salva pelo humano Kun, que acaba morrendo afogado. Inconformada, Shun quer trazer seu salvador de volta à vida." },
                    { new Guid("48f30424-b631-4247-b217-d0177d90b959"), true, "Isao Takahata", "Túmulo dos Vagalumes", "Túmulo dos Vagalumes se passa em Kobe, no Japão, durante a II Guerra Mundial. A história é centrada nos irmãos Seita e Setsuko, que lutam pela sobrevivência em meio ao horror dos ataques aéreos e à fome." },
                    { new Guid("49802e17-11be-43ac-8005-bedda3d6e64e"), true, "Goro Miyazaki", "Da Colina Kokuriko", "O pai de Umi desapareceu em alto-mar. Desde então, ela abre bandeiras no quintal de sua casa, que fica no alto de uma colina, para enviar sinais ao mar. Devido a esse hábito, ela se aproxima de Shun, um garoto que trabalha no clube de jornalismo da escola. A descoberta de um segredo vem mudar completamente a relação entre eles." },
                    { new Guid("4a3bdd62-8063-4f4a-ae80-6a1c0b77b224"), true, "Hayao Miyazaki", "Meu Amigo Totoro", "Uma família se muda para uma casa no campo, com um enorme e misterioso jardim. A casa fica próxima ao hospital onde a mãe de Mei e Satsuki está internada. Certo dia, explorando o vasto jardim da casa, a pequena Mei conhece o incrível monstro Totoro." },
                    { new Guid("4dcd1f57-d3b1-44e4-9bf2-4221e0b6086c"), true, "Mamoru Oshii", "O Fantasma do Futuro", "Se Akira se passa em 2019, O Fantasma do Futuro foi um pouco mais adiante: 2029. Neste futuro não tão distante, pessoas são capazes de usar seu ciber-cérebros para acessar redes virtuais de informações. É nesse contexto que a agente Motoko precisa conter um hacker que invade o ciber-cérebro das pessoas." },
                    { new Guid("4e5d33fa-e8e9-46f1-92ef-bade4c1dde56"), true, "Katsuhiro Otomo", "Akira", "Akira é um clássico da animação, tendo influenciado outras produções posteriores do gênero ficção científica. A história se passa numa Tóquio do futuro, completamente destruída por uma explosão que marcou o início da III Guerra Mundial. O ano? 2019. O protagonista é Kaneda, líder de uma gangue de motoqueiros." },
                    { new Guid("54b4bf2b-a031-4e67-ba39-de215581401a"), true, "Hayao Miyazaki", "O Castelo Animado", "Do mesmo Diretor de A Viagem de Chihiro, este anime conta a dramática história de Sofia, uma adolescente que, devido a uma maldição, é condenada a ter 90 anos. Resta à Sofia partir numa jornada em busca do Castelo Animado do feiticeiro Hauru, que talvez possa ajudá-la." },
                    { new Guid("5b8ba76a-7570-424a-8555-84429d025892"), true, "Hiromasa Yonebayashi", "As Memórias de Marnie", "Indicada ao Oscar de Melhor Animação, esta animação japonesa narra a história de Anna, uma garota de 12 anos que, além de sofrer de asma, é bastante solitária. Enviada por seus tutores à casa dos tios no litoral, ela se torna amiga de Marnie, uma menina que vive numa mansão misteriosa." },
                    { new Guid("61546241-2b2a-4658-af9f-2b39c59fa1ae"), true, "Naoko Yamada", "A Voz do Silêncio", "A jovem Shouko Nishimiya é deficiente auditiva e só consegue se comunicar através da língua dos sinais. Em sua nova escola, começa a ser perseguida e sofrer bullying de Ishida, um garoto verdadeiramente sem limites." },
                    { new Guid("62955af9-ee1b-4a51-8b4f-ea13dc99f803"), true, "Makoto Shinkai", "Kimi No Na Wa", "Vencedor de vários prêmios, dentre os quais o Japan Awards, Your Name conta a história de Mitsuha, uma garota que vive no campo e deseja conhecer Tóquio, e Taki, um garoto qu vive na capital. Certo dia, Mitsuha leva seu desejo a um templo religioso. E é atendida. Ela acorda no corpo de Taki, e ele no corpo dela!" },
                    { new Guid("67b27b01-2de0-4ad6-8b02-b8fae9a963b6"), true, "Isao Takahata", "O Conto da Princesa Kaguya", "Encontrada por um camponês dentro de um tronco mágico de bambu, a menina Kaguya logo é chamada de princesa por seus pais. Tempos depois, no mesmo bosque, o camponês encontra uma enorme quantidade de ouro. E a menina nascida do bambu se torna de fato uma princesa." },
                    { new Guid("7caa448c-486b-4918-b836-2d24e3a6e6c9"), true, "Mamoru Hosoda", "A Garota que Conquistou o Tempo", "Quem não curte uma história de viagem no tempo? Em A Garota que Conquistou o Tempo, assistimos ao dia a dia meio atrapalhado de uma estudante de Ensino Médio que, certo dia, após passar por uma experiência trágica, decobre que tem a capacidade de manipular o tempo." },
                    { new Guid("7ff12675-3a07-4749-a1e6-4b762cb25a69"), true, "Tatsuya Nagamine", "Dragon Ball Super: Broly", "Goku mantém-se em treinamento, apesar de se viver um clima de paz e tranquilidade. Ele parece adivinhar que o guerreiro Broly, o mais cruel e agressivo saiyajin, está de volta. Será que Goku e Vegeta serão capazes de derrotar esse vilão?" },
                    { new Guid("a192e392-5d0f-41da-90ef-133160c8a3f2"), true, "Makoto Shinkai", "Cinco Centímetros por Segundo", "Uma frase para introduzir este longa de animação: uma belíssima e comovente história de amor. Cinco Centímetros por Segundo, acompanhamos a relação de Takaki e Akari, dois jovens super grudados que são obrigados a viver distantes um do outro devido às circunstâncias da vida." },
                    { new Guid("a8d477d6-8c0a-4aa7-8a8c-1712894e05fa"), true, "Hayao Miyazaki", "Vidas ao Vento", "Mais uma maravilha do Estúdio Ghibli está disponível na Netflix. Desta vez, a história do engenheiro aeronáutico japonês Jiro Horikoshi (1903-1982). O filme explora sua relação com Naoko e seu trabalho como projetista de aviões durante o período histórico mais turbulento do século XX." },
                    { new Guid("b2390479-469b-4a62-bb23-1acbe2677200"), true, "Makoto Shinkai", "O Jardim das Palavras", "Durante a estação chuvosa em Tóquio, Takao Akizuki e Yukari Yukino se encontram no jardim de Shinjuku Gyoen. Ele, que sonha em se tornar designer de sapatos, vai lá para cabular aulas. Ela encontra no jardim um refúgio para seus problemas pessoais e profissionais." },
                    { new Guid("b447452f-b1d4-47fa-89be-e5ab1475dc30"), true, "Hayao Miyazaki", "Ponyo: Uma Amizade que Veio do Mar", "Aclamado pela crítica e adorado pelo público, Ponyo: Uma Amizade que Veio do Mar é uma das produções mais famosas do Estúdio Ghibli. O filme narra a belíssima história do menino Sosuke e Ponyo, um peixinho dourado que Sosuke salva à beira-mar. Absolutamente fantástico!" },
                    { new Guid("bb17fabf-699b-46d5-9e4a-2429f1d86f42"), true, "Junichi Satô, Tomotaka Shibayama", "Olhos de Gato", "Embarque em uma encantadora jornada de anime com 'Olhos de Gato', um novo conto de fadas que promete cativar corações. Miyo, uma apaixonada adolescente, encontra-se envolvida em uma trama mágica quando uma misteriosa máscara adquirida em um festival de inverno a transforma em uma adorável gatinha branca. Enquanto desenrola-se a história romântica com seu colega Hinode, o filme também abraça temas delicados como bullying, pressões familiares e a dor da perda. Prepare-se para uma experiência cinematográfica que transcende os limites do amor, explorando as complexidades da vida e oferecendo um vislumbre encantador do extraordinário." },
                    { new Guid("bef82b30-7327-49e1-853a-09bb1c99e9da"), true, "Satoshi Kon", "Paprika", "Na realidade futurista de Paprika, os sonhos podem ser vistos por outras pessoas. Isso mesmo! Um programa desenvolvido por um centro de pesquisas permite que seu usuário tenha acesso ao material onírico de qualquer paciente. O conflito se instaura quando a chefe desse centro de pesquisas começa a usar esse dispositivo de forma clandestina." },
                    { new Guid("bf7cf95c-aa4d-41fc-ba53-5d15f4b6112f"), true, "Mamoru Hosoda", "Crianças Lobo", "Vencedor do Japan Academy Prize de 2013, Crianças Lobo traz às telas um romance entre uma garota e um lobisomem. Após o nascimento do segundo filho, o lobisomem morre, deixando à mãe a difícil tarefa de criar dois filhos que possuem a mesma condição do pai." },
                    { new Guid("c44c7676-536f-4779-8eb8-257829d303ee"), true, "Tatsuyuki Nagai", "O Hino do Coração", "A pequena Jun Naruse sonha em se tornar uma princesa. Certo dia, ela vê seu pai saindo de um castelo ao lado de uma mulher. Empolgada, ela conta tudo o que viu em casa, desencadeando grandes conflitos familiares. Sentindo-se culpada, ela encontra um ovo mágico, que tem o poder de selar suas palavras." },
                    { new Guid("d1b2b8ad-1160-48e0-aa26-e436b6537fb2"), true, "Hayao Miyazaki", "A Viagem de Chihiro", "Considerada por muitos a maior obra de animação de todos os tempos, A Viagem de Chihiro faturou, entre outros prêmios, o Oscar de Melhor Filme de Animação de 2003. A história é focada em Chihiro, uma garota que precisa se virar sozinha a fim de encontrar o caminho de volta para casa num universo fantástico e sombrio. O filme é simplesmente maravilhoso!" },
                    { new Guid("f06f5374-2a7d-42ba-9644-0e31bcf06cf6"), true, "Hayao Miyazaki", "Princesa Mononoke", "Outra obra-prima do Studio Ghibli e do Diretor Hayao Miyazaki (o mesmo de A Viagem de Chihiro), Princesa Mononoke narra a história de um príncipe que, assombrado por uma maldição, resolve deixar seu povo e procurar cura em outro lugar. No oeste, em meio a uma batalha, conhece San, uma garota que vive entre os deuses-lobo." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animes");
        }
    }
}
