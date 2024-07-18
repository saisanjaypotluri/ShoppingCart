CREATE TABLE [dbo].[Products] (
[ProductID] INT IDENTITY (1, 1) NOT NULL,
[ProductTab] NVARCHAR (30) NOT NULL,
[ProductName] NVARCHAR (50) NULL,
[ImageFile] NVARCHAR (30) NULL,
[UnitPrice] DECIMAL (18, 2) NOT NULL,
[MaxAmount] INT NOT NULL,
[DefaultAmount] INT NOT NULL,
PRIMARY KEY CLUSTERED ([ProductID] ASC)
);