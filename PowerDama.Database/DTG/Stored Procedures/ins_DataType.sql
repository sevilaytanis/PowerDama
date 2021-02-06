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
*		Generated Date			: 28/04/2016
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 28/04/2016
*
*/
CREATE PROCEDURE [DTG].[ins_DataType]
(
	@Name VARCHAR(50),
	@NameEN VARCHAR(50),
	@DataTypeLanguageId TINYINT,
	@Value VARCHAR(50)
)
AS
SET NOCOUNT ON;
BEGIN

	DECLARE @DataTypeId INT

	INSERT INTO [DTG].[DataType]
           ([Name]
           ,[NameEN])
     VALUES
           (@Name
           ,@NameEN)

	SELECT @DataTypeId = SCOPE_IDENTITY()

	INSERT INTO [DTG].[DataTypeMatch]
			   ([DataTypeId]
			   ,[DataTypeLanguageId]
			   ,[Value])
		 VALUES
			   (@DataTypeId
			   ,@DataTypeLanguageId
			   ,@Value)

END