﻿
/*
*
*
*  Generator Information
*		Generator				: BOAContainer
*		Generated By			: tp.keremc
*		Generated Date			: 26/08/2020
*		File Version			: 1.0
*		Purpose					: 
*		Last Modified By		: tp.keremc
*		Last Modification Date	: 26/08/2020
*
*/
CREATE PROCEDURE [DTG].[sel_AccessibilityForBusinessDictionary]

AS
	SET NOCOUNT ON
	
	SELECT
		 A.AccessibilityId
		,A.Name
		,A.LanguageId
	 FROM [BOACatalog].[DTG].[Accessibility] A WITH (NOLOCK)
	 WHERE A.LanguageId = 1