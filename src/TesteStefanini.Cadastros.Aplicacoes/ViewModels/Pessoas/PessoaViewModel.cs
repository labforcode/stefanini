namespace TesteStefanini.Cadastros.Aplicacoes.ViewModels.Pessoas
{
    public class PessoaViewModel
    {
        public int Id { get; set; }

        public string Cpf { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public DateTime DataNascimento { get; set; }

        public int CidadeId { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }
    }
}
