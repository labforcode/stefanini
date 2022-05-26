using TesteStefanini.Cadastros.Aplicacoes.DTOs.Pessoas;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Pessoas;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Pessoas;

namespace TesteStefanini.Cadastros.Aplicacoes.Services.Pessoas
{
    public class PessoaAppService : IPessoaAppService
    {

        public void Adicionar(PessoaDto pessoaDto)
        {

        }

        public void Atualizar(PessoaDto pessoaDto)
        {

        }

        public void Excluir(PessoaDto pessoaDto)
        {

        }

        public Task<PessoaViewModel> ObterPorId(int id)
        {
            return null;
        }

        public Task<PessoaViewModel> ObterPorCpf(string cpf)
        {
            return null;
        }

        public Task<IEnumerable<PessoaViewModel>> ObterTodos()
        {
            return null;
        }
    }
}
