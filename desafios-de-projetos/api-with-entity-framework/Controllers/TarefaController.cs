using api_with_entity_framework.Context;
using api_with_entity_framework.Model;
using Microsoft.AspNetCore.Mvc;

namespace api_with_entity_framework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _ctx;

        public TarefaController(OrganizadorContext ctx)
        {
            _ctx = ctx;
        }

        [HttpPost]
        public IActionResult CreateTask(Tarefa tarefa)
        {
            _ctx.Add(tarefa);
            _ctx.SaveChanges();
            return Created();
        }

        [HttpGet("{id}")]
        public IActionResult GetTaskById(int id)
        {
            Tarefa task = _ctx.tarefas.Find(id);

            if (task == null) return NotFound("Ops, Este registro não existem, tente novamente!");

            return Ok(task);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, Tarefa task)
        {
            Tarefa getTaskBd = _ctx.tarefas.Find(id);

            if (getTaskBd == null) return NotFound("Ops, Este registro não existem, tente novamente!");

            getTaskBd.Titulo = task.Titulo;
            getTaskBd.Descricao = task.Descricao;
            getTaskBd.Data = task.Data;
            getTaskBd.EnumStatus = task.EnumStatus;

            _ctx.tarefas.Update(getTaskBd);
            _ctx.SaveChanges();

            return Ok(getTaskBd);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            Tarefa getTask = _ctx.tarefas.Find(id);

            if (getTask == null) return NotFound("Ops, Este registro não existem, tente novamente!");

            _ctx.tarefas.Remove(getTask);
            _ctx.SaveChanges();

            return NoContent();
        }
    }
}