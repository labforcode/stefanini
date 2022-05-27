using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;

namespace TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Pessoas
{
    public interface IPessoaRepositorio : IBaseRepositorio<Pessoa>
    {
        Task<dynamic> ObterPorIdAsync(int id);

        Task<dynamic> ObterPorCpfAsync(string cpf);

        Task<IEnumerable<dynamic>> ObterTodosAsync();
    }
}
