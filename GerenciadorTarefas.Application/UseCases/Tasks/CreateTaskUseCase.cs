using GerenciadorTarefas.Communication.Requests;
using GerenciadorTarefas.Communication.Responses;
using System.ComponentModel;

namespace GerenciadorTarefas.Application.UseCases.Tasks
{
    public class CreateTaskUseCase
    {
        public TaskResponse Execute(TaskRequest tarefa)
        {
            

            return new TaskResponse
            {
                Id = 1,
                Name = tarefa.Name
            };
        }
    }
}
