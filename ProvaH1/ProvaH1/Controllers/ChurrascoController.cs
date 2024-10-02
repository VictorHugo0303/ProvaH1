using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvaH1.Models;
using ProvaH1.Service;
using System.Security.Cryptography.X509Certificates;

namespace ProvaH1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ChurrascoController : ControllerBase
    {
        private readonly IChurrascoRepository _churrascoRepository;

        public ChurrascoController(IChurrascoRepository churrascoRepository)
        {
            _churrascoRepository = churrascoRepository;
        }

        [HttpPost]
        public IActionResult Inserir(Churrasco churrasco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _churrascoRepository.Inserir(churrasco);

            return Ok($"{churrasco.Nome} inserido com sucesso.");
        }

        [HttpGet]
        public IActionResult ListarPessoas()
        {
            var churrasco = _churrascoRepository.ListarPessoas();

            return Ok(churrasco);
        }
    }
}
