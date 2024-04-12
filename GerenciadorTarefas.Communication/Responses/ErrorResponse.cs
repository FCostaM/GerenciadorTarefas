namespace GerenciadorTarefas.Communication.Responses
{
    public class ErrorResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public ErrorResponse(string message)
        {
            Success = false;
            Message = message;
        }
    }
}
