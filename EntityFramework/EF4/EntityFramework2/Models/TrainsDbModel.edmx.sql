
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/02/2018 15:34:58
-- Generated from EDMX file: D:\BizRunTime\EntityFramework\EntityFramework\EntityFramework1\EntittyFramework\EntityFramework2\Models\TrainsDbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ramu];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tblTrains]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblTrains];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tblTrains'
CREATE TABLE [dbo].[tblTrains] (
    [TrainNo] int IDENTITY(1,1) NOT NULL,
    [TrainName] nvarchar(max)  NOT NULL,
    [Departcher] nvarchar(max)  NOT NULL,
    [Destination] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TrainNo] in table 'tblTrains'
ALTER TABLE [dbo].[tblTrains]
ADD CONSTRAINT [PK_tblTrains]
    PRIMARY KEY CLUSTERED ([TrainNo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------