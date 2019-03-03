USE Vacations
GO

ALTER TABLE [dbo].[tEmpAttributes]
ADD CONSTRAINT UQ_tEmpAttributes_AttributeId_EmployeeId UNIQUE (AttributeId,EmployeeId);
GO
