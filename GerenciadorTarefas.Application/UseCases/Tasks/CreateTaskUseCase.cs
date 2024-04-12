using GerenciadorTarefas.Communication.Contants;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using GerenciadorTarefas.Exceptions;

namespace GerenciadorTarefas.Application.UseCases.Tasks
{
    public class CreateTaskUseCase
    {
        public TaskResponse Execute(TaskRequest tarefa)
        {
            if (tarefa.LimitDate < DateTime.Now)
            {
                throw new BadRequestException(ResponseMessage.PAST_DATE);
            }

            return new TaskResponse
            {
                Id = new Random().Next(1, 100),
                Name = tarefa.Name,
                Description = tarefa.Description,
                LimitDate = tarefa.LimitDate,
                Priority = tarefa.Priority,
                Status = tarefa.Status
            };
        }
    }
}
