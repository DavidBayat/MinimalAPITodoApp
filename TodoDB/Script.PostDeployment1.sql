if not exists (select 1 from dbo.[Todo])
begin
	insert into dbo.[Todo] (TodoTitle, TodoDescription)
	values ('Create test', 'Do not create another calculator or todo list test'),
	('Buy David lunch', 'Message David on slack and ask if he wants to eat lunch'),
	('Be kind to new Salties', 'Show some understanding to newbies')
end