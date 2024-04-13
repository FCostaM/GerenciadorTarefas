namespace GerenciadorTarefas.Communication.Contants
{
    public static class ResponseMessage
    {
        public const string CREATED = "Registro inserido com sucesso";

        public const string UPDATED = "Registro atualizado com sucesso";

        public const string ACCESS_GRANTED = "Acesso liberado";

        public const string NO_DATA_FOUND = "Registro não encontrado";

        public const string UNKNOW_ERROR = "Erro desconhecido";

        public const string PAST_DATE = "Data limite deve ser maior que a data atual";

        public const string INVALID_ID = "ID inválido";

        public const string INVALID_NAME = "Nome da tarefa deve ser informado";

        public const string INVALID_DEESCRIPTION = "Descerição da tarefa deve ser informada";

        public const string INVALID_PRIORITY = "Valor de prioridade inválido";

        public const string INVALID_STATUS = "Valor de status inválido";

    }
}
