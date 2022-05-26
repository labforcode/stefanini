using TesteStefanini.Cadastros.Aplicacoes.DTOs.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Cidades;

namespace TesteStefanini.Cadastros.Aplicacoes.Interfaces.Cidades
{
    public interface ICidadeAppService
    {
        void Adicionar(CidadeDto cidadeDto);

        void Atualizar(CidadeDto cidadeDto);

        void Excluir(CidadeDto cidadeDto);

        Task<CidadeViewModel> ObterPorId(int id);

        Task<CidadeViewModel> ObterPorNome(string nome);

        Task<IEnumerable<CidadeViewModel>> ObterPorUf(string uf);

        Task<IEnumerable<CidadeViewModel>> ObterTodos();
    }
}
