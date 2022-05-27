using AutoMapper;
using TesteStefanini.Cadastros.Aplicacoes.DTOs.Pessoas;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Pessoas;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Pessoas;
using TesteStefanini.Cadastros.Dominios.Comandos.Pessoas;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Pessoas;

namespace TesteStefanini.Cadastros.Aplicacoes.Services.Pessoas
{
    public class PessoaAppService : IPessoaAppService
    {
        private readonly IMapper _mapper;
        private readonly IPessoaComando _pessoaComando;
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaAppService(IMapper mapper,
                                IPessoaComando pessoaComando,
                                IPessoaRepositorio pessoaRepositorio)
        {
            _mapper = mapper;
            _pessoaComando = pessoaComando;
            _pessoaRepositorio = pessoaRepositorio;
        }

        public void Adicionar(PessoaDto pessoaDto)
        {
            var comando = _mapper.Map<PessoaComando>(pessoaDto);
            _pessoaComando.Adicionar(comando);
        }

        public void Atualizar(PessoaDto pessoaDto)
        {
            var comando = _mapper.Map<PessoaComando>(pessoaDto);
            _pessoaComando.Atualizar(comando);
        }

        public void Excluir(PessoaDto pessoaDto)
        {
            var comando = _mapper.Map<PessoaComando>(pessoaDto);
            _pessoaComando.Excluir(comando);
        }

        public Task<PessoaViewModel> ObterPorIdAsync(int id)
        {
            return null;
        }

        public Task<PessoaViewModel> ObterPorCpfAsync(string cpf)
        {
            return null;
        }

        public Task<IEnumerable<PessoaViewModel>> ObterTodosAsync()
        {
            return null;
        }
    }
}
