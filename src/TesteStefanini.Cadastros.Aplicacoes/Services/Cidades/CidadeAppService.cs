using TesteStefanini.Cadastros.Aplicacoes.DTOs.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Cidades;

namespace TesteStefanini.Cadastros.Aplicacoes.Services.Cidades
{
    public class CidadeAppService : ICidadeAppService
    {
        public void Adicionar(CidadeDto cidadeDto)
        {

        }

        public void Atualizar(CidadeDto cidadeDto)
        {

        }

        public void Excluir(CidadeDto cidadeDto)
        {

        }

        public Task<CidadeViewModel> ObterPorId(int id)
        {
            return null;
        }

        public Task<CidadeViewModel> ObterPorNome(string nome)
        {
            return null;
        }

        public Task<IEnumerable<CidadeViewModel>> ObterPorUf(string uf)
        {
            return null;
        }

        public Task<IEnumerable<CidadeViewModel>> ObterTodos()
        {
            return null;
        }
    }
}
