﻿CREATE TABLE [dbo].[Todo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TodoTitle] NVARCHAR(50) NOT NULL, 
    [TodoDescription] NVARCHAR(140) NULL
)
