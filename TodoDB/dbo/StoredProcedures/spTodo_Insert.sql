CREATE PROCEDURE [dbo].[spTodo_Insert]
	@TodoTitle nvarchar(50),
	@TodoDescription nvarchar(140)
AS
begin
	insert into dbo.[Todo] (TodoTitle, TodoDescription)
	values (@TodoTitle, @TodoDescription);
end