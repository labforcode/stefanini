namespace TesteStefanini.Cadastros.Aplicacoes.DTOs.Pessoas
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public int CidadeId { get; set; }
    }
}
