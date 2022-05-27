using Dapper;
using Microsoft.Extensions.Configuration;
using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Pessoas;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

namespace TesteStefanini.Cadastros.Infra.Data.Repositorios.Pessoas
{
    public class PessoaRepositorio : BaseRepositorio<Pessoa>, IPessoaRepositorio
    {
        private readonly string _query = @"SELECT p.id AS ""Id"" ,
                                                  p.cpf AS ""Cpf"" ,
                                                  p.nome AS ""Nome"" ,
                                                  p.data_nascimento AS ""DataNascimento"" ,
                                                  p.cidade_id AS ""CidadeId"" ,
                                                  c.nome AS ""Cidade"" ,
                                                  c.uf AS ""Uf"" 
                                           FROM [dbstefanini].[dbo].[pessoas] AS p
                                           INNER JOIN [dbstefanini].[dbo].[cidades] AS c ON(p.cidade_id = c.id) ";

        public PessoaRepositorio(IConfiguration configuration, DbStefanini context) : base(configuration, context)
        {
        }

        public async Task<dynamic> ObterPorCpfAsync(string cpf)
        {
            try
            {
                using var connection = Connection;
                var query = $@"{_query} 
                             WHERE p.cpf = @value_cpf;";

                return await connection.QueryFirstOrDefaultAsync<dynamic>(query, new { value_cpf = cpf });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<dynamic> ObterPorIdAsync(int id)
        {
            try
            {
                using var connection = Connection;
                var query = $@"{_query} 
                             WHERE p.id = @value_id;";

                return await connection.QueryFirstOrDefaultAsync<dynamic>(query, new { value_id = id });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<Pessoa> ObterPessoaPorCpfAsync(string cpf)
        {
            try
            {
                using var connection = Connection;
                var query = $@"SELECT p.id AS ""Id"" ,
                                      p.cpf AS ""Cpf"" ,
                                      p.nome AS ""Nome"" ,
                                      p.data_nascimento AS ""DataNascimento"" ,
                                      p.cidade_id AS ""CidadeId""
                               FROM [dbstefanini].[dbo].[pessoas] AS p
                               WHERE p.cpf = @value_cpf;";

                return await connection.QueryFirstOrDefaultAsync<Pessoa>(query, new { value_cpf = cpf });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<dynamic>> ObterTodosAsync()
        {
            try
            {
                using var connection = Connection;

                return await connection.QueryAsync<dynamic>(_query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
