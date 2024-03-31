using GerenciadorTarefas.Communication.Enums;
using GerenciadorTarefas.Communication.Responses;

namespace GerenciadorTarefas.Application.UseCases.Tasks
{
    public class GetAllTasksUseCase
    {
        public List<TaskResponse> Execute()
        {
            //business logic

            return new List<TaskResponse>()
            {
                new TaskResponse()
                {
                    Id = 1,
                    Name = "Desafio prático - Fundamentos de C-Sharp",
                    Description = "Resolver exercícios práticos do módulo de Fundamentos do C#",
                    Priority = Priority.BAIXA,
                    LimitDate = DateTime.Now.AddDays(15),
                    Status = Status.CONCLUIDA
                },
                new TaskResponse()
                {
                    Id = 2,
                    Name = "Desafio prático - Gestão de Livraria",
                    Description = "Desenvolver uma API para uma Livraria online.",
                    Priority = Priority.MEDIA,
                    LimitDate = DateTime.Now.AddDays(30),
                    Status = Status.EM_ANDAMENTO
                },
                new TaskResponse()
                {
                    Id = 3,
                    Name = "Desafio prático - Gerenciador de tarefas",
                    Description = "Desenvolder API para um sistema Gerenciador de tarefas.",
                    Priority = Priority.MEDIA,
                    LimitDate = DateTime.Now.AddDays(60),
                    Status = Status.EM_ANDAMENTO
                }
            };
        }
    }
}
