namespace Domain.Dto
{
    public record AnimeDto
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Diretor { get; set; }
        public string? Resumo { get; set; }
        public bool Ativo { get; set; }
    }
}
