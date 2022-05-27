using Dapper;
using Microsoft.Extensions.Configuration;
using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

namespace TesteStefanini.Cadastros.Infra.Data.Repositorios.Cidades
{
    public class CidadeRepositorio : BaseRepositorio<Cidade>, ICidadeRepositorio
    {
        private readonly string _query = @"SELECT c.id AS ""Id"",
                                                  c.nome AS ""Nome"",
                                                  c.uf AS ""Uf"" 
                                           FROM [dbstefanini].[dbo].[cidades] AS c";

        public CidadeRepositorio(IConfiguration configuration, DbStefanini context) : base(configuration, context)
        {
        }

        public async Task<Cidade> ObterPorIdAsync(int id)
        {
            try
            {
                using var connection = Connection;
                var query = $@"{_query} 
                             WHERE c.id = @value_id;";

                return await connection.QueryFirstOrDefaultAsync<Cidade>(query, new { value_id = id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Cidade> ObterPorNomeAsync(string nome)
        {
            try
            {
                using var connection = Connection;
                var query = $@"{_query} 
                             WHERE c.nome = @value_nome;";

                return await connection.QueryFirstOrDefaultAsync<Cidade>(query, new { value_nome = nome });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<Cidade>> ObterPorUfAsync(string uf)
        {
            try
            {
                using var connection = Connection;
                var query = $@"{_query} 
                             WHERE c.uf = @value_uf;";

                return await connection.QueryAsync<Cidade>(query, new { value_uf = uf });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<Cidade>> ObterTodosAsync()
        {
            try
            {
                using var connection = Connection;

                return await connection.QueryAsync<Cidade>(_query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
