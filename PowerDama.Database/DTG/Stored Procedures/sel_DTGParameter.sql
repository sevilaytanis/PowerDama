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
*		Generated Date			: 19/12/2017
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 27/12/2017
*
*/
CREATE PROCEDURE [DTG].[sel_DTGParameter]
@ParamType VARCHAR(20) = NULL,
@ParamCode VARCHAR(20) = NULL,
@LanguageId TINYINT = NULL
AS
	SET NOCOUNT ON

	SELECT [ParamType]
      ,[ParamCode]
      ,[ParamValue]
      ,[ParamDescription]
      ,[ParamValue2]
      ,[ParamValue3]
      ,[ParamValue4]
      ,[ParamValue5]
      ,[LanguageId]
      ,[SortOrder]
	FROM BOACatalog.DTG.Parameter WITH (NOLOCK)
	WHERE
		((@ParamType IS NULL) OR ParamType = @ParamType) AND
		((@ParamCode IS NULL) OR ParamCode = @ParamCode) AND
		((@LanguageId IS NULL) OR LanguageId = @LanguageId)
	ORDER BY [ParamType], SortOrder