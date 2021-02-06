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
*		Generated Date			: 13/03/2016 13:48:59
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 13/03/2016 13:48:59
*
*/
CREATE PROCEDURE [DTG].[ins_Entity]
(
	@TermId INT = NULL,
	@Type TINYINT,
	@BaseEntityId INT = NULL,
	@Namespace VARCHAR(100) = NULL,
	@WorkGroupId INT = NULL,
	@UserName VARCHAR(10) = NULL,
	@HostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL
)
AS
	SET NOCOUNT ON;
BEGIN

	INSERT INTO [DTG].[Entity]
	(
		TermId,
		[Type],
		BaseEntityId,
		[Namespace],
		WorkGroupId,
		UserName,
		HostName,
		SystemDate,
		HostIP
	)
	VALUES
	(
		@TermId,
		@Type,
		@BaseEntityId,
		@Namespace,
		@WorkGroupId,
		@UserName,
		@HostName,
		GETDATE(),
		@HostIP
	)

	SELECT CAST(SCOPE_IDENTITY() AS INT)

END