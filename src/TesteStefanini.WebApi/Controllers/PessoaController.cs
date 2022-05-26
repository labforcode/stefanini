using Microsoft.AspNetCore.Mvc;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Pessoas;

namespace TesteStefanini.WebApi.Controllers
{
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaAppService _pessoaAppService;

        public PessoaController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        [HttpPost]
        [Route("pessoa")]
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
        [Route("pessoa")]
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
        [Route("pessoa/id/{id}")]
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
        [Route("pessoa/cpf/{cpf}")]
        public IActionResult ObterPorCpf(string cpf)
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
        [Route("pessoas")]
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
