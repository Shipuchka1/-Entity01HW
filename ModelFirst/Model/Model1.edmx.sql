
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2018 21:25:08
-- Generated from EDMX file: C:\Users\user\Documents\Visual Studio 2015\Projects\Entity01HW\ModelFirst\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
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

-- Creating table 'Table1Set'
CREATE TABLE [dbo].[Table1Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Property1] nvarchar(max)  NOT NULL,
    [Property2] nvarchar(max)  NOT NULL,
    [Property3] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Table2Set'
CREATE TABLE [dbo].[Table2Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Property1] nvarchar(max)  NOT NULL,
    [Property2] nvarchar(max)  NOT NULL,
    [Property3] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Table21Set'
CREATE TABLE [dbo].[Table21Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Property1] nvarchar(max)  NOT NULL,
    [Property2] nvarchar(max)  NOT NULL,
    [Property3] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Table1Set'
ALTER TABLE [dbo].[Table1Set]
ADD CONSTRAINT [PK_Table1Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Table2Set'
ALTER TABLE [dbo].[Table2Set]
ADD CONSTRAINT [PK_Table2Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Table21Set'
ALTER TABLE [dbo].[Table21Set]
ADD CONSTRAINT [PK_Table21Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------