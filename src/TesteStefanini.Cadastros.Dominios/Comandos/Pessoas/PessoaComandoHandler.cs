using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Pessoas;

namespace TesteStefanini.Cadastros.Dominios.Comandos.Pessoas
{
    public class PessoaComandoHandler : IPessoaComando
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaComandoHandler(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        public void Adicionar(PessoaComando comando)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(PessoaComando comando)
        {
            throw new NotImplementedException();
        }

        public void Excluir(PessoaComando comando)
        {
            throw new NotImplementedException();
        }
    }
}
