using TesteStefanini.Cadastros.Aplicacoes.DTOs.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Cidades;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades;

namespace TesteStefanini.Cadastros.Aplicacoes.Services.Cidades
{
    public class CidadeAppService : ICidadeAppService
    {
        private readonly ICidadeRepositorio _cidadeRepositorio;

        public CidadeAppService(ICidadeRepositorio cidadeRepositorio)
        {
            _cidadeRepositorio = cidadeRepositorio;
        }

        public void Adicionar(CidadeDto cidadeDto)
        {
            
        }

        public void Atualizar(CidadeDto cidadeDto)
        {

        }

        public void Excluir(CidadeDto cidadeDto)
        {

        }

        public Task<CidadeViewModel> ObterPorIdAsync(int id)
        {
            return null;
        }

        public Task<CidadeViewModel> ObterPorNomeAsync(string nome)
        {
            return null;
        }

        public Task<IEnumerable<CidadeViewModel>> ObterPorUfAsync(string uf)
        {
            return null;
        }

        public Task<IEnumerable<CidadeViewModel>> ObterTodosAsync()
        {
            return null;
        }
    }
}
