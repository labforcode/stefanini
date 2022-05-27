namespace TesteStefanini.Cadastros.Dominios.Comandos.Pessoas
{
    public class PessoaComando
    {
        public PessoaComando(string cpf,
                             string nome,
                             DateTime dataNascimento,
                             int cidadeId)
        {
            Cpf = cpf;
            Nome = nome;
            DataNascimento = dataNascimento;
            CidadeId = cidadeId;
        }

        public string Cpf { get; protected set; }

        public string Nome { get; protected set; }

        public DateTime DataNascimento { get; protected set; }

        public int CidadeId { get; protected set; }
    }
}
