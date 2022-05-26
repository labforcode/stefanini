using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;

namespace TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades
{
    public interface ICidadeRepositorioEf : IBaseRepositorioEf<Cidade>
    {
        Task<Cidade> ObterPorId(int id);

        Task<Cidade> ObterPorNome(string nome);

        Task<IEnumerable<Cidade>> ObterPorUf(string uf);

        Task<IEnumerable<Cidade>> ObterTodos();
    }
}
