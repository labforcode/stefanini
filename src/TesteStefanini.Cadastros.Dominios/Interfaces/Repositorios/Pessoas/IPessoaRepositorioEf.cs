using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;

namespace TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Pessoas
{
    public interface IPessoaRepositorioEf : IBaseRepositorioEf<Pessoa>
    {
        Task<Pessoa> ObterPorId(int id);

        Task<Pessoa> ObterPorCpf(string cpf);

        Task<IEnumerable<Pessoa>> ObterTodos();
    }
}
