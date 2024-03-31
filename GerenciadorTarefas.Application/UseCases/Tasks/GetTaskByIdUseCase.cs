using GerenciadorTarefas.Communication.Enums;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tasks
{
    public class GetTaskByIdUseCase
    {
        public TaskResponse Execute(int id)
        {
            return new TaskResponse()
            {
                Id = id,
                Name = "Desafio prático - Fundamentos de C-Sharp",
                Description = "Resolver exercícios práticos do módulo de Fundamentos do C#",
                Priority = Priority.BAIXA,
                LimitDate = DateTime.Now.AddDays(15),
                Status = Status.CONCLUIDA
            };
        }
    }
}
