using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tasks
{
    public class EditTaskUseCase
    {
        public TaskResponse Execute(int id, TaskRequest tarefa)
        {          
            return new TaskResponse
            {
                Id = id,
                Name = tarefa.Name,
                Description = tarefa.Description,
                Priority = tarefa.Priority,
                LimitDate = tarefa.LimitDate,
                Status = tarefa.Status
            };
        }
    }
}
