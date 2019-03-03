USE Vacations
GO

ALTER TABLE [dbo].[tVacations]
DROP CONSTRAINT UQ_EmployeeId_StartDate;
GO

ALTER TABLE [dbo].[tVacations]
DROP COLUMN [Description] 
GO

ALTER TABLE [dbo].[tVacations]
DROP CONSTRAINT FK_tVacations_tEmployees;
GO

ALTER TABLE [dbo].[tVacations]
ADD CONSTRAINT FK_tVacations_tEmployees FOREIGN KEY (EmployeeId)
    REFERENCES tEmployees (EmployeeId)
    ON DELETE CASCADE
    ON UPDATE NO ACTION;
GO
