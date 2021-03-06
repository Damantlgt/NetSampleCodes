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
PRINT N'Dropping spCFM_ApplicationUser_Insert'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_ApplicationUser_Insert', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_ApplicationUser_Insert has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_ApplicationUser_Insert') IS NOT NULL
	DROP PROCEDURE spCFM_ApplicationUser_Insert

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
PRINT N'Dropping spCFM_ApplicationUser_Update'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_ApplicationUser_Update', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_ApplicationUser_Update has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_ApplicationUser_Update') IS NOT NULL
	DROP PROCEDURE spCFM_ApplicationUser_Update

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
PRINT N'Dropping spCFM_ApplicationUser_Delete'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_ApplicationUser_Delete', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_ApplicationUser_Delete has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_ApplicationUser_Delete') IS NOT NULL
	DROP PROCEDURE spCFM_ApplicationUser_Delete

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
PRINT N'Dropping spCFM_ApplicationUser_Select'
GO
IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_ApplicationUser_Select', default, default) WHERE name = 'CustomProcedure' and value = '1')
BEGIN
    RAISERROR ('The procedure spCFM_ApplicationUser_Select has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to drop the procedure.',16,1)
    INSERT INTO #tmpErrors (Error) SELECT 1
END
GO

IF OBJECT_ID(N'spCFM_ApplicationUser_Select') IS NOT NULL
	DROP PROCEDURE spCFM_ApplicationUser_Select

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

--region [dbo].[spCFM_ApplicationUser_Insert]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_ApplicationUser_Insert]
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

PRINT N'Creating [dbo].[spCFM_ApplicationUser_Insert]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_ApplicationUser_Insert', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_ApplicationUser_Insert] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_ApplicationUser_Insert]
	@p_LoginName varchar(255),
	@p_Password varchar(255),
	@p_FirstName varchar(255),
	@p_LastName varchar(255),
	@p_EmailAddress varchar(255),
	@p_MobilePhone varchar(50),
	@p_WorkPhone varchar(50),
	@p_EmployeeNumber varchar(255),
	@p_IsActive bit,
	@p_PasswordResetNeeded bit,
	@p_PasswordResetToken varchar(255),
	@p_PasswordResetTokenExpiry datetime,
	@p_MustChangePassword bit,
	@p_ApplicationRoleID int,
	@p_LastLoggedOn datetime,
	@p_StatementDeliveryOptionID int,
	@p_PhysicalAddressID int,
	@p_SameAsPhysicalAddress bit,
	@p_PostalAddressID int,
	@p_LastActiveCheckSentOn datetime,
	@p_CreatedBy int,
	@p_CreatedOn datetime,
	@p_UpdatedBy int,
	@p_UpdatedOn datetime,
	@p_LastPasswordChangedOn datetime,
	@p_ApplicationUserID int OUTPUT
AS

INSERT INTO [dbo].[ApplicationUser] (
	[LoginName],
	[Password],
	[FirstName],
	[LastName],
	[EmailAddress],
	[MobilePhone],
	[WorkPhone],
	[EmployeeNumber],
	[IsActive],
	[PasswordResetNeeded],
	[PasswordResetToken],
	[PasswordResetTokenExpiry],
	[MustChangePassword],
	[ApplicationRoleID],
	[LastLoggedOn],
	[StatementDeliveryOptionID],
	[PhysicalAddressID],
	[SameAsPhysicalAddress],
	[PostalAddressID],
	[LastActiveCheckSentOn],
	[CreatedBy],
	[CreatedOn],
	[UpdatedBy],
	[UpdatedOn],
	[LastPasswordChangedOn]    
) VALUES (
	@p_LoginName,
	@p_Password,
	@p_FirstName,
	@p_LastName,
	@p_EmailAddress,
	@p_MobilePhone,
	@p_WorkPhone,
	@p_EmployeeNumber,
	@p_IsActive,
	@p_PasswordResetNeeded,
	@p_PasswordResetToken,
	@p_PasswordResetTokenExpiry,
	@p_MustChangePassword,
	@p_ApplicationRoleID,
	@p_LastLoggedOn,
	@p_StatementDeliveryOptionID,
	@p_PhysicalAddressID,
	@p_SameAsPhysicalAddress,
	@p_PostalAddressID,
	@p_LastActiveCheckSentOn,
	@p_CreatedBy,
	@p_CreatedOn,
	@p_UpdatedBy,
	@p_UpdatedOn,
	@p_LastPasswordChangedOn)

SET @p_ApplicationUserID = SCOPE_IDENTITY()



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

--region [dbo].[spCFM_ApplicationUser_Update]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_ApplicationUser_Update]
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

PRINT N'Creating [dbo].[spCFM_ApplicationUser_Update]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_ApplicationUser_Update', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_ApplicationUser_Update] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_ApplicationUser_Update]
	@p_ApplicationUserID int,
	@p_LoginName varchar(255),
	@p_Password varchar(255),
	@p_FirstName varchar(255),
	@p_LastName varchar(255),
	@p_EmailAddress varchar(255),
	@p_MobilePhone varchar(50),
	@p_WorkPhone varchar(50),
	@p_EmployeeNumber varchar(255),
	@p_IsActive bit,
	@p_PasswordResetNeeded bit,
	@p_PasswordResetToken varchar(255),
	@p_PasswordResetTokenExpiry datetime,
	@p_MustChangePassword bit,
	@p_ApplicationRoleID int,
	@p_LastLoggedOn datetime,
	@p_StatementDeliveryOptionID int,
	@p_PhysicalAddressID int,
	@p_SameAsPhysicalAddress bit,
	@p_PostalAddressID int,
	@p_LastActiveCheckSentOn datetime,
	@p_CreatedBy int,
	@p_CreatedOn datetime,
	@p_UpdatedBy int,
	@p_UpdatedOn datetime,
	@p_LastPasswordChangedOn datetime
AS

UPDATE [dbo].[ApplicationUser] SET
	[LoginName] = @p_LoginName,
	[Password] = @p_Password,
	[FirstName] = @p_FirstName,
	[LastName] = @p_LastName,
	[EmailAddress] = @p_EmailAddress,
	[MobilePhone] = @p_MobilePhone,
	[WorkPhone] = @p_WorkPhone,
	[EmployeeNumber] = @p_EmployeeNumber,
	[IsActive] = @p_IsActive,
	[PasswordResetNeeded] = @p_PasswordResetNeeded,
	[PasswordResetToken] = @p_PasswordResetToken,
	[PasswordResetTokenExpiry] = @p_PasswordResetTokenExpiry,
	[MustChangePassword] = @p_MustChangePassword,
	[ApplicationRoleID] = @p_ApplicationRoleID,
	[LastLoggedOn] = @p_LastLoggedOn,
	[StatementDeliveryOptionID] = @p_StatementDeliveryOptionID,
	[PhysicalAddressID] = @p_PhysicalAddressID,
	[SameAsPhysicalAddress] = @p_SameAsPhysicalAddress,
	[PostalAddressID] = @p_PostalAddressID,
	[LastActiveCheckSentOn] = @p_LastActiveCheckSentOn,
	[CreatedBy] = @p_CreatedBy,
	[CreatedOn] = @p_CreatedOn,
	[UpdatedBy] = @p_UpdatedBy,
	[UpdatedOn] = @p_UpdatedOn,
	[LastPasswordChangedOn] = @p_LastPasswordChangedOn
WHERE
	[ApplicationUserID] = @p_ApplicationUserID


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

--region [dbo].[spCFM_ApplicationUser_Delete]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_ApplicationUser_Delete]
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

PRINT N'Creating [dbo].[spCFM_ApplicationUser_Delete]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_ApplicationUser_Delete', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_ApplicationUser_Delete] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_ApplicationUser_Delete]
	@p_ApplicationUserID int
AS

DELETE FROM
    [dbo].[ApplicationUser]
WHERE
	[ApplicationUserID] = @p_ApplicationUserID

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

--region [dbo].[spCFM_ApplicationUser_Select]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   prady using CodeSmith: v7.1.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10
-- Procedure Name: [dbo].[spCFM_ApplicationUser_Select]
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

PRINT N'Creating [dbo].[spCFM_ApplicationUser_Select]'
GO

IF EXISTS(SELECT 1 FROM fn_listextendedproperty (NULL, 'SCHEMA', 'dbo', 'PROCEDURE', 'spCFM_ApplicationUser_Select', default, default) WHERE name = 'CustomProcedure' and value = '1')
    BEGIN
        RAISERROR ('The procedure [dbo].[spCFM_ApplicationUser_Select] has an Extended Property "CustomProcedure" which means is has been customized. Please review and remove the property if you wish to create the stored procedure.',16,1)
        INSERT INTO #tmpErrors (Error) SELECT 1
    END
GO

CREATE PROCEDURE [dbo].[spCFM_ApplicationUser_Select]
	@p_ApplicationUserID int = NULL,
	@p_LoginName varchar(255) = NULL,
	@p_Password varchar(255) = NULL,
	@p_FirstName varchar(255) = NULL,
	@p_LastName varchar(255) = NULL,
	@p_LastNameHasValue BIT = 0,
	@p_EmailAddress varchar(255) = NULL,
	@p_EmailAddressHasValue BIT = 0,
	@p_MobilePhone varchar(50) = NULL,
	@p_MobilePhoneHasValue BIT = 0,
	@p_WorkPhone varchar(50) = NULL,
	@p_WorkPhoneHasValue BIT = 0,
	@p_EmployeeNumber varchar(255) = NULL,
	@p_EmployeeNumberHasValue BIT = 0,
	@p_IsActive bit = NULL,
	@p_PasswordResetNeeded bit = NULL,
	@p_PasswordResetToken varchar(255) = NULL,
	@p_PasswordResetTokenHasValue BIT = 0,
	@p_PasswordResetTokenExpiry datetime = NULL,
	@p_PasswordResetTokenExpiryHasValue BIT = 0,
	@p_MustChangePassword bit = NULL,
	@p_ApplicationRoleID int = NULL,
	@p_ApplicationRoleIDHasValue BIT = 0,
	@p_LastLoggedOn datetime = NULL,
	@p_LastLoggedOnHasValue BIT = 0,
	@p_StatementDeliveryOptionID int = NULL,
	@p_StatementDeliveryOptionIDHasValue BIT = 0,
	@p_PhysicalAddressID int = NULL,
	@p_PhysicalAddressIDHasValue BIT = 0,
	@p_SameAsPhysicalAddress bit = NULL,
	@p_PostalAddressID int = NULL,
	@p_PostalAddressIDHasValue BIT = 0,
	@p_LastActiveCheckSentOn datetime = NULL,
	@p_LastActiveCheckSentOnHasValue BIT = 0,
	@p_CreatedBy int = NULL,
	@p_CreatedByHasValue BIT = 0,
	@p_CreatedOn datetime = NULL,
	@p_UpdatedBy int = NULL,
	@p_UpdatedByHasValue BIT = 0,
	@p_UpdatedOn datetime = NULL,
	@p_UpdatedOnHasValue BIT = 0,
	@p_LastPasswordChangedOn datetime = NULL,
	@p_LastPasswordChangedOnHasValue BIT = 0
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT
	[ApplicationUserID],
	[LoginName],
	[Password],
	[FirstName],
	[LastName],
	[EmailAddress],
	[MobilePhone],
	[WorkPhone],
	[EmployeeNumber],
	[IsActive],
	[PasswordResetNeeded],
	[PasswordResetToken],
	[PasswordResetTokenExpiry],
	[MustChangePassword],
	[ApplicationRoleID],
	[LastLoggedOn],
	[StatementDeliveryOptionID],
	[PhysicalAddressID],
	[SameAsPhysicalAddress],
	[PostalAddressID],
	[LastActiveCheckSentOn],
	[CreatedBy],
	[CreatedOn],
	[UpdatedBy],
	[UpdatedOn],
	[LastPasswordChangedOn]
FROM
    [dbo].[ApplicationUser]
WHERE
	([ApplicationUserID] = @p_ApplicationUserID OR @p_ApplicationUserID IS NULL)
	AND ([LoginName] = @p_LoginName OR @p_LoginName IS NULL)
	AND ([Password] = @p_Password OR @p_Password IS NULL)
	AND ([FirstName] = @p_FirstName OR @p_FirstName IS NULL)
	AND ([LastName] = @p_LastName OR (@p_LastName IS NULL AND @p_LastNameHasValue = 0))
	AND ([EmailAddress] = @p_EmailAddress OR (@p_EmailAddress IS NULL AND @p_EmailAddressHasValue = 0))
	AND ([MobilePhone] = @p_MobilePhone OR (@p_MobilePhone IS NULL AND @p_MobilePhoneHasValue = 0))
	AND ([WorkPhone] = @p_WorkPhone OR (@p_WorkPhone IS NULL AND @p_WorkPhoneHasValue = 0))
	AND ([EmployeeNumber] = @p_EmployeeNumber OR (@p_EmployeeNumber IS NULL AND @p_EmployeeNumberHasValue = 0))
	AND ([IsActive] = @p_IsActive OR @p_IsActive IS NULL)
	AND ([PasswordResetNeeded] = @p_PasswordResetNeeded OR @p_PasswordResetNeeded IS NULL)
	AND ([PasswordResetToken] = @p_PasswordResetToken OR (@p_PasswordResetToken IS NULL AND @p_PasswordResetTokenHasValue = 0))
	AND ([PasswordResetTokenExpiry] = @p_PasswordResetTokenExpiry OR (@p_PasswordResetTokenExpiry IS NULL AND @p_PasswordResetTokenExpiryHasValue = 0))
	AND ([MustChangePassword] = @p_MustChangePassword OR @p_MustChangePassword IS NULL)
	AND ([ApplicationRoleID] = @p_ApplicationRoleID OR (@p_ApplicationRoleID IS NULL AND @p_ApplicationRoleIDHasValue = 0))
	AND ([LastLoggedOn] = @p_LastLoggedOn OR (@p_LastLoggedOn IS NULL AND @p_LastLoggedOnHasValue = 0))
	AND ([StatementDeliveryOptionID] = @p_StatementDeliveryOptionID OR (@p_StatementDeliveryOptionID IS NULL AND @p_StatementDeliveryOptionIDHasValue = 0))
	AND ([PhysicalAddressID] = @p_PhysicalAddressID OR (@p_PhysicalAddressID IS NULL AND @p_PhysicalAddressIDHasValue = 0))
	AND ([SameAsPhysicalAddress] = @p_SameAsPhysicalAddress OR @p_SameAsPhysicalAddress IS NULL)
	AND ([PostalAddressID] = @p_PostalAddressID OR (@p_PostalAddressID IS NULL AND @p_PostalAddressIDHasValue = 0))
	AND ([LastActiveCheckSentOn] = @p_LastActiveCheckSentOn OR (@p_LastActiveCheckSentOn IS NULL AND @p_LastActiveCheckSentOnHasValue = 0))
	AND ([CreatedBy] = @p_CreatedBy OR (@p_CreatedBy IS NULL AND @p_CreatedByHasValue = 0))
	AND ([CreatedOn] = @p_CreatedOn OR @p_CreatedOn IS NULL)
	AND ([UpdatedBy] = @p_UpdatedBy OR (@p_UpdatedBy IS NULL AND @p_UpdatedByHasValue = 0))
	AND ([UpdatedOn] = @p_UpdatedOn OR (@p_UpdatedOn IS NULL AND @p_UpdatedOnHasValue = 0))
	AND ([LastPasswordChangedOn] = @p_LastPasswordChangedOn OR (@p_LastPasswordChangedOn IS NULL AND @p_LastPasswordChangedOnHasValue = 0))

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

