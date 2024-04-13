using GerenciadorTarefas.Application.UseCases.Tasks;
using GerenciadorTarefas.Communication.Contants;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<TaskResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public IActionResult CreateTask([FromBody] TaskRequest tarefa)
        {
            var response = new CreateTaskUseCase().Execute(tarefa);

            return Created(string.Empty, new SuccessResponse<TaskResponse>(ResponseMessage.CREATED, response));
        }

        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<List<TaskResponse>>), StatusCodes.Status200OK)]
        public IActionResult GetAllTask()
        {
            var response = new GetAllTasksUseCase().Execute();

            return Ok(new SuccessResponse<List<TaskResponse>>(ResponseMessage.ACCESS_GRANTED, response));
        }

        [HttpGet]
        [Route("[action]/{id}")]
        [ProducesResponseType(typeof(SuccessResponse<TaskResponse>), StatusCodes.Status200OK)]
        public IActionResult GetTaskById([FromRoute] int id)
        {
            var response = new GetTaskByIdUseCase().Execute(id);

            return Ok(new SuccessResponse<TaskResponse>(ResponseMessage.ACCESS_GRANTED, response));
        }

        [HttpPut]
        [Route("[action]/{id}")]
        [ProducesResponseType(typeof(SuccessResponse<TaskResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        public IActionResult EditTask([FromRoute] int id, [FromBody] TaskRequest tarefa)
        {
            var response = new EditTaskUseCase().Execute(id, tarefa);

            return Ok(new SuccessResponse<TaskResponse>(ResponseMessage.UPDATED, response));
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteTask([FromRoute] int id)
        {
            new DeleteTaskUseCase().Execute(id);

            return NoContent();
        }
    }
}
