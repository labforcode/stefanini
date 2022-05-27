using AutoMapper;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.ViewModels.Pessoas;
using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;
using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;

namespace TesteStefanini.Cadastros.Aplicacoes.Automapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cidade, CidadeViewModel>();
            CreateMap<Pessoa, PessoaViewModel>();
        }
    }
}
