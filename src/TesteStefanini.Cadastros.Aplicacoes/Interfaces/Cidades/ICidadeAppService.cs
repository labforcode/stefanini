using TesteStefanini.Cadastros.Aplicacoes.DTOs.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Cidades;

namespace TesteStefanini.Cadastros.Aplicacoes.Interfaces.Cidades
{
    public interface ICidadeAppService
    {
        void Adicionar(CidadeDto cidadeDto);

        void Atualizar(CidadeDto cidadeDto);

        void Excluir(CidadeDto cidadeDto);

        Task<CidadeViewModel> ObterPorIdAsync(int id);

        Task<CidadeViewModel> ObterPorNomeAsync(string nome);

        Task<IEnumerable<CidadeViewModel>> ObterPorUfAsync(string uf);

        Task<IEnumerable<CidadeViewModel>> ObterTodosAsync();
    }
}
