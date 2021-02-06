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
*		Generated Date			: 20/07/2016
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 20/06/2017
*
*/
CREATE PROCEDURE [DTG].[ins_TermDataMask]
(
	@TermId INT,
	@DataType VARCHAR(50),
	@DataMaskTypeId TINYINT,
	@IsActive TINYINT
)
AS
	SET NOCOUNT ON

	INSERT INTO [DTG].[TermDataMask] (TermId, DataType, DataMaskTypeId, IsActive)
	VALUES(@TermId, @DataType, @DataMaskTypeId, @IsActive)