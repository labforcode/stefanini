namespace TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios
{
    public interface IBaseRepositorio<T> : IDisposable where T : class
    {
        void Add(T t);

        void Update(T t);

        void Delete(T t);
    }
}
