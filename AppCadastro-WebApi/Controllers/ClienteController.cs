using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppCadastro_WebApi.Data;

namespace AppCadastro_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IRepository _repo;
        
        public ClienteController(IRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllClientes(true);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ClienteNome}")]
        public async Task<IActionResult> GetNome(string nome)
        {            
            try
            {
                var cliente = await _repo.GetClienteByNome(nome);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("cpf/{ClienteCPF}")]
        public async Task<IActionResult> GetCPFs(string cpf)
        {            
            try
            {
                var cliente = await _repo.GetClienteByCPF(cpf);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        /*

        [HttpGet("{ClienteCPF}")]
        public async Task<IActionResult> GetByClienteCPF(string ClienteCPF)
        {
            try
            {
                var result = await _repo.GetClienteByCPF(ClienteCPF);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ClienteCEP}")]
        public async Task<IActionResult> GetByClienteCEP(string ClienteCEP)
        {
            try
            {
                var result = await _repo.GetClienteByCEP(ClienteCEP);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ClienteCEP}")]
        public async Task<IActionResult> GetByClienteCEP(string CEPEndereco)
        {
            try
            {
                var result = await _repo.GetClienteByCEP(CEPEndereco);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ClienteCEP}")]
        public async Task<IActionResult> GetByClienteCEP(string CEPEndereco)
        {
            try
            {
                var result = await _repo.GetClienteByCEP(CEPEndereco);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
        
        [HttpGet("{ClienteStatus}")]
        public async Task<IActionResult> GetByClienteStatus(string ClienteStatus)
        {
            try
            {
                var result = await _repo.GetClienteByStatus(ClienteStatus);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ClienteStatus}")]
        public async Task<IActionResult> GetByEnderecoClienteId(int ClienteId)
        {
            try
            {
                var result = await _repo.GetEnderecosByClienteId(ClienteId);
                return Ok("");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        */

    }
}
