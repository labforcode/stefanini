using Microsoft.AspNetCore.Mvc;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Cidades;

namespace TesteStefanini.WebApi.Controllers
{
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeAppService _cidadeAppService;

        public CidadeController(ICidadeAppService cidadeAppService)
        {
            _cidadeAppService = cidadeAppService;
        }

        [HttpPost]
        [Route("cidade")]
        public IActionResult Cadastrar()
        {
            try
            {


                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpPut]
        [Route("cidade")]
        public IActionResult Atualizar()
        {
            try
            {


                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cidade/id/{id}")]
        public IActionResult ObterPorId(int id)
        {
            try
            {


                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cidade/nome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            try
            {


                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cidade/uf/{uf}")]
        public IActionResult ObterPorUf()
        {
            try
            {


                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cidades")]
        public IActionResult ObterTodos()
        {
            try
            {


                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }
    }
}
