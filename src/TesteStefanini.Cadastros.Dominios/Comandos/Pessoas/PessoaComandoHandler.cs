using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Pessoas;
using TesteStefanini.Cadastros.Dominios.Interfaces.UoW;

namespace TesteStefanini.Cadastros.Dominios.Comandos.Pessoas
{
    public class PessoaComandoHandler : IPessoaComando
    {
        private readonly IUnitOfWork _uow;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly ICidadeRepositorio _cidadeRepositorio;

        public PessoaComandoHandler(IUnitOfWork uow,
                                    IPessoaRepositorio pessoaRepositorio,
                                    ICidadeRepositorio cidadeRepositorio)
        {
            _uow = uow;
            _pessoaRepositorio = pessoaRepositorio;
            _cidadeRepositorio = cidadeRepositorio;
        }

        public void Adicionar(PessoaComando comando)
        {
            var cidade = _cidadeRepositorio.ObterPorIdAsync(comando.CidadeId).Result;
            if (cidade == null) throw new Exception("Cidade não localizada.");

            var pessoaCadastrada = _pessoaRepositorio.ObterPessoaPorCpfAsync(comando.Cpf).Result;
            if (pessoaCadastrada != null) throw new Exception("Pessoa já cadastrada.");

            var pessoa = new Pessoa(0,
                                    comando.Nome,
                                    comando.Cpf,
                                    comando.DataNascimento,
                                    comando.CidadeId);


            _pessoaRepositorio.Add(pessoa);
            _uow.Commit();
        }

        public void Atualizar(PessoaComando comando)
        {
            var cidade = _cidadeRepositorio.ObterPorIdAsync(comando.CidadeId).Result;
            if (cidade == null) throw new Exception("Cidade não localizada.");

            var pessoaCadastrada = _pessoaRepositorio.ObterPessoaPorCpfAsync(comando.Cpf).Result;
            if (pessoaCadastrada == null) throw new Exception("Pessoa já cadastrada.");

            var pessoa = new Pessoa(pessoaCadastrada.Id,
                                    comando.Nome,
                                    comando.Cpf,
                                    comando.DataNascimento,
                                    comando.CidadeId);

            _pessoaRepositorio.Update(pessoa);
            _uow.Commit();
        }

        public void Excluir(PessoaComando comando)
        {
            var pessoaCadastrada = _pessoaRepositorio.ObterPessoaPorCpfAsync(comando.Cpf).Result;
            if (pessoaCadastrada == null) throw new Exception("Pessoa já cadastrada.");

            _pessoaRepositorio.Delete(pessoaCadastrada);
            _uow.Commit();
        }
    }
}
