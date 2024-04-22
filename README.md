# Gerenciador de Tarefas Simples

Resolução do desafio prático proposto pelo curso de C# ofertado pela RocketSeat. O objetivo é desenvolver uma API simples para um sistema Gerenciador de tarefas. O sistema permite o usuário criar, visualizar, editar e excluir uma tarefa.

> **Nota:** Esta API não realiza conexão com banco de dados. Todos os dados cadastrados ou retornados estçao fixos no código.

## Documentação da API

### Criar uma nova tarefa

```http
POST /SimpleTask/
```

Cria uma nova tarefa com os seguintes campos informados no `body` da requisição:

| Parameter | Type | Description |
| :--- | :--- | :--- |
| `name` | `string` | Nome da tarefa |
| `description` | `string` | Descrição sobre o que é a tarefa em si. |
| `priority` | `enum` | Prioridade da tarefa, podendo ser `alta`, `media` ou `baixa`|
| `limitdate` | `datetime` | Data limite para tarefa ser realizada. |
| `status` | `enum` | Status atual da tarefa,  podendo ser `concluido`, `em andamento` ou `aguardando` |

- Exemplo de requisição:

```json
{
  "name": "string",
  "description": "string",
  "priority": 0,
  "limitDate": "2024-04-22T18:15:26.059Z",
  "status": 0
}
```

- Exemplo de retorno:

```json
{
  "success": true,
  "message": "string",
  "data": {
    "id": 0,
    "name": "string",
    "description": "string",
    "priority": 0,
    "limitDate": "2024-04-22T18:16:21.191Z",
    "status": 0
  }
}
```

### Consultar todas as tarefas

```http
GET /SimpleTask/
```

Retorna uma lista de todas as tarefas cadastradas.

- Exemplo de retorno: 

```json
{
  "success": true,
  "message": "string",
  "data": [
    {
      "id": 0,
      "name": "string",
      "description": "string",
      "priority": 0,
      "limitDate": "2024-04-22T18:16:21.188Z",
      "status": 0
    }
  ]
}
```

### Consultar uma tarefa

```http
GET /SimpleTask/{id}
```

Consulta uma nova tarefa cadastrada a partir do Id unico dela.

| Parameter | Type | Description |
| :--- | :--- | :--- |
| `id` | `int` | Id único da tarefa |

```json
{
  "success": true,
  "message": "string",
  "data": {
    "id": 0,
    "name": "string",
    "description": "string",
    "priority": 0,
    "limitDate": "2024-04-22T18:16:21.191Z",
    "status": 0
  }
}
```

### Editar uma nova tarefa

```http
PUT /SimpleTask/{id}
```

Edita uma tarefa já criada a partir do seu Id único com as informações contidas no `body`.

| Parameter | Type | Description |
| :--- | :--- | :--- |
| `id` | `int` | Id único da tarefa |
| `name` | `string` | Nome da tarefa |
| `description` | `string` | Descrição sobre o que é a tarefa em si. |
| `priority` | `enum` | Prioridade da tarefa, podendo ser `alta`, `media` ou `baixa`|
| `limitdate` | `datetime` | Data limite para tarefa ser realizada. |
| `status` | `enum` | Status atual da tarefa,  podendo ser `concluido`, `em andamento` ou `aguardando` |

- Exemplo de requisição:

```json
{
  "name": "string",
  "description": "string",
  "priority": 0,
  "limitDate": "2024-04-22T18:15:26.059Z",
  "status": 0
}
```

- Exemplo de retorno:

```json
{
  "success": true,
  "message": "string",
  "data": {
    "id": 0,
    "name": "string",
    "description": "string",
    "priority": 0,
    "limitDate": "2024-04-22T18:16:21.191Z",
    "status": 0
  }
}
```

### Excluir uma tarefa

```http
DELETE /SimpleTask/{id}
```

Exclui uma nova tarefa a partir do seu id. Esse método não possui retorno.

| Parameter | Type | Description |
| :--- | :--- | :--- |
| `id` | `int` | Id único da tarefa |
