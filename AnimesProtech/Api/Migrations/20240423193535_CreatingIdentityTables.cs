using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class CreatingIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("1730ff25-d51e-43fa-8ab8-1adb773d3596"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("2fd22b93-e78e-4879-ba3f-d8e1cee928c8"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("33f90da6-b3ff-4fa9-a8bb-d364f378a049"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("52ac4519-9593-4ab9-8d76-f2fc8e669204"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("53f03f87-bebc-4bf1-b49f-bc2d5f355561"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("549ee65a-5db2-4ce2-a1d3-05cf4a428b4d"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("5bb8cca6-5b81-4878-b680-985354b38f35"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("79a6a12c-0beb-40da-b598-5353bb2c88bd"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("7aa93595-ffe9-4ad6-a2fa-34a5ac3fef7d"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("843462a0-1c88-4d12-bdaf-f7301bfc1250"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("9ef2754e-8fdb-4f9e-9396-212a1cfefdc6"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("a3b5f7d4-763e-49b8-a1e5-a0b385b1932e"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("a4f4dace-520e-4bfe-b77d-b94d750666fb"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("a971bead-52d4-4396-b66e-8b95a854b519"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("c81a1182-a8db-4d87-9155-ef10225aaafa"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("db3064cb-6c23-4295-ab85-45b7297b90f6"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("df950d58-9277-4436-9e3a-b062b80c0a98"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("e3eb7ed1-cace-4918-b24a-91afd5330c74"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("e44c0cc1-e3c3-4dbb-96bc-6b7229321b4b"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("ec625351-693e-4dd0-8168-8cec92a155a3"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("f0fba97f-e531-4140-880e-653a8cc863a0"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("f155ed39-0238-478d-b79e-b5796c004afb"));

            migrationBuilder.DeleteData(
                table: "Animes",
                keyColumn: "Id",
                keyValue: new Guid("fd793804-688d-4b9a-8825-b2bf337a5b0f"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
                    { new Guid("1730ff25-d51e-43fa-8ab8-1adb773d3596"), true, "Xuan Liang, Chun Zhang", "Big Fish& Begonia", "Shun vive numa espécie de realidade paralela, habitada por criaturas míticas. Quando completa 16 anos, ela ganha o passaporte para a nossa realidade, vindo sob a forma de um golfinho. Quando está voltando para seu mundo, Shun é surpreendida por uma rede e é salva pelo humano Kun, que acaba morrendo afogado. Inconformada, Shun quer trazer seu salvador de volta à vida." },
                    { new Guid("2fd22b93-e78e-4879-ba3f-d8e1cee928c8"), true, "Hiromasa Yonebayashi", "As Memórias de Marnie", "Indicada ao Oscar de Melhor Animação, esta animação japonesa narra a história de Anna, uma garota de 12 anos que, além de sofrer de asma, é bastante solitária. Enviada por seus tutores à casa dos tios no litoral, ela se torna amiga de Marnie, uma menina que vive numa mansão misteriosa." },
                    { new Guid("33f90da6-b3ff-4fa9-a8bb-d364f378a049"), true, "Isao Takahata", "Túmulo dos Vagalumes", "Túmulo dos Vagalumes se passa em Kobe, no Japão, durante a II Guerra Mundial. A história é centrada nos irmãos Seita e Setsuko, que lutam pela sobrevivência em meio ao horror dos ataques aéreos e à fome." },
                    { new Guid("52ac4519-9593-4ab9-8d76-f2fc8e669204"), true, "Mamoru Hosoda", "A Garota que Conquistou o Tempo", "Quem não curte uma história de viagem no tempo? Em A Garota que Conquistou o Tempo, assistimos ao dia a dia meio atrapalhado de uma estudante de Ensino Médio que, certo dia, após passar por uma experiência trágica, decobre que tem a capacidade de manipular o tempo." },
                    { new Guid("53f03f87-bebc-4bf1-b49f-bc2d5f355561"), true, "Katsuhiro Otomo", "Akira", "Akira é um clássico da animação, tendo influenciado outras produções posteriores do gênero ficção científica. A história se passa numa Tóquio do futuro, completamente destruída por uma explosão que marcou o início da III Guerra Mundial. O ano? 2019. O protagonista é Kaneda, líder de uma gangue de motoqueiros." },
                    { new Guid("549ee65a-5db2-4ce2-a1d3-05cf4a428b4d"), true, "Hayao Miyazaki", "Ponyo: Uma Amizade que Veio do Mar", "Aclamado pela crítica e adorado pelo público, Ponyo: Uma Amizade que Veio do Mar é uma das produções mais famosas do Estúdio Ghibli. O filme narra a belíssima história do menino Sosuke e Ponyo, um peixinho dourado que Sosuke salva à beira-mar. Absolutamente fantástico!" },
                    { new Guid("5bb8cca6-5b81-4878-b680-985354b38f35"), true, "Hayao Miyazaki", "Princesa Mononoke", "Outra obra-prima do Studio Ghibli e do Diretor Hayao Miyazaki (o mesmo de A Viagem de Chihiro), Princesa Mononoke narra a história de um príncipe que, assombrado por uma maldição, resolve deixar seu povo e procurar cura em outro lugar. No oeste, em meio a uma batalha, conhece San, uma garota que vive entre os deuses-lobo." },
                    { new Guid("79a6a12c-0beb-40da-b598-5353bb2c88bd"), true, "Makoto Shinkai", "Kimi No Na Wa", "Vencedor de vários prêmios, dentre os quais o Japan Awards, Your Name conta a história de Mitsuha, uma garota que vive no campo e deseja conhecer Tóquio, e Taki, um garoto qu vive na capital. Certo dia, Mitsuha leva seu desejo a um templo religioso. E é atendida. Ela acorda no corpo de Taki, e ele no corpo dela!" },
                    { new Guid("7aa93595-ffe9-4ad6-a2fa-34a5ac3fef7d"), true, "Isao Takahata", "O Conto da Princesa Kaguya", "Encontrada por um camponês dentro de um tronco mágico de bambu, a menina Kaguya logo é chamada de princesa por seus pais. Tempos depois, no mesmo bosque, o camponês encontra uma enorme quantidade de ouro. E a menina nascida do bambu se torna de fato uma princesa." },
                    { new Guid("843462a0-1c88-4d12-bdaf-f7301bfc1250"), true, "Hayao Miyazaki", "Vidas ao Vento", "Mais uma maravilha do Estúdio Ghibli está disponível na Netflix. Desta vez, a história do engenheiro aeronáutico japonês Jiro Horikoshi (1903-1982). O filme explora sua relação com Naoko e seu trabalho como projetista de aviões durante o período histórico mais turbulento do século XX." },
                    { new Guid("9ef2754e-8fdb-4f9e-9396-212a1cfefdc6"), true, "Naoko Yamada", "A Voz do Silêncio", "A jovem Shouko Nishimiya é deficiente auditiva e só consegue se comunicar através da língua dos sinais. Em sua nova escola, começa a ser perseguida e sofrer bullying de Ishida, um garoto verdadeiramente sem limites." },
                    { new Guid("a3b5f7d4-763e-49b8-a1e5-a0b385b1932e"), true, "Satoshi Kon", "Paprika", "Na realidade futurista de Paprika, os sonhos podem ser vistos por outras pessoas. Isso mesmo! Um programa desenvolvido por um centro de pesquisas permite que seu usuário tenha acesso ao material onírico de qualquer paciente. O conflito se instaura quando a chefe desse centro de pesquisas começa a usar esse dispositivo de forma clandestina." },
                    { new Guid("a4f4dace-520e-4bfe-b77d-b94d750666fb"), true, "Hayao Miyazaki", "Meu Amigo Totoro", "Uma família se muda para uma casa no campo, com um enorme e misterioso jardim. A casa fica próxima ao hospital onde a mãe de Mei e Satsuki está internada. Certo dia, explorando o vasto jardim da casa, a pequena Mei conhece o incrível monstro Totoro." },
                    { new Guid("a971bead-52d4-4396-b66e-8b95a854b519"), true, "Makoto Shinkai", "O Jardim das Palavras", "Durante a estação chuvosa em Tóquio, Takao Akizuki e Yukari Yukino se encontram no jardim de Shinjuku Gyoen. Ele, que sonha em se tornar designer de sapatos, vai lá para cabular aulas. Ela encontra no jardim um refúgio para seus problemas pessoais e profissionais." },
                    { new Guid("c81a1182-a8db-4d87-9155-ef10225aaafa"), true, "Mamoru Oshii", "O Fantasma do Futuro", "Se Akira se passa em 2019, O Fantasma do Futuro foi um pouco mais adiante: 2029. Neste futuro não tão distante, pessoas são capazes de usar seu ciber-cérebros para acessar redes virtuais de informações. É nesse contexto que a agente Motoko precisa conter um hacker que invade o ciber-cérebro das pessoas." },
                    { new Guid("db3064cb-6c23-4295-ab85-45b7297b90f6"), true, "Tatsuyuki Nagai", "O Hino do Coração", "A pequena Jun Naruse sonha em se tornar uma princesa. Certo dia, ela vê seu pai saindo de um castelo ao lado de uma mulher. Empolgada, ela conta tudo o que viu em casa, desencadeando grandes conflitos familiares. Sentindo-se culpada, ela encontra um ovo mágico, que tem o poder de selar suas palavras." },
                    { new Guid("df950d58-9277-4436-9e3a-b062b80c0a98"), true, "Junichi Satô, Tomotaka Shibayama", "Olhos de Gato", "Embarque em uma encantadora jornada de anime com 'Olhos de Gato', um novo conto de fadas que promete cativar corações. Miyo, uma apaixonada adolescente, encontra-se envolvida em uma trama mágica quando uma misteriosa máscara adquirida em um festival de inverno a transforma em uma adorável gatinha branca. Enquanto desenrola-se a história romântica com seu colega Hinode, o filme também abraça temas delicados como bullying, pressões familiares e a dor da perda. Prepare-se para uma experiência cinematográfica que transcende os limites do amor, explorando as complexidades da vida e oferecendo um vislumbre encantador do extraordinário." },
                    { new Guid("e3eb7ed1-cace-4918-b24a-91afd5330c74"), true, "Tatsuya Nagamine", "Dragon Ball Super: Broly", "Goku mantém-se em treinamento, apesar de se viver um clima de paz e tranquilidade. Ele parece adivinhar que o guerreiro Broly, o mais cruel e agressivo saiyajin, está de volta. Será que Goku e Vegeta serão capazes de derrotar esse vilão?" },
                    { new Guid("e44c0cc1-e3c3-4dbb-96bc-6b7229321b4b"), true, "Hayao Miyazaki", "A Viagem de Chihiro", "Considerada por muitos a maior obra de animação de todos os tempos, A Viagem de Chihiro faturou, entre outros prêmios, o Oscar de Melhor Filme de Animação de 2003. A história é focada em Chihiro, uma garota que precisa se virar sozinha a fim de encontrar o caminho de volta para casa num universo fantástico e sombrio. O filme é simplesmente maravilhoso!" },
                    { new Guid("ec625351-693e-4dd0-8168-8cec92a155a3"), true, "Goro Miyazaki", "Da Colina Kokuriko", "O pai de Umi desapareceu em alto-mar. Desde então, ela abre bandeiras no quintal de sua casa, que fica no alto de uma colina, para enviar sinais ao mar. Devido a esse hábito, ela se aproxima de Shun, um garoto que trabalha no clube de jornalismo da escola. A descoberta de um segredo vem mudar completamente a relação entre eles." },
                    { new Guid("f0fba97f-e531-4140-880e-653a8cc863a0"), true, "Hayao Miyazaki", "O Castelo Animado", "Do mesmo Diretor de A Viagem de Chihiro, este anime conta a dramática história de Sofia, uma adolescente que, devido a uma maldição, é condenada a ter 90 anos. Resta à Sofia partir numa jornada em busca do Castelo Animado do feiticeiro Hauru, que talvez possa ajudá-la." },
                    { new Guid("f155ed39-0238-478d-b79e-b5796c004afb"), true, "Makoto Shinkai", "Cinco Centímetros por Segundo", "Uma frase para introduzir este longa de animação: uma belíssima e comovente história de amor. Cinco Centímetros por Segundo, acompanhamos a relação de Takaki e Akari, dois jovens super grudados que são obrigados a viver distantes um do outro devido às circunstâncias da vida." },
                    { new Guid("fd793804-688d-4b9a-8825-b2bf337a5b0f"), true, "Mamoru Hosoda", "Crianças Lobo", "Vencedor do Japan Academy Prize de 2013, Crianças Lobo traz às telas um romance entre uma garota e um lobisomem. Após o nascimento do segundo filho, o lobisomem morre, deixando à mãe a difícil tarefa de criar dois filhos que possuem a mesma condição do pai." }
                });
        }
    }
}
