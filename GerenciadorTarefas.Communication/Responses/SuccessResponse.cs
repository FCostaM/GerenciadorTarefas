namespace GerenciadorTarefas.Communication.Responses
{
    public class SuccessResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public SuccessResponse(string message, T data)
        {
            Success = true;
            Message = message;
            Data = data;
        }
    }
}
