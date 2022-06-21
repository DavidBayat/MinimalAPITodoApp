using DataAccess.Models;

namespace DataAccess.Data;
public interface ITodoData
{
    Task DeleteTodo(int id);
    Task<TodoModel?> GetTodo(int id);
    Task<IEnumerable<TodoModel>> GetTodos();
    Task InsertTodo(TodoModel todo);
    Task UpdateTodo(TodoModel todo);
}
