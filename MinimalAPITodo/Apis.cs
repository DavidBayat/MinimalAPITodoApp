global using DataAccess.Data;
using DataAccess.Models;

namespace MinimalAPITodo;

public static class Apis
{
    public static void ConfigureApis(this WebApplication app)
    {
        // API ENDPOINTS
        app.MapGet(pattern:"/Todos", GetTodos);
        app.MapGet(pattern:"/Todos/{id}", GetTodo);
        app.MapPost(pattern:"/Todos", InsertTodo);
        app.MapPut(pattern: "/Todos", UpdateTodo);
        app.MapDelete(pattern: "/Todos", DeleteTodo);
    }

    private static async Task<IResult> GetTodos(ITodoData data)
    {
        try
        {
            return Results.Ok(await data.GetTodos());
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetTodo(int id, ITodoData data)
    {
        try
        {
            var results = await data.GetTodo(id);
            return results == null ? Results.NotFound() : Results.Ok(results);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertTodo(TodoModel todo, ITodoData data)
    {
        try
        {
            await data.InsertTodo(todo);
            return Results.Ok();

        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateTodo(TodoModel todo, ITodoData data)
    {
        try
        {
            await data.UpdateTodo(todo);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteTodo(int id, ITodoData data)
    {
        try
        {
            await data.DeleteTodo(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
    


}
