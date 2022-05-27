using Microsoft.AspNetCore.Mvc;
using TesteStefanini.Cadastros.Aplicacoes.DTOs.Pessoas;
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
        public IActionResult Adicionar([FromBody] PessoaDto pessoaDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _pessoaAppService.Adicionar(pessoaDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpPut]
        [Route("pessoa")]
        public IActionResult Atualizar([FromBody] PessoaDto pessoaDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _pessoaAppService.Atualizar(pessoaDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpDelete]
        [Route("pessoa/id/{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                var pessoaDto = new PessoaDto { Id = id };

                _pessoaAppService.Excluir(pessoaDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("pessoa/id/{id}")]
        public async Task<IActionResult> ObterPorIdAsync(int id)
        {
            try
            {
                var pessoa = await _pessoaAppService.ObterPorIdAsync(id);

                return Ok(pessoa);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("pessoa/cpf/{cpf}")]
        public async Task<IActionResult> ObterPorCpfAsync(string cpf)
        {
            try
            {
                var pessoa = await _pessoaAppService.ObterPorCpfAsync(cpf);

                return Ok(pessoa);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> ObterTodosAsync()
        {
            try
            {
                var pessoas = await _pessoaAppService.ObterTodosAsync();

                return Ok(pessoas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }
    }
}
