using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;

namespace TesteStefanini.Cadastros.Dominios.Entidades.Cidades
{
    public class Cidade
    {
        public Cidade(int id,
                      string nome,
                      string uf)
        {
            Id = id;
            Nome = nome;
            Uf = uf;
        }

        protected Cidade()
        {
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Uf { get; private set; }

        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
