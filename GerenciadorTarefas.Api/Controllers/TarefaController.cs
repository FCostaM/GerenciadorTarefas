using GerenciadorTarefas.Application.UseCases.Tasks;
using GerenciadorTarefas.Communication.Helpers;
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
        [ProducesResponseType(typeof(ApiResponse<TaskResponse>), StatusCodes.Status201Created)]
        public IActionResult CreateTask([FromBody] TaskRequest tarefa)
        {
            try
            {
                var response = new CreateTaskUseCase().Execute(tarefa);

                return Created(string.Empty, new ApiResponse<TaskResponse>(true, ResponseMessage.CREATED, response));
            }
            catch (Exception)
            {

                throw;
            }            
        }

        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(ApiResponse<List<TaskResponse>>), StatusCodes.Status200OK)]
        public IActionResult GetAllTask()
        {
            try
            {
                var response = new GetAllTasksUseCase().Execute();
                
                return Ok(new ApiResponse<List<TaskResponse>>(true, ResponseMessage.ACCESS_GRANTED, response));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("[action]/{id}")]
        [ProducesResponseType(typeof(ApiResponse<TaskResponse>), StatusCodes.Status200OK)]
        public IActionResult GetTaskById([FromRoute] int id)
        {
            try
            {
                var response = new GetTaskByIdUseCase().Execute(id);

                return Ok(new ApiResponse<TaskResponse>(true, ResponseMessage.ACCESS_GRANTED, response));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        [Route("[action]/{id}")]
        [ProducesResponseType(typeof(ApiResponse<TaskResponse>), StatusCodes.Status200OK)]
        public IActionResult EditTask([FromRoute] int id, [FromBody] TaskRequest tarefa)
        {
            try
            {
                var response = new EditTaskUseCase().Execute(id, tarefa);

                return Ok(new ApiResponse<TaskResponse>(true, ResponseMessage.UPDATED, response));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteTask([FromRoute] int id)
        {
            try
            {
                new DeleteTaskUseCase().Execute(id);

                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
