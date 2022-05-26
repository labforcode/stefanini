using Microsoft.EntityFrameworkCore;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

namespace TesteStefanini.Cadastros.Infra.Data.Repositorios
{
    public class BaseRepositorioEf<T> : IBaseRepositorioEf<T> where T : class
    {
        protected DbStefanini Context;
        private readonly DbSet<T> _dbSet;

        public BaseRepositorioEf(DbStefanini context)
        {
            Context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T t)
        {
            _dbSet.Add(t);
        }

        public void Add(List<T> t)
        {
            _dbSet.AddRange(t);
        }

        public void Update(T t)
        {
            _dbSet.Update(t);
        }

        public void Delete(T t)
        {
            _dbSet.Remove(t);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
