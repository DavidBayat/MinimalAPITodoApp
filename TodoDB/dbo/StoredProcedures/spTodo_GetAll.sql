CREATE PROCEDURE [dbo].[spTodo_GetAll]
AS
begin
	select Id, TodoTitle, TodoDescription
	from dbo.Todo;
end
