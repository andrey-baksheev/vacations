CREATE TABLE [dbo].[tAttributes]
(
	[AttributeId] INT IDENTITY (1,1) NOT NULL
	,[Description] nvarchar(256) NOT NULL
	,CONSTRAINT PK_tAttributes_AttributeId PRIMARY KEY CLUSTERED (AttributeId)
	,CONSTRAINT UQ_tAttributes_Description UNIQUE ([Description]) 
)
