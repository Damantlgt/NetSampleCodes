--region Drop Existing Procedures

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO
PRINT N'Dropping spCFM_SystemRoleType_Insert'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_SystemRoleType_Insert', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_SystemRoleType_Insert has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_SystemRoleType_Insert') IS NOT NULL
	DROP PROCEDURE spCFM_SystemRoleType_Insert

GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT>0 BEGIN
PRINT 'The stored procedure drop has succeeded'
COMMIT TRANSACTION
END
ELSE PRINT 'The stored procedure drop has failed'
GO

DROP TABLE #tmpErrors
GO
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO
PRINT N'Dropping spCFM_SystemRoleType_Update'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_SystemRoleType_Update', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_SystemRoleType_Update has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_SystemRoleType_Update') IS NOT NULL
	DROP PROCEDURE spCFM_SystemRoleType_Update

GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT>0 BEGIN
PRINT 'The stored procedure drop has succeeded'
COMMIT TRANSACTION
END
ELSE PRINT 'The stored procedure drop has failed'
GO

DROP TABLE #tmpErrors
GO
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO
PRINT N'Dropping spCFM_SystemRoleType_Delete'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_SystemRoleType_Delete', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_SystemRoleType_Delete has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_SystemRoleType_Delete') IS NOT NULL
	DROP PROCEDURE spCFM_SystemRoleType_Delete

GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT>0 BEGIN
PRINT 'The stored procedure drop has succeeded'
COMMIT TRANSACTION
END
ELSE PRINT 'The stored procedure drop has failed'
GO

DROP TABLE #tmpErrors
GO
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO
PRINT N'Dropping spCFM_SystemRoleType_Select'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_SystemRoleType_Select', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_SystemRoleType_Select has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_SystemRoleType_Select') IS NOT NULL
	DROP PROCEDURE spCFM_SystemRoleType_Select

GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT>0 BEGIN
PRINT 'The stored procedure drop has succeeded'
COMMIT TRANSACTION
END
ELSE PRINT 'The stored procedure drop has failed'
GO

DROP TABLE #tmpErrors
GO
--endregion

GO

--region [dbo].[spCFM_SystemRoleType_Insert]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_SystemRoleType_Insert]
------------------------------------------------------------------------------------------------------------------------

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO

PRINT N'Creating [dbo].[spCFM_SystemRoleType_Insert]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_SystemRoleType_Insert', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_SystemRoleType_Insert] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_SystemRoleType_Insert]
	@p_SystemRoleTypeID int,
	@p_Code varchar(50),
	@p_Name varchar(255)
AS

SET NOCOUNT ON

INSERT INTO [dbo].[SystemRoleType] (
	[SystemRoleTypeID],
	[Code],
	[Name]
) VALUES (
	@p_SystemRoleTypeID,
	@p_Code,
	@p_Name)


GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT 'Stored procedure creation succeeded.'
COMMIT TRANSACTION
END
ELSE PRINT 'Stored procedure creation failed.'
GO
DROP TABLE #tmpErrors
GO

--endregion

GO

--region [dbo].[spCFM_SystemRoleType_Update]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_SystemRoleType_Update]
------------------------------------------------------------------------------------------------------------------------

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO

PRINT N'Creating [dbo].[spCFM_SystemRoleType_Update]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_SystemRoleType_Update', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_SystemRoleType_Update] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_SystemRoleType_Update]
	@p_SystemRoleTypeID int,
	@p_OriginalSystemRoleTypeID int,
	@p_Code varchar(50),
	@p_Name varchar(255)
AS

UPDATE [dbo].[SystemRoleType] SET
	[SystemRoleTypeID] = @p_SystemRoleTypeID,
	[Code] = @p_Code,
	[Name] = @p_Name
WHERE
	[SystemRoleTypeID] = @p_OriginalSystemRoleTypeID


GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT 'Stored procedure creation succeeded.'
COMMIT TRANSACTION
END
ELSE PRINT 'Stored procedure creation failed.'
GO
DROP TABLE #tmpErrors
GO

--endregion

GO

--region [dbo].[spCFM_SystemRoleType_Delete]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_SystemRoleType_Delete]
------------------------------------------------------------------------------------------------------------------------

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO

PRINT N'Creating [dbo].[spCFM_SystemRoleType_Delete]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_SystemRoleType_Delete', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_SystemRoleType_Delete] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_SystemRoleType_Delete]
	@p_SystemRoleTypeID int
AS

DELETE FROM
    [dbo].[SystemRoleType]
WHERE
	[SystemRoleTypeID] = @p_SystemRoleTypeID

GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT 'Stored procedure creation succeeded.'
COMMIT TRANSACTION
END
ELSE PRINT 'Stored procedure creation failed.'
GO
DROP TABLE #tmpErrors
GO

--endregion

GO

--region [dbo].[spCFM_SystemRoleType_Select]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_SystemRoleType_Select]
------------------------------------------------------------------------------------------------------------------------

SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO

PRINT N'Creating [dbo].[spCFM_SystemRoleType_Select]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_SystemRoleType_Select', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_SystemRoleType_Select] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_SystemRoleType_Select]
	@p_SystemRoleTypeID int = NULL,
	@p_Code varchar(50) = NULL,
	@p_Name varchar(255) = NULL,
	@p_NameHasValue BIT = 0
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT
	[SystemRoleTypeID],
	[Code],
	[Name]
FROM
    [dbo].[SystemRoleType]
WHERE
	([SystemRoleTypeID] = @p_SystemRoleTypeID OR @p_SystemRoleTypeID IS NULL)
	AND ([Code] = @p_Code OR @p_Code IS NULL)
	AND ([Name] = @p_Name OR (@p_Name IS NULL AND @p_NameHasValue = 0))

GO
IF @@ERROR!=0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO

IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT 'Stored procedure creation succeeded.'
COMMIT TRANSACTION
END
ELSE PRINT 'Stored procedure creation failed.'
GO
DROP TABLE #tmpErrors
GO

--endregion

GO

