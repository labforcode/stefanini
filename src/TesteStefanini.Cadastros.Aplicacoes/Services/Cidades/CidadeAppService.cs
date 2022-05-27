using AutoMapper;
using TesteStefanini.Cadastros.Aplicacoes.DTOs.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Cidades;
using TesteStefanini.Cadastros.Dominios.Comandos.Cidades;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades;

namespace TesteStefanini.Cadastros.Aplicacoes.Services.Cidades
{
    public class CidadeAppService : ICidadeAppService
    {
        private readonly IMapper _mapper;
        private readonly ICidadeComando _cidadeComando;
        private readonly ICidadeRepositorio _cidadeRepositorio;

        public CidadeAppService(IMapper mapper,
                                ICidadeComando cidadeComando,
                                ICidadeRepositorio cidadeRepositorio)
        {
            _mapper = mapper;
            _cidadeComando = cidadeComando;
            _cidadeRepositorio = cidadeRepositorio;
        }

        public void Adicionar(CidadeDto cidadeDto)
        {
            var comando = _mapper.Map<CidadeComando>(cidadeDto);
            _cidadeComando.Adicionar(comando);
        }

        public void Atualizar(CidadeDto cidadeDto)
        {
            var comando = _mapper.Map<CidadeComando>(cidadeDto);
            _cidadeComando.Atualizar(comando);
        }

        public void Excluir(CidadeDto cidadeDto)
        {
            var comando = _mapper.Map<CidadeComando>(cidadeDto);
            _cidadeComando.Excluir(comando);
        }

        public async Task<CidadeViewModel> ObterPorIdAsync(int id)
        {
            return _mapper.Map<CidadeViewModel>(await _cidadeRepositorio.ObterPorIdAsync(id));
        }

        public async Task<CidadeViewModel> ObterPorNomeAsync(string nome)
        {
            return _mapper.Map<CidadeViewModel>(await _cidadeRepositorio.ObterPorNomeAsync(nome));
        }

        public async Task<IEnumerable<CidadeViewModel>> ObterPorUfAsync(string uf)
        {
            return _mapper.Map<IEnumerable<CidadeViewModel>>(await _cidadeRepositorio.ObterPorUfAsync(uf));
        }

        public async Task<IEnumerable<CidadeViewModel>> ObterTodosAsync()
        {
            return _mapper.Map<IEnumerable<CidadeViewModel>>(await _cidadeRepositorio.ObterTodosAsync());
        }
    }
}
