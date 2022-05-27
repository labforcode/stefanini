namespace TesteStefanini.Cadastros.Dominios.Comandos.Cidades
{
    public class CidadeComando 
    {
        public CidadeComando(string nome,
                             string uf)
        {
            Nome = nome;
            Uf = uf;
        }

        public string Nome { get; protected set; }

        public string Uf { get; protected set; }
    }
}
