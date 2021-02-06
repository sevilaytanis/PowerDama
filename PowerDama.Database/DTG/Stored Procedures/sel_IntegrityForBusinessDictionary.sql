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
CREATE PROCEDURE [DTG].[sel_IntegrityForBusinessDictionary]

AS
	SET NOCOUNT ON
	
	SELECT
		 i.integrityId
		,i.Name
		,i.LanguageId
	 FROM [BOACatalog].[DTG].[Integrity] i WITH (NOLOCK)
	 WHERE i.LanguageId = 1