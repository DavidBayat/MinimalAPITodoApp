CREATE PROCEDURE [dbo].[spTodo_Update]
	@Id int,
	@TodoTitle nvarchar(50),
	@TodoDescription nvarchar(140)
AS
begin
	update dbo.[Todo]
	set TodoTitle = @TodoTitle, TodoDescription = @TodoDescription
	where Id = @Id;
end
