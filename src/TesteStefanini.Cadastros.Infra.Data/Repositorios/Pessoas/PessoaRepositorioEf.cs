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
    }
}
