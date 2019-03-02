CREATE TABLE [dbo].[tEmpAttributes]
(
	[EmployeeId] INT NOT NULL 
	,[AttributeId] INT NOT NULL
	,[Value] NVARCHAR(256) NOT NULL
	,CONSTRAINT FK_tEmpAttributes_tEmployees FOREIGN KEY (EmployeeId)
    REFERENCES tEmployees (EmployeeId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
	,CONSTRAINT FK_tEmpAttributes_tAttributes FOREIGN KEY (AttributeId)
    REFERENCES tAttributes (AttributeId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION	
)
