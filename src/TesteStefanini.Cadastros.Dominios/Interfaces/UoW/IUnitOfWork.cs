namespace TesteStefanini.Cadastros.Dominios.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
