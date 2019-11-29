﻿/*
Deployment script for DAD

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DAD"
:setvar DefaultFilePrefix "DAD"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


Delete from Orders;
/*
Delete from Interests;
Delete from Perform;
Delete from Customers;

insert into Customers values
(123, 'Jimmy Barnes', '1 Sesame Street', 3000),
(456, 'Ian Moss', '10 Downing Street', 4000),
(789, 'Don Walker', '221B Baker Street', 5000),
(234, 'Steve Prestwich', 'LG1 College Cres, Parkville', 6000),
(567, 'Phil Small', '1 Adelaide Avenue', 7000);

insert into Interests values
('RR', 123, 'Rock and Roll'),
('JA', 456, 'Jazz'),
('RB', 789, 'Rhythm and Blues'),
('RR', 234, 'Rock and Roll'),
('RB', 567, 'Rhythm and Blues');

insert into Perform values
('PF003', 'The Wall', 'Pink Floyd'),
('IX002', 'Kick', 'INXS'),
('SP069', 'Never Mind the Bollocks', 'Sex Pistols'),
('PF002', 'The Dark Side of the Moon', 'Pink Floyd'),
('IX005', 'Shabooh Shoobah', 'INXS'),
('SP070', 'Floggin a Dead Horse', 'Sex Pistols'),
('PF004', 'The Endless River', 'Pink Floyd'),
('PF006', 'Wish You Were Here', 'Pink Floyd'),
('SP075', 'Agents of Anarchy', 'Sex Pistols'),
('PF007', 'The Division Bell', 'Pink Floyd');

Insert into Orders values
( 123, 'PF003', '2015-12-01', 30.00),
( 123, 'IX002', '2015-12-01', 29.95),
( 123, 'SP069', '2015-12-02', 12.45),
( 123, 'IX002', '2015-12-05', 30.00),
( 456, 'PF002', '2015-12-01', 31.00),
( 456, 'IX005', '2015-12-03', 28.95),
( 456, 'SP070', '2015-12-06', 13.45),
( 789, 'PF004', '2015-12-02', 29.00),
( 789, 'IX002', '2015-12-05', 29.95),
( 234, 'PF006', '2015-12-01', 45.00),
( 234, 'SP075', '2015-12-04', 5.67),
( 567, 'PF007', '2015-12-03', 9.95);
*/
GO

GO
PRINT N'Update complete.';


GO
