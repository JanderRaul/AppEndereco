using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppCadastro_WebApi.Data;

namespace AppCadastro_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IRepository _repo;
        
        public EnderecoController(IRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("");
        }

        [HttpGet("cep/{ClienteCEP}")]
        public async Task<IActionResult> GetCEP(string cep)
        {            
            try
            {
                var cliente = await _repo.GetClienteByCEP(cep);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}
