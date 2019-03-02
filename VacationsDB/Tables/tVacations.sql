CREATE TABLE [dbo].[tVacations]
(
	[VacationId] INT IDENTITY (1,1) NOT NULL
	,[EmployeeId] INT NOT NULL
	,[Description] NVARCHAR(256) NOT NULL
	,[StartDate] DATE NOT NULL
	,[Duration] SMALLINT NOT NULL
	,CONSTRAINT PK_tVacations_VacationId PRIMARY KEY CLUSTERED (VacationId)
	,CONSTRAINT FK_tVacations_tEmployees FOREIGN KEY (EmployeeId)
    REFERENCES tEmployees (EmployeeId)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
	,CONSTRAINT UQ_EmployeeId_StartDate UNIQUE ([EmployeeId], [StartDate]) 
)
