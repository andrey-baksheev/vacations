CREATE TABLE [dbo].[tEmployees]
(
	[EmployeeId] INT IDENTITY (1,1) NOT NULL
	,[Lastname] nvarchar(256) NOT NULL
	,[Firstname] nvarchar(256) NOT NULL
	,[Secondname] nvarchar(256)
	,CONSTRAINT PK_tEmployees_EmployeeId PRIMARY KEY CLUSTERED (EmployeeId)  
	,CONSTRAINT UQ_tEmployees_FullName UNIQUE ([Lastname], [Firstname], [Secondname]) 
)
