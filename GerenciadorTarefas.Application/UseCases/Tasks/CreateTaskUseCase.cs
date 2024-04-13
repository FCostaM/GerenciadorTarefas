using GerenciadorTarefas.Communication.Contants;
using GerenciadorTarefas.Communication.Enums;
using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using GerenciadorTarefas.Exceptions;

namespace GerenciadorTarefas.Application.UseCases.Tasks
{
    public class CreateTaskUseCase
    {
        public TaskResponse Execute(TaskRequest tarefa)
        {
            RequestValidation(tarefa);

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

        private void RequestValidation(TaskRequest tarefa)
        {
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

            if(!Enum.IsDefined(typeof(Status), tarefa.Status))
            {
                throw new BadRequestException(ResponseMessage.INVALID_STATUS);
            }
        }
    }
}
