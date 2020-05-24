
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/12/2020 13:05:28
-- Generated from EDMX file: D:\Fac\Tsp.Net\Proiect\Project1\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Proiect];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Phodeos'
CREATE TABLE [dbo].[Phodeos] (
    [justID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Size] nvarchar(max)  NOT NULL,
    [cDate] nvarchar(max)  NOT NULL,
    [mDate] nvarchar(max)  NOT NULL,
    [Extension] nvarchar(max)  NOT NULL,
    [Resolution] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [justID] in table 'Phodeos'
ALTER TABLE [dbo].[Phodeos]
ADD CONSTRAINT [PK_Phodeos]
    PRIMARY KEY CLUSTERED ([justID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------