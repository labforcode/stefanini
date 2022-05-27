namespace TesteStefanini.Cadastros.Dominios.Comandos.Pessoas
{
    public interface IPessoaComando
    {
        void Adicionar(PessoaComando comando);

        void Atualizar(PessoaComando comando);

        void Excluir(PessoaComando comando);
    }
}
