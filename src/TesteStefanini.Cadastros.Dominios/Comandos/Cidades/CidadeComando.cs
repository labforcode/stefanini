namespace TesteStefanini.Cadastros.Dominios.Comandos.Cidades
{
    public class CidadeComando 
    {
        public CidadeComando(int id,
                             string nome,
                             string uf)
        {
            Id = id;
            Nome = nome;
            Uf = uf;
        }

        public int Id { get; set; }

        public string Nome { get; protected set; }

        public string Uf { get; protected set; }
    }
}
