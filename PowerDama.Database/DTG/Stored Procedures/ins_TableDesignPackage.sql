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
*		Generated Date			: 20/03/2016 21:52:29
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 29/11/2017
*
*/
CREATE PROCEDURE [DTG].[ins_TableDesignPackage]
(
	@DevelopmentLocation VARCHAR(50) = NULL,
	@DBName VARCHAR(50) = NULL,
	@SchemaName VARCHAR(20) = NULL,
	@TableName VARCHAR(100) = NULL,
	@RejectReason VARCHAR(MAX) = NULL,
	@Script VARCHAR(MAX) = NULL,
	@Status TINYINT = NULL,
	@UserName VARCHAR(10) = NULL,
	@HostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL
)
AS
	 
SET NOCOUNT ON
	BEGIN

	DECLARE @Version TINYINT
	
	SELECT @Version = DevVersion
	  FROM DTG.[Table] WITH (NOLOCK)
	 WHERE DBName = @DBName
		AND SchemaName = @SchemaName
		AND TableName = @TableName

	IF @Version IS NULL
	BEGIN
		SET @Version = 1
	END
	ELSE
	BEGIN
		SET @Version = @Version + 1
	END

	INSERT INTO [DTG].[TableDesignPackage]
	(
		DBName,
		SchemaName,
		TableName,
		RejectReason,
		Script,
		[Status],
		UserName,
		HostName,
		HostIP,
		SystemDate,
		[Version],
		DevelopmentLocation
	)
	VALUES
	(
		@DBName,
		@SchemaName,
		@TableName,
		@RejectReason,
		@Script,
		@Status,
		@UserName,
		@HostName,
		@HostIP,
		GETDATE(),
		@Version,
		@DevelopmentLocation
	)

	SELECT CAST(SCOPE_IDENTITY() AS INT)

	END