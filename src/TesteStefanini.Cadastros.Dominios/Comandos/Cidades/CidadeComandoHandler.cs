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
            var cidadeExistente = _cidadeRepositorio.ObterPorIdAsync(comando.Id).Result;
            if (cidadeExistente == null) throw new Exception("Cidade não localizada.");

            var cidade = new Cidade(cidadeExistente.Id,
                                    comando.Nome,
                                    comando.Uf);

            _cidadeRepositorio.Update(cidade);
            _uow.Commit();
        }

        public void Excluir(CidadeComando comando)
        {
            var cidade = _cidadeRepositorio.ObterPorIdAsync(comando.Id).Result;
            if (cidade == null) throw new Exception("Cidade não localizada.");

            _cidadeRepositorio.Delete(cidade);
            _uow.Commit();
        }
    }
}
