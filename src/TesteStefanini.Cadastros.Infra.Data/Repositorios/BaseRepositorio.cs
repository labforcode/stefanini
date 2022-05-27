using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

namespace TesteStefanini.Cadastros.Infra.Data.Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        protected DbStefanini Context;
        private readonly DbSet<T> _dbSet;
        private readonly string _connectionStrings;
        public IDbConnection Connection => new SqlConnection(_connectionStrings);

        public BaseRepositorio(IConfiguration configuration, DbStefanini context)
        {
            Context = context;
            _dbSet = context.Set<T>();
            _connectionStrings = configuration.GetConnectionString("dbstefanini");
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
