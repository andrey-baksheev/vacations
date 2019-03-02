USE Vacations
GO

ALTER TABLE [dbo].[tVacations]
DROP CONSTRAINT UQ_EmployeeId_StartDate;
GO

ALTER TABLE [dbo].[tVacations]
DROP COLUMN [Description] 
GO