**Endpoints**


Verbo   Endpoint                 Parâmetro  Body          

- [x] GET     /Tarefa/{id}             id         N/A           
- [x] PUT     /Tarefa/{id}             id         Schema Tarefa 
- [x] DELETE  /Tarefa/{id}             id         N/A           
- [ ] GET     /Tarefa/ObterTodos       N/A        N/A           
- [ ] GET     /Tarefa/ObterPorTitulo   titulo     N/A           
- [ ] GET     /Tarefa/ObterPorData     data       N/A           
- [ ] GET     /Tarefa/ObterPorStatus   status     N/A           
- [x] POST    /Tarefa                  N/A        Schema Tarefa 

Esse é o schema (model) de Tarefa, utilizado para passar para os métodos que exigirem

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```