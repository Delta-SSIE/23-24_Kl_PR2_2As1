CREATE TABLE [dbo].[Cars]
(
--	[Id] INT NOT NULL PRIMARY KEY, 
	[Id] INT IDENTITY(1,1) PRIMARY KEY , --IDENTITY zařídí autoincrementing
    [RegPlate] VARCHAR(10) NOT NULL, 
    [Brand] VARCHAR(50) NOT NULL, 
    [Model] VARCHAR(50) NOT NULL, 
    [Purchased] DATE NOT NULL
)