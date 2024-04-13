using GerenciadorTarefas.Communication.Contants;
using GerenciadorTarefas.Communication.Enums;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using GerenciadorTarefas.Exceptions;

namespace GerenciadorTarefas.Application.UseCases.Tasks
{
    public class EditTaskUseCase
    {
        public TaskResponse Execute(int id, TaskRequest tarefa)
        {
            RequestValidation(id, tarefa);

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

        private void RequestValidation(int id, TaskRequest tarefa)
        {
            if (id <= 0)
            {
                throw new BadRequestException(ResponseMessage.INVALID_ID);
            }

            if (string.IsNullOrWhiteSpace(tarefa.Name))
            {
                throw new BadRequestException(ResponseMessage.INVALID_NAME);
            }

            if (string.IsNullOrWhiteSpace(tarefa.Description))
            {
                throw new BadRequestException(ResponseMessage.INVALID_DEESCRIPTION);
            }

            if (tarefa.LimitDate < DateTime.Now)
            {
                throw new BadRequestException(ResponseMessage.PAST_DATE);
            }

            if (!Enum.IsDefined(typeof(Priority), tarefa.Priority))
            {
                throw new BadRequestException(ResponseMessage.INVALID_PRIORITY);
            }

            if (!Enum.IsDefined(typeof(Status), tarefa.Status))
            {
                throw new BadRequestException(ResponseMessage.INVALID_STATUS);
            }
        }
    }
}
