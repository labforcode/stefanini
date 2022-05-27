using Microsoft.AspNetCore.Mvc;
using TesteStefanini.Cadastros.Aplicacoes.DTOs.Cidades;
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
        public IActionResult Adicionar([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _cidadeAppService.Adicionar(cidadeDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpPut]
        [Route("cidade")]
        public IActionResult Atualizar([FromBody] CidadeDto cidadeDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Dados inválidos.");
                }

                _cidadeAppService.Atualizar(cidadeDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpDelete]
        [Route("cidade/id/{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                var cidadeDto = new CidadeDto { Id = id };

                _cidadeAppService.Excluir(cidadeDto);

                return Accepted();
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cidade/id/{id}")]
        public async Task<IActionResult> ObterPorIdAsync(int id)
        {
            try
            {
                var cidade = await _cidadeAppService.ObterPorIdAsync(id);

                return Ok(cidade);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cidade/nome/{nome}")]
        public async Task<IActionResult> ObterPorNomeAsync(string nome)
        {
            try
            {
                var cidade = await _cidadeAppService.ObterPorNomeAsync(nome);

                return Ok(cidade);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cidade/uf/{uf}")]
        public async Task<IActionResult> ObterPorUfAsync(string uf)
        {
            try
            {
                var cidades = await _cidadeAppService.ObterPorUfAsync(uf);

                return Ok(cidades);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }

        [HttpGet]
        [Route("cidades")]
        public async Task<IActionResult> ObterTodosAsync()
        {
            try
            {
                var cidades = await _cidadeAppService.ObterTodosAsync();

                return Ok(cidades);
            }
            catch (Exception)
            {
                return StatusCode(500, "Serviço indisponível, tente novamente mais tarde");
            }
        }
    }
}
