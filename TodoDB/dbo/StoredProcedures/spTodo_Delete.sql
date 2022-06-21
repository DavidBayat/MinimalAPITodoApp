CREATE PROCEDURE [dbo].[spTodo_Delete]
	@Id int
AS
begin
	delete
	from dbo.Todo
	where Id = @Id;
end