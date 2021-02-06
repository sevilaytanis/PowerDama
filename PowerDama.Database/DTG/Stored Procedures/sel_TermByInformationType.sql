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
*		Generated Date			: 10/03/2016
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 10/03/2016
*
*/
CREATE PROCEDURE [DTG].[sel_TermByInformationType]
	@InformationTypeId TINYINT,
	@LanguageId TINYINT = 1
AS
	SET NOCOUNT ON;
BEGIN

	SELECT
		T.TermId,
		T.TermCode,
		T.Name,
		T.NameEN,
		T.[Description],
		T.DescriptionEN,
		CASE T.[ModuleId] 
			WHEN 0 THEN T.[ModuleId] 
			ELSE M.ParamCode 
		END AS [ModuleId],
		CASE T.[ModuleId] 
			WHEN 0 THEN 'Genel' 
			ELSE M.ParamDescription 
		END AS [ModuleCode],
		Inf.[InformationTypeId] AS [InformationTypeId],
		Inf.[Name] AS [InformationType],
		S.SensitivityId AS SensitivityId,
		S.Name AS Sensitivity,
		ow.[WorkGroupId] AS DataOwnerId,
		ow.[Name] AS DataOwner,
		mn.[WorkGroupId] AS DataManagerId,
		mn.[Name] AS DataManager,
		st.[WorkGroupId] AS DataStewardId,
		st.[Name] AS DataSteward,
		T.BaseTermId,
		CASE @LanguageId 
			WHEN 1 THEN DT.Name 
			ELSE DT.NameEN 
		END AS DataType,
		TR2.Value AS IsBaseTerm,
		T.UserName,
		T.UpdateUserName
	 FROM [DTG].[Term] T WITH (NOLOCK)
	INNER JOIN [DTG].[InformationType] Inf WITH (NOLOCK) 
		ON T.[Type] = Inf.[InformationTypeId] 
		AND Inf.LanguageId = @LanguageId
	INNER JOIN [DTG].[Sensitivity] S WITH (NOLOCK) 
		ON T.Sensitivity = S.[SensitivityId] 
		AND S.LanguageId = @LanguageId
	 LEFT JOIN [CORParameter].[dbo].[Parameter] M WITH (NOLOCK) 
		ON M.[ParamCode] = T.[ModuleId] 
		AND M.Paramtype='CapabilityCategory' 
		AND M.LanguageId = @LanguageId
	 LEFT JOIN [BOA].[AUT].[WorkGroup] ow WITH (NOLOCK) 
		ON ow.[WorkGroupId] = T.DataOwner
	 LEFT JOIN [BOA].[AUT].[WorkGroup] mn WITH (NOLOCK) 
		ON mn.[WorkGroupId] = T.DataManager
	 LEFT JOIN [BOA].[AUT].[WorkGroup] st WITH (NOLOCK) 
		ON st.[WorkGroupId] = T.DataSteward
	 LEFT JOIN [DTG].[TermRule] TR WITH (NOLOCK) 
		ON TR.TermId = T.TermId 
		AND TR.TemplateType = 3
	 LEFT JOIN [DTG].[DataType] DT WITH (NOLOCK) 
		ON DT.DataTypeId = CAST(TR.Value AS INT)
	 LEFT JOIN [DTG].[TermRule] TR2 WITH (NOLOCK) 
		ON TR2.TermId = T.TermId 
		AND TR2.TemplateType = 1
	WHERE T.[Type] = @InformationTypeId

END