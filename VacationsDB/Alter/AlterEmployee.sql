USE Vacations
GO

ALTER TABLE [dbo].[tEmployees]
DROP CONSTRAINT UQ_tEmployees_FullName;
GO

EXEC sp_rename 'dbo.tEmployees.Lastname', 'Fullname', 'COLUMN'; 
GO

ALTER TABLE [dbo].[tEmployees]
ADD CONSTRAINT UQ_tEmployees_Fullname UNIQUE ([Fullname]) 
GO

ALTER TABLE [dbo].[tEmployees]
DROP COLUMN [Firstname], [Secondname] 
GO