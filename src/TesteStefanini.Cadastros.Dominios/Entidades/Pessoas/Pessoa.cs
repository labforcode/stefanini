using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;

namespace TesteStefanini.Cadastros.Dominios.Entidades.Pessoas
{
    public class Pessoa
    {
        public Pessoa(int id,
                      string nome,
                      string cpf,
                      DateTime dataNascimento,
                      int cidadeId)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            CidadeId = cidadeId;
        }

        protected Pessoa()
        {
        }

        public int Id { get; private set; }

        public string Cpf { get; private set; }

        public string Nome { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public int CidadeId { get; private set; }

        public virtual Cidade Cidade { get; set; }
    }
}
