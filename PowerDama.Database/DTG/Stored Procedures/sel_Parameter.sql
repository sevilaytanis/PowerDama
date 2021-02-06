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
*		Generated Date			: 21/11/2017
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: 
*		Last Modification Date	: 
*
*/
CREATE PROCEDURE [DTG].[sel_Parameter]
@ParamType VARCHAR(20),
@ParamGroupCode VARCHAR(30) = NULL,
@LanguageId TINYINT = 1
AS
	SET NOCOUNT ON;

	SELECT 
		ParamType
	   ,ParamCode
       ,ParamValue
	   ,ParamDescription
	   ,ParamGroupCode
	FROM BOACatalog.DTG.vParameter WITH (NOLOCK)
	WHERE
		((@ParamGroupCode IS NULL) OR ParamGroupCode = @ParamGroupCode) AND
		ParamType = @ParamType AND
		LanguageId = @LanguageId
	ORDER BY ParamCode