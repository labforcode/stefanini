namespace TesteStefanini.Cadastros.Dominios.Comandos.Cidades
{
    public interface ICidadeComando
    {
        void Adicionar(CidadeComando comando);

        void Atualizar(CidadeComando comando);

        void Excluir(CidadeComando comando);
    }
}
