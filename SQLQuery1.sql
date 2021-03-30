CREATE DATABASE [Contacts];
GO

USE [Contacts];
GO

CREATE TABLE [Contact] (
    [ContactId]  INT IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [Address]    NVARCHAR (50) NOT NULL,
    [Phone]      NVARCHAR (50) NOT NULL,
    [Email]      NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ContactId] ASC)
);
GO

INSERT INTO [Contact] (Name, Address, Phone, Email) VALUES
        ('Ivan Ivanov', '11, G. Izmirliev ul., Blagoevgrad', '088 123 456', 'iivanov@abv.bg'), 
        ('Petar Petrov', '12 Tsar Boris III blv., Sofia', '089 234 567', 'ppetrov@abv.bg'), 
		('Maria Marinova', '21 V. Levski ul., Bansko', '088 345 678', 'marinova@abv.bg'),
		('Elena Elenova', '34 Y. Sandanski ul., Sandanski', '089 456 789', 'eelenova@abc.bg'),
		('Georgi Georgiev', '45 H. Botev ul., Vratsa', '088 987 654', 'ggeorgiev@abv.bg')
GO
