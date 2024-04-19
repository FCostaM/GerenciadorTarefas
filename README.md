# Gerenciador de Tarefas Simples

Resolução do desafio prático proposto pelo curso de C# ofertado pela RocketSeat. O objetivo é desenvolver uma API simples para um sistema Gerenciador de tarefas. O sistema permite o usuário criar, visualizar, editar e excluir uma tarefa.

> **Nota:** Esta API não realiza conexão com banco de dados. Todos os dados cadastrados ou retornados estçao fixos no código.
> 
## Documentação da API

### Criar uma nova tarefa

```http
POST SimpleTask/
```

Cria uma nova tarefa com os seguintes campos no corpo da requisição:

| Parameter | Type | Description |
| :--- | :--- | :--- |
| `name` | `string` | Nome da tarefa |
| `description` | `string` | Descrição sobre o que é a tarefa em si. |
| `priority` | `enum` | Prioridade da tarefa, podendo ser `alta`, `media` ou `baixa`|
| `limitdate` | `datetime` | Data limite para tarefa ser realizada. |
| `status` | `enum` | Status atual da tarefa,  podendo ser `concluido`, `em andamento` ou `aguardando` |
