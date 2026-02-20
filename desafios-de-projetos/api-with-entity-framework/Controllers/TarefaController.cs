using api_with_entity_framework.Context;
using api_with_entity_framework.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("ObterTodas")]
        public IActionResult GetAllTask()
        {
            var tasks = _ctx.tarefas.ToList();

            return Ok(tasks);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult GetTaskByTitle([FromQuery] string title)
        {
            var tasksByTitle = _ctx.tarefas.Where(t => EF.Functions.Like(t.Titulo, $"%{title}%")).ToList();

            if (tasksByTitle.Count == 0) return NotFound($"Ops, Nehuma tarefa encontrada com o titulo [{title}]");

            return Ok(tasksByTitle);
        }

        [HttpGet("ObterPorData")]
        public IActionResult GetTaskByDate([FromQuery] DateTime date)
        {
            var tasksByDate = _ctx.tarefas.Where(t => t.Data.Date == date.Date).ToList();

            if (tasksByDate.Count == 0)
            {
                return NotFound(new
                {
                    error = true,
                    mensagem = "Nenhuma tarefa encontrada",
                    data = date.ToString("yyyy-MM-dd"),
                });
            }

            return Ok(tasksByDate);
        }

        [HttpGet("ObterPorStatus/{status}")]
        public IActionResult GetTaskByStatus(EnumStatusTarefa status)
        {
            var taskByStatus = _ctx.tarefas.Where(t => t.EnumStatus == status).ToList();

            if (taskByStatus.Count == 0)
            {
                return NotFound(new
                {
                    error = true,
                    mensagem = $"Nenhuma tarefa encontrada com status {status}"
                });
            }

            return Ok(taskByStatus);
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