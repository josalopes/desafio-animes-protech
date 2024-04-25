using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("0c56e9a4-b2ca-494f-b516-2324358b4a46"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("22417f7f-3bf4-4fd8-8cd7-63c879502589"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("25bf7ae6-5280-4637-b93a-d4bc44f1f6f0"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("329db3a4-2768-4ff8-aabd-4534098f2931"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("394d76ab-76c0-45c4-9662-4533130f45d1"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("3ae71b3e-c737-409b-a7e8-e939fd8336e2"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("4b139d08-3763-4b1e-8322-f8fbffbf8636"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("4b733caf-48bb-4e91-ad7b-82841b3fc9d9"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("6b6babc7-93ce-4eff-b4d5-2d0339fe24de"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("85b86cd7-61ac-469d-b330-0dabd0ed7c95"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("918ff2ba-d032-44cf-a8e8-e9952337f529"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("9280d4f9-04e6-4e93-9f7f-a685ecaa1f15"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("93caf2b3-2f81-4af8-9434-d76faf4a2b44"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("ac7feddc-55cb-4c81-a072-beade57302db"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("acd759be-2280-45a1-8c17-47325bc52478"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("acdee384-ddfd-4cae-ad35-b6545ff2b787"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("b4e485d9-8da0-445c-8120-3eaacee8c479"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("b56bd4e0-f201-4bc5-89f1-e2e580bce8e3"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("d138c3c4-c66a-43a2-b1aa-24ce3685ccfc"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("d15f4bef-2f95-4ca8-a31b-a4668be4d2a1"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("d49256d1-0e7c-4d97-a19e-4536ceb3d7d0"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("d990ca22-cca9-425d-a421-89e05e8cf9ce"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("ebd578fc-6d1b-4c7a-ae0c-dda464b87ce5"));

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "Id", "Ativo", "Diretor", "Nome", "Resumo" },
                values: new object[,]
                {
                    { new Guid("0417e93c-ae97-4138-9065-6ead76fd1d74"), true, "Makoto Shinkai", "O Jardim das Palavras", "Durante a estação chuvosa em Tóquio, Takao Akizuki e Yukari Yukino se encontram no jardim de Shinjuku Gyoen. Ele, que sonha em se tornar designer de sapatos, vai lá para cabular aulas. Ela encontra no jardim um refúgio para seus problemas pessoais e profissionais." },
                    { new Guid("04aed267-c000-4a34-a52c-9bf280ecfae4"), true, "Junichi Satô, Tomotaka Shibayama", "Olhos de Gato", "Embarque em uma encantadora jornada de anime com 'Olhos de Gato', um novo conto de fadas que promete cativar corações. Miyo, uma apaixonada adolescente, encontra-se envolvida em uma trama mágica quando uma misteriosa máscara adquirida em um festival de inverno a transforma em uma adorável gatinha branca. Enquanto desenrola-se a história romântica com seu colega Hinode, o filme também abraça temas delicados como bullying, pressões familiares e a dor da perda. Prepare-se para uma experiência cinematográfica que transcende os limites do amor, explorando as complexidades da vida e oferecendo um vislumbre encantador do extraordinário." },
                    { new Guid("05aaaed7-cb30-4143-b3bc-c779dd155cb6"), true, "Makoto Shinkai", "Kimi No Na Wa", "Vencedor de vários prêmios, dentre os quais o Japan Awards, Your Name conta a história de Mitsuha, uma garota que vive no campo e deseja conhecer Tóquio, e Taki, um garoto qu vive na capital. Certo dia, Mitsuha leva seu desejo a um templo religioso. E é atendida. Ela acorda no corpo de Taki, e ele no corpo dela!" },
                    { new Guid("0f2249b6-c358-4000-9a37-a5bafde8d662"), true, "Hiromasa Yonebayashi", "As Memórias de Marnie", "Indicada ao Oscar de Melhor Animação, esta animação japonesa narra a história de Anna, uma garota de 12 anos que, além de sofrer de asma, é bastante solitária. Enviada por seus tutores à casa dos tios no litoral, ela se torna amiga de Marnie, uma menina que vive numa mansão misteriosa." },
                    { new Guid("19a0ff9a-5001-407f-89c6-d8bc2da18667"), true, "Hayao Miyazaki", "A Viagem de Chihiro", "Considerada por muitos a maior obra de animação de todos os tempos, A Viagem de Chihiro faturou, entre outros prêmios, o Oscar de Melhor Filme de Animação de 2003. A história é focada em Chihiro, uma garota que precisa se virar sozinha a fim de encontrar o caminho de volta para casa num universo fantástico e sombrio. O filme é simplesmente maravilhoso!" },
                    { new Guid("1ba443c6-92bc-4760-b439-71a637e6cfec"), true, "Tatsuya Nagamine", "Dragon Ball Super: Broly", "Goku mantém-se em treinamento, apesar de se viver um clima de paz e tranquilidade. Ele parece adivinhar que o guerreiro Broly, o mais cruel e agressivo saiyajin, está de volta. Será que Goku e Vegeta serão capazes de derrotar esse vilão?" },
                    { new Guid("447bd4ee-4d20-4ae5-bc48-3509b0a46689"), true, "Isao Takahata", "Túmulo dos Vagalumes", "Túmulo dos Vagalumes se passa em Kobe, no Japão, durante a II Guerra Mundial. A história é centrada nos irmãos Seita e Setsuko, que lutam pela sobrevivência em meio ao horror dos ataques aéreos e à fome." },
                    { new Guid("53eb4736-e479-49ef-9f4c-a784b92a10dd"), true, "Katsuhiro Otomo", "Akira", "Akira é um clássico da animação, tendo influenciado outras produções posteriores do gênero ficção científica. A história se passa numa Tóquio do futuro, completamente destruída por uma explosão que marcou o início da III Guerra Mundial. O ano? 2019. O protagonista é Kaneda, líder de uma gangue de motoqueiros." },
                    { new Guid("615e640c-eb6d-4df1-8f29-39d4f2e2d5b9"), true, "Makoto Shinkai", "Cinco Centímetros por Segundo", "Uma frase para introduzir este longa de animação: uma belíssima e comovente história de amor. Cinco Centímetros por Segundo, acompanhamos a relação de Takaki e Akari, dois jovens super grudados que são obrigados a viver distantes um do outro devido às circunstâncias da vida." },
                    { new Guid("7f549875-2508-4ff7-ae28-fe84e646086d"), true, "Xuan Liang, Chun Zhang", "Big Fish& Begonia", "Shun vive numa espécie de realidade paralela, habitada por criaturas míticas. Quando completa 16 anos, ela ganha o passaporte para a nossa realidade, vindo sob a forma de um golfinho. Quando está voltando para seu mundo, Shun é surpreendida por uma rede e é salva pelo humano Kun, que acaba morrendo afogado. Inconformada, Shun quer trazer seu salvador de volta à vida." },
                    { new Guid("802f6c7d-8c18-432f-a477-f7f506097719"), true, "Naoko Yamada", "A Voz do Silêncio", "A jovem Shouko Nishimiya é deficiente auditiva e só consegue se comunicar através da língua dos sinais. Em sua nova escola, começa a ser perseguida e sofrer bullying de Ishida, um garoto verdadeiramente sem limites." },
                    { new Guid("938e10aa-3f6f-43c3-a261-b33e00f20554"), true, "Goro Miyazaki", "Da Colina Kokuriko", "O pai de Umi desapareceu em alto-mar. Desde então, ela abre bandeiras no quintal de sua casa, que fica no alto de uma colina, para enviar sinais ao mar. Devido a esse hábito, ela se aproxima de Shun, um garoto que trabalha no clube de jornalismo da escola. A descoberta de um segredo vem mudar completamente a relação entre eles." },
                    { new Guid("95950f33-c2ac-4748-bfa4-0be29f9bae47"), true, "Mamoru Oshii", "O Fantasma do Futuro", "Se Akira se passa em 2019, O Fantasma do Futuro foi um pouco mais adiante: 2029. Neste futuro não tão distante, pessoas são capazes de usar seu ciber-cérebros para acessar redes virtuais de informações. É nesse contexto que a agente Motoko precisa conter um hacker que invade o ciber-cérebro das pessoas." },
                    { new Guid("bb1eeda7-f245-40e5-bb6f-402665f9eba0"), true, "Hayao Miyazaki", "Princesa Mononoke", "Outra obra-prima do Studio Ghibli e do Diretor Hayao Miyazaki (o mesmo de A Viagem de Chihiro), Princesa Mononoke narra a história de um príncipe que, assombrado por uma maldição, resolve deixar seu povo e procurar cura em outro lugar. No oeste, em meio a uma batalha, conhece San, uma garota que vive entre os deuses-lobo." },
                    { new Guid("c0eeae73-12c1-44e8-89d0-bf7cd563606c"), true, "Hayao Miyazaki", "Vidas ao Vento", "Mais uma maravilha do Estúdio Ghibli está disponível na Netflix. Desta vez, a história do engenheiro aeronáutico japonês Jiro Horikoshi (1903-1982). O filme explora sua relação com Naoko e seu trabalho como projetista de aviões durante o período histórico mais turbulento do século XX." },
                    { new Guid("c61e8819-0743-4797-b519-963f392a1e03"), true, "Mamoru Hosoda", "A Garota que Conquistou o Tempo", "Quem não curte uma história de viagem no tempo? Em A Garota que Conquistou o Tempo, assistimos ao dia a dia meio atrapalhado de uma estudante de Ensino Médio que, certo dia, após passar por uma experiência trágica, decobre que tem a capacidade de manipular o tempo." },
                    { new Guid("d31a32a6-9178-4ec2-98c4-978c33b9bf48"), true, "Hayao Miyazaki", "Ponyo: Uma Amizade que Veio do Mar", "Aclamado pela crítica e adorado pelo público, Ponyo: Uma Amizade que Veio do Mar é uma das produções mais famosas do Estúdio Ghibli. O filme narra a belíssima história do menino Sosuke e Ponyo, um peixinho dourado que Sosuke salva à beira-mar. Absolutamente fantástico!" },
                    { new Guid("db77e8c1-5ff8-4dc3-92c7-6b4c8341bae2"), true, "Isao Takahata", "O Conto da Princesa Kaguya", "Encontrada por um camponês dentro de um tronco mágico de bambu, a menina Kaguya logo é chamada de princesa por seus pais. Tempos depois, no mesmo bosque, o camponês encontra uma enorme quantidade de ouro. E a menina nascida do bambu se torna de fato uma princesa." },
                    { new Guid("e7a6bb90-c3ad-47af-bcbc-6edb70f161cd"), true, "Tatsuyuki Nagai", "O Hino do Coração", "A pequena Jun Naruse sonha em se tornar uma princesa. Certo dia, ela vê seu pai saindo de um castelo ao lado de uma mulher. Empolgada, ela conta tudo o que viu em casa, desencadeando grandes conflitos familiares. Sentindo-se culpada, ela encontra um ovo mágico, que tem o poder de selar suas palavras." },
                    { new Guid("eafb1a0d-18aa-46d3-a67a-598dacc93482"), true, "Hayao Miyazaki", "O Castelo Animado", "Do mesmo Diretor de A Viagem de Chihiro, este anime conta a dramática história de Sofia, uma adolescente que, devido a uma maldição, é condenada a ter 90 anos. Resta à Sofia partir numa jornada em busca do Castelo Animado do feiticeiro Hauru, que talvez possa ajudá-la." },
                    { new Guid("f5d64466-c3ea-4d82-affa-b9df08718598"), true, "Mamoru Hosoda", "Crianças Lobo", "Vencedor do Japan Academy Prize de 2013, Crianças Lobo traz às telas um romance entre uma garota e um lobisomem. Após o nascimento do segundo filho, o lobisomem morre, deixando à mãe a difícil tarefa de criar dois filhos que possuem a mesma condição do pai." },
                    { new Guid("fd173c0e-78e2-4840-b122-e7494c97977f"), true, "Hayao Miyazaki", "Meu Amigo Totoro", "Uma família se muda para uma casa no campo, com um enorme e misterioso jardim. A casa fica próxima ao hospital onde a mãe de Mei e Satsuki está internada. Certo dia, explorando o vasto jardim da casa, a pequena Mei conhece o incrível monstro Totoro." },
                    { new Guid("feab8ba9-61d8-454f-809f-ea121c7fe02b"), true, "Satoshi Kon", "Paprika", "Na realidade futurista de Paprika, os sonhos podem ser vistos por outras pessoas. Isso mesmo! Um programa desenvolvido por um centro de pesquisas permite que seu usuário tenha acesso ao material onírico de qualquer paciente. O conflito se instaura quando a chefe desse centro de pesquisas começa a usar esse dispositivo de forma clandestina." }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4496655c-5003-434d-a8df-5b2e92e40ab9", null, "Administrator", "ADMINISTRATOR" },
                    { "90921b36-20bb-4de0-83ba-feb93c8aef84", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("0417e93c-ae97-4138-9065-6ead76fd1d74"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("04aed267-c000-4a34-a52c-9bf280ecfae4"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("05aaaed7-cb30-4143-b3bc-c779dd155cb6"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("0f2249b6-c358-4000-9a37-a5bafde8d662"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("19a0ff9a-5001-407f-89c6-d8bc2da18667"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("1ba443c6-92bc-4760-b439-71a637e6cfec"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("447bd4ee-4d20-4ae5-bc48-3509b0a46689"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("53eb4736-e479-49ef-9f4c-a784b92a10dd"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("615e640c-eb6d-4df1-8f29-39d4f2e2d5b9"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("7f549875-2508-4ff7-ae28-fe84e646086d"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("802f6c7d-8c18-432f-a477-f7f506097719"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("938e10aa-3f6f-43c3-a261-b33e00f20554"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("95950f33-c2ac-4748-bfa4-0be29f9bae47"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("bb1eeda7-f245-40e5-bb6f-402665f9eba0"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("c0eeae73-12c1-44e8-89d0-bf7cd563606c"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("c61e8819-0743-4797-b519-963f392a1e03"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("d31a32a6-9178-4ec2-98c4-978c33b9bf48"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("db77e8c1-5ff8-4dc3-92c7-6b4c8341bae2"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("e7a6bb90-c3ad-47af-bcbc-6edb70f161cd"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("eafb1a0d-18aa-46d3-a67a-598dacc93482"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("f5d64466-c3ea-4d82-affa-b9df08718598"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("fd173c0e-78e2-4840-b122-e7494c97977f"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("feab8ba9-61d8-454f-809f-ea121c7fe02b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4496655c-5003-434d-a8df-5b2e92e40ab9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90921b36-20bb-4de0-83ba-feb93c8aef84");

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "Id", "Ativo", "Diretor", "Nome", "Resumo" },
                values: new object[,]
                {
                    { new Guid("0c56e9a4-b2ca-494f-b516-2324358b4a46"), true, "Hayao Miyazaki", "A Viagem de Chihiro", "Considerada por muitos a maior obra de animação de todos os tempos, A Viagem de Chihiro faturou, entre outros prêmios, o Oscar de Melhor Filme de Animação de 2003. A história é focada em Chihiro, uma garota que precisa se virar sozinha a fim de encontrar o caminho de volta para casa num universo fantástico e sombrio. O filme é simplesmente maravilhoso!" },
                    { new Guid("22417f7f-3bf4-4fd8-8cd7-63c879502589"), true, "Hayao Miyazaki", "Vidas ao Vento", "Mais uma maravilha do Estúdio Ghibli está disponível na Netflix. Desta vez, a história do engenheiro aeronáutico japonês Jiro Horikoshi (1903-1982). O filme explora sua relação com Naoko e seu trabalho como projetista de aviões durante o período histórico mais turbulento do século XX." },
                    { new Guid("25bf7ae6-5280-4637-b93a-d4bc44f1f6f0"), true, "Hayao Miyazaki", "Meu Amigo Totoro", "Uma família se muda para uma casa no campo, com um enorme e misterioso jardim. A casa fica próxima ao hospital onde a mãe de Mei e Satsuki está internada. Certo dia, explorando o vasto jardim da casa, a pequena Mei conhece o incrível monstro Totoro." },
                    { new Guid("329db3a4-2768-4ff8-aabd-4534098f2931"), true, "Hayao Miyazaki", "O Castelo Animado", "Do mesmo Diretor de A Viagem de Chihiro, este anime conta a dramática história de Sofia, uma adolescente que, devido a uma maldição, é condenada a ter 90 anos. Resta à Sofia partir numa jornada em busca do Castelo Animado do feiticeiro Hauru, que talvez possa ajudá-la." },
                    { new Guid("394d76ab-76c0-45c4-9662-4533130f45d1"), true, "Satoshi Kon", "Paprika", "Na realidade futurista de Paprika, os sonhos podem ser vistos por outras pessoas. Isso mesmo! Um programa desenvolvido por um centro de pesquisas permite que seu usuário tenha acesso ao material onírico de qualquer paciente. O conflito se instaura quando a chefe desse centro de pesquisas começa a usar esse dispositivo de forma clandestina." },
                    { new Guid("3ae71b3e-c737-409b-a7e8-e939fd8336e2"), true, "Xuan Liang, Chun Zhang", "Big Fish& Begonia", "Shun vive numa espécie de realidade paralela, habitada por criaturas míticas. Quando completa 16 anos, ela ganha o passaporte para a nossa realidade, vindo sob a forma de um golfinho. Quando está voltando para seu mundo, Shun é surpreendida por uma rede e é salva pelo humano Kun, que acaba morrendo afogado. Inconformada, Shun quer trazer seu salvador de volta à vida." },
                    { new Guid("4b139d08-3763-4b1e-8322-f8fbffbf8636"), true, "Tatsuya Nagamine", "Dragon Ball Super: Broly", "Goku mantém-se em treinamento, apesar de se viver um clima de paz e tranquilidade. Ele parece adivinhar que o guerreiro Broly, o mais cruel e agressivo saiyajin, está de volta. Será que Goku e Vegeta serão capazes de derrotar esse vilão?" },
                    { new Guid("4b733caf-48bb-4e91-ad7b-82841b3fc9d9"), true, "Makoto Shinkai", "Cinco Centímetros por Segundo", "Uma frase para introduzir este longa de animação: uma belíssima e comovente história de amor. Cinco Centímetros por Segundo, acompanhamos a relação de Takaki e Akari, dois jovens super grudados que são obrigados a viver distantes um do outro devido às circunstâncias da vida." },
                    { new Guid("6b6babc7-93ce-4eff-b4d5-2d0339fe24de"), true, "Katsuhiro Otomo", "Akira", "Akira é um clássico da animação, tendo influenciado outras produções posteriores do gênero ficção científica. A história se passa numa Tóquio do futuro, completamente destruída por uma explosão que marcou o início da III Guerra Mundial. O ano? 2019. O protagonista é Kaneda, líder de uma gangue de motoqueiros." },
                    { new Guid("85b86cd7-61ac-469d-b330-0dabd0ed7c95"), true, "Goro Miyazaki", "Da Colina Kokuriko", "O pai de Umi desapareceu em alto-mar. Desde então, ela abre bandeiras no quintal de sua casa, que fica no alto de uma colina, para enviar sinais ao mar. Devido a esse hábito, ela se aproxima de Shun, um garoto que trabalha no clube de jornalismo da escola. A descoberta de um segredo vem mudar completamente a relação entre eles." },
                    { new Guid("918ff2ba-d032-44cf-a8e8-e9952337f529"), true, "Makoto Shinkai", "O Jardim das Palavras", "Durante a estação chuvosa em Tóquio, Takao Akizuki e Yukari Yukino se encontram no jardim de Shinjuku Gyoen. Ele, que sonha em se tornar designer de sapatos, vai lá para cabular aulas. Ela encontra no jardim um refúgio para seus problemas pessoais e profissionais." },
                    { new Guid("9280d4f9-04e6-4e93-9f7f-a685ecaa1f15"), true, "Naoko Yamada", "A Voz do Silêncio", "A jovem Shouko Nishimiya é deficiente auditiva e só consegue se comunicar através da língua dos sinais. Em sua nova escola, começa a ser perseguida e sofrer bullying de Ishida, um garoto verdadeiramente sem limites." },
                    { new Guid("93caf2b3-2f81-4af8-9434-d76faf4a2b44"), true, "Isao Takahata", "Túmulo dos Vagalumes", "Túmulo dos Vagalumes se passa em Kobe, no Japão, durante a II Guerra Mundial. A história é centrada nos irmãos Seita e Setsuko, que lutam pela sobrevivência em meio ao horror dos ataques aéreos e à fome." },
                    { new Guid("ac7feddc-55cb-4c81-a072-beade57302db"), true, "Junichi Satô, Tomotaka Shibayama", "Olhos de Gato", "Embarque em uma encantadora jornada de anime com 'Olhos de Gato', um novo conto de fadas que promete cativar corações. Miyo, uma apaixonada adolescente, encontra-se envolvida em uma trama mágica quando uma misteriosa máscara adquirida em um festival de inverno a transforma em uma adorável gatinha branca. Enquanto desenrola-se a história romântica com seu colega Hinode, o filme também abraça temas delicados como bullying, pressões familiares e a dor da perda. Prepare-se para uma experiência cinematográfica que transcende os limites do amor, explorando as complexidades da vida e oferecendo um vislumbre encantador do extraordinário." },
                    { new Guid("acd759be-2280-45a1-8c17-47325bc52478"), true, "Hayao Miyazaki", "Ponyo: Uma Amizade que Veio do Mar", "Aclamado pela crítica e adorado pelo público, Ponyo: Uma Amizade que Veio do Mar é uma das produções mais famosas do Estúdio Ghibli. O filme narra a belíssima história do menino Sosuke e Ponyo, um peixinho dourado que Sosuke salva à beira-mar. Absolutamente fantástico!" },
                    { new Guid("acdee384-ddfd-4cae-ad35-b6545ff2b787"), true, "Hayao Miyazaki", "Princesa Mononoke", "Outra obra-prima do Studio Ghibli e do Diretor Hayao Miyazaki (o mesmo de A Viagem de Chihiro), Princesa Mononoke narra a história de um príncipe que, assombrado por uma maldição, resolve deixar seu povo e procurar cura em outro lugar. No oeste, em meio a uma batalha, conhece San, uma garota que vive entre os deuses-lobo." },
                    { new Guid("b4e485d9-8da0-445c-8120-3eaacee8c479"), true, "Isao Takahata", "O Conto da Princesa Kaguya", "Encontrada por um camponês dentro de um tronco mágico de bambu, a menina Kaguya logo é chamada de princesa por seus pais. Tempos depois, no mesmo bosque, o camponês encontra uma enorme quantidade de ouro. E a menina nascida do bambu se torna de fato uma princesa." },
                    { new Guid("b56bd4e0-f201-4bc5-89f1-e2e580bce8e3"), true, "Tatsuyuki Nagai", "O Hino do Coração", "A pequena Jun Naruse sonha em se tornar uma princesa. Certo dia, ela vê seu pai saindo de um castelo ao lado de uma mulher. Empolgada, ela conta tudo o que viu em casa, desencadeando grandes conflitos familiares. Sentindo-se culpada, ela encontra um ovo mágico, que tem o poder de selar suas palavras." },
                    { new Guid("d138c3c4-c66a-43a2-b1aa-24ce3685ccfc"), true, "Hiromasa Yonebayashi", "As Memórias de Marnie", "Indicada ao Oscar de Melhor Animação, esta animação japonesa narra a história de Anna, uma garota de 12 anos que, além de sofrer de asma, é bastante solitária. Enviada por seus tutores à casa dos tios no litoral, ela se torna amiga de Marnie, uma menina que vive numa mansão misteriosa." },
                    { new Guid("d15f4bef-2f95-4ca8-a31b-a4668be4d2a1"), true, "Mamoru Hosoda", "A Garota que Conquistou o Tempo", "Quem não curte uma história de viagem no tempo? Em A Garota que Conquistou o Tempo, assistimos ao dia a dia meio atrapalhado de uma estudante de Ensino Médio que, certo dia, após passar por uma experiência trágica, decobre que tem a capacidade de manipular o tempo." },
                    { new Guid("d49256d1-0e7c-4d97-a19e-4536ceb3d7d0"), true, "Mamoru Hosoda", "Crianças Lobo", "Vencedor do Japan Academy Prize de 2013, Crianças Lobo traz às telas um romance entre uma garota e um lobisomem. Após o nascimento do segundo filho, o lobisomem morre, deixando à mãe a difícil tarefa de criar dois filhos que possuem a mesma condição do pai." },
                    { new Guid("d990ca22-cca9-425d-a421-89e05e8cf9ce"), true, "Makoto Shinkai", "Kimi No Na Wa", "Vencedor de vários prêmios, dentre os quais o Japan Awards, Your Name conta a história de Mitsuha, uma garota que vive no campo e deseja conhecer Tóquio, e Taki, um garoto qu vive na capital. Certo dia, Mitsuha leva seu desejo a um templo religioso. E é atendida. Ela acorda no corpo de Taki, e ele no corpo dela!" },
                    { new Guid("ebd578fc-6d1b-4c7a-ae0c-dda464b87ce5"), true, "Mamoru Oshii", "O Fantasma do Futuro", "Se Akira se passa em 2019, O Fantasma do Futuro foi um pouco mais adiante: 2029. Neste futuro não tão distante, pessoas são capazes de usar seu ciber-cérebros para acessar redes virtuais de informações. É nesse contexto que a agente Motoko precisa conter um hacker que invade o ciber-cérebro das pessoas." }
                });
        }
    }
}
