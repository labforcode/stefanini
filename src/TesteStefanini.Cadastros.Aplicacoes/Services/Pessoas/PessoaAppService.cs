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

        public async Task<PessoaViewModel> ObterPorIdAsync(int id)
        {
            var pessoa = (PessoaViewModel)_mapper.Map<PessoaViewModel>(await _pessoaRepositorio.ObterPorIdAsync(id));
            pessoa = CalcularIdadePessoa(pessoa);

            return pessoa;
        }

        public async Task<PessoaViewModel> ObterPorCpfAsync(string cpf)
        {
            var pessoa = _mapper.Map<PessoaViewModel>(await _pessoaRepositorio.ObterPorCpfAsync(cpf));
            pessoa = CalcularIdadePessoa(pessoa);

            return pessoa;
        }

        public async Task<IEnumerable<PessoaViewModel>> ObterTodosAsync()
        {
            var listaPessoas = new List<PessoaViewModel>();
            var pessoas = _mapper.Map<IEnumerable<PessoaViewModel>>(await _pessoaRepositorio.ObterTodosAsync());
            foreach (var pessoa in pessoas)
            {
                var novaPessoa = CalcularIdadePessoa(pessoa);
                listaPessoas.Add(novaPessoa);
            }

            return listaPessoas;
        }

        /// <summary>
        /// Calcula a idade da pessoa
        /// </summary>
        /// <param name="dataNascimento"></param>
        /// <returns></returns>
        private static PessoaViewModel CalcularIdadePessoa(PessoaViewModel pessoa)
        {
            var idade = DateTime.Now.Year - pessoa.DataNascimento.Year;
            pessoa.Idade = idade;
            if (DateTime.Now.DayOfYear < pessoa.DataNascimento.DayOfYear)
            {
                pessoa.Idade = idade - 1;
            }

            return pessoa;
        }
    }
}
