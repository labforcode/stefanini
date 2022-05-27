using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades;
using TesteStefanini.Cadastros.Dominios.Interfaces.UoW;

namespace TesteStefanini.Cadastros.Dominios.Comandos.Cidades
{
    public class CidadeComandoHandler : ICidadeComando
    {
        private readonly IUnitOfWork _uow;
        private readonly ICidadeRepositorio _cidadeRepositorio;

        public CidadeComandoHandler(IUnitOfWork uow,
                                    ICidadeRepositorio cidadeRepositorio)
        {
            _uow = uow;
            _cidadeRepositorio = cidadeRepositorio;
        }

        public void Adicionar(CidadeComando comando)
        {
            var cidade = new Cidade(0,
                                    comando.Nome,
                                    comando.Uf);

            _cidadeRepositorio.Add(cidade);
            _uow.Commit();
        }

        public void Atualizar(CidadeComando comando)
        {
            throw new NotImplementedException();
        }

        public void Excluir(CidadeComando comando)
        {
            throw new NotImplementedException();
        }
    }
}
