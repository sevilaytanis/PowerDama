﻿
/* KUWAIT TURKISH PARTICIPATION BANK INC.
*
*  All rights are reserved. Reproduction or transmission in whole or in part, in
*  any form or by any means, electronic, mechanical or otherwise, is prohibited
*  without the prior written consent of the copyright owner.
*
*
*  Generator Information
*		Generator				: BOAContainer
*		Generated By			: karadayi
*		Generated Date			: 11/03/2016 08:46:45
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 18/01/2018
*
*/
CREATE PROCEDURE [DTG].[ins_Table]
(
	@DBName VARCHAR(50),
	@SchemaName VARCHAR(20),
	@TableName VARCHAR(50),
	@TermId INT = NULL,
	@IsEntity TINYINT = NULL,
	@Description VARCHAR(500) = NULL,
	@Status TINYINT = 0,
	@UserName VARCHAR(10) = NULL,
	@HostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL,
	@DevVersion TINYINT,
	@TestVersion TINYINT,
	@PrepVersion TINYINT,
	@ProdVersion TINYINT,
	@LogTableName VARCHAR(100) = NULL,
	@TableType TINYINT = NULL
)
AS
	SET NOCOUNT ON
	BEGIN

	IF @LogTableName = ''
	BEGIN
		SET @LogTableName = NULL
	END

	IF @LogTableName IS NULL
	BEGIN
		IF EXISTS (
			SELECT TOP 1 1
		      FROM BOALog.INFORMATION_SCHEMA.TABLES WITH(NOLOCK)
		     WHERE TABLE_SCHEMA = @SchemaName
			   AND TABLE_NAME = @TableName + 'Log')
		BEGIN
			SET @LogTableName = 'BOALog.' + @SchemaName + '.' + @TableName + 'Log'
		END
	END

	INSERT INTO [DTG].[Table]
	(
		DBName,
		SchemaName,
		TableName,
		TermId,
		IsEntity,
		[Description],
		[Status],
		UserName,
		HostName,
		SystemDate,
		HostIP,
		DevVersion,
		TestVersion,
		PrepVersion,
		ProdVersion,
		LogTableName,
		TableType
	)
	VALUES
	(
		@DBName,
		@SchemaName,
		@TableName,
		@TermId,
		@IsEntity,
		@Description,
		@Status,
		@UserName,
		@HostName,
		GETDATE(),
		@HostIP,
		@DevVersion,
		@TestVersion,
		@PrepVersion,
		@ProdVersion,
		@LogTableName,
		@TableType
	)

	SELECT CAST(SCOPE_IDENTITY() AS INT)
END