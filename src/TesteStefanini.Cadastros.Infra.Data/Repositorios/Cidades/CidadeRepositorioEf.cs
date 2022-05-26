﻿using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

namespace TesteStefanini.Cadastros.Infra.Data.Repositorios.Cidades
{
    public class CidadeRepositorioEf : BaseRepositorioEf<Cidade>, ICidadeRepositorioEf
    {
        public CidadeRepositorioEf(DbStefanini context) : base(context)
        {
        }
    }
}
