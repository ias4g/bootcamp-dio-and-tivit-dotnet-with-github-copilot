using api_with_entity_framework.Context;
using Microsoft.AspNetCore.Mvc;

namespace api_with_entity_framework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        // private readonly OrganizadorContext _ctx;

        // public TarefaController(OrganizadorContext ctx)
        // {
        //     _ctx = ctx;
        // }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            return Ok($"Ainda será implementado a busca no BD! {id}");
        }
    }
}