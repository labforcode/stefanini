using TesteStefanini.Cadastros.Aplicacoes.DTOs.Pessoas;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Pessoas;

namespace TesteStefanini.Cadastros.Aplicacoes.Interfaces.Pessoas
{
    public interface IPessoaAppService
    {
        void Adicionar(PessoaDto pessoaDto);

        void Atualizar(PessoaDto pessoaDto);

        void Excluir(PessoaDto pessoaDto);

        Task<PessoaViewModel> ObterPorId(int id);

        Task<PessoaViewModel> ObterPorCpf(string cpf);

        Task<IEnumerable<PessoaViewModel>> ObterTodos();
    }
}
