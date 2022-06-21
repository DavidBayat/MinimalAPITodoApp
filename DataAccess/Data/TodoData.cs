using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class TodoData : ITodoData
{
    private readonly ISqlDataAccess _db;

    public TodoData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<TodoModel>> GetTodos() =>
        _db.LoadData<TodoModel, dynamic>(storedProcedure: "dbo.spTodo_GetAll", new { });

    public async Task<TodoModel?> GetTodo(int id)
    {
        var results = await _db.LoadData<TodoModel, dynamic>(storedProcedure: "dbo.spTodo_Get",
            new { Id = id });

        return results.FirstOrDefault();
    }

    public Task InsertTodo(TodoModel todo) =>
        _db.SaveData(storedProcedure: "dbo.spTodo_Insert", new { todo.TodoTitle, todo.TodoDescription });

    public Task UpdateTodo(TodoModel todo) =>
        _db.SaveData(storedProcedure: "dbo.spTodo_Update", todo);

    public Task DeleteTodo(int id) =>
        _db.SaveData(storedProcedure: "dbo.spTodo_Delete", new { Id = id });

}
