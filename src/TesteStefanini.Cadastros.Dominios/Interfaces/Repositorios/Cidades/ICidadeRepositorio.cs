using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;

namespace TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades
{
    public interface ICidadeRepositorio : IBaseRepositorio<Cidade>
    {
        Task<Cidade> ObterPorIdAsync(int id);

        Task<Cidade> ObterPorNomeAsync(string nome);

        Task<IEnumerable<Cidade>> ObterPorUfAsync(string uf);

        Task<IEnumerable<Cidade>> ObterTodosAsync();
    }
}
