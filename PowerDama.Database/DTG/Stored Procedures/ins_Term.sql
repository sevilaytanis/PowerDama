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
*		Generated Date			: 02/03/2016 16:28:21
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 14/06/2017
*
*/
CREATE PROCEDURE [DTG].[ins_Term]
(
	@TermCode VARCHAR(30),
	@Name VARCHAR(200),
	@NameEN VARCHAR(200) = NULL,
	@Description VARCHAR(2000),
	@DescriptionEN VARCHAR(2000) = NULL,
	@Level1Domain INT = NULL,
	@Level2Domain INT = NULL,
	@Type TINYINT,
	@DataOwner INT,
	@DataManager INT,
	@DataSteward INT = NULL,
	@BaseTermId INT = NULL,
	@Sensitivity TINYINT,
	@Accessibility TINYINT,
	@Integrity TINYINT,
	@IsBusinessUnitTerm TINYINT = 0,
	@CopyWriterApproval TINYINT = 0,
	@UserName VARCHAR(10) = NULL,
	@HostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL
)
AS
	SET NOCOUNT ON

	DECLARE	@InsertedId INT

	INSERT INTO [DTG].[Term]
	(
		TermCode,
		Name,
		NameEN,
		[Description],
		DescriptionEN,
		Level1Domain,
		Level2Domain,
		[Type],
		DataOwner,
		DataManager,
		DataSteward,
		BaseTermId,
		Sensitivity,
		Accessibility,
		Integrity,
		IsBusinessUnitTerm,
		CopyWriterApproval,
		UserName,
		HostName,
		SystemDate,
		HostIP
	)
	VALUES
	(
		@TermCode,
		@Name,
		@NameEN,
		@Description,
		@DescriptionEN,
		@Level1Domain,
		@Level2Domain,
		@Type,
		@DataOwner,
		@DataManager,
		@DataSteward,
		@BaseTermId,
		@Sensitivity,
		@Accessibility,
		@Integrity,
		@IsBusinessUnitTerm,
		@CopyWriterApproval,
		@UserName,
		@HostName,
		GETDATE(),
		@HostIP
	)

	SELECT @InsertedId = CAST(SCOPE_IDENTITY() AS INT)

	UPDATE T
		SET T.TermCode = CAST(T.TermId AS VARCHAR)
		FROM [DTG].[Term] AS T
	    WHERE T.TermId = @InsertedId

	SELECT @InsertedId