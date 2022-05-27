using AutoMapper;
using TesteStefanini.Cadastros.Aplicacoes.DTOs.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.DTOs.Pessoas;
using TesteStefanini.Cadastros.Dominios.Comandos.Cidades;
using TesteStefanini.Cadastros.Dominios.Comandos.Pessoas;

namespace TesteStefanini.Cadastros.Aplicacoes.Automapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<CidadeDto, CidadeComando>();
            CreateMap<PessoaDto, PessoaComando>();
        }
    }
}
