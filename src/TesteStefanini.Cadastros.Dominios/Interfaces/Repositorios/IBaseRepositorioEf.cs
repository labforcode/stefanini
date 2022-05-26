namespace TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios
{
    public interface IBaseRepositorioEf<T> : IDisposable where T : class
    {
        void Add(T t);

        void Update(T t);

        void Delete(T t);
    }
}
