CREATE PROCEDURE [dbo].[spTodo_Get]
	@Id int
AS
begin
	select Id, TodoTitle, TodoDescription
	from dbo.Todo
	where Id = @Id;
end