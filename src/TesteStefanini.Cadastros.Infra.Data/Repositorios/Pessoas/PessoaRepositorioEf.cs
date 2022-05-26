using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Pessoas;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

namespace TesteStefanini.Cadastros.Infra.Data.Repositorios.Pessoas
{
    public class PessoaRepositorioEf : BaseRepositorioEf<Pessoa>, IPessoaRepositorioEf
    {
        public PessoaRepositorioEf(DbStefanini context) : base(context)
        {
        }

        public Task<Pessoa> ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task<Pessoa> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pessoa>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
