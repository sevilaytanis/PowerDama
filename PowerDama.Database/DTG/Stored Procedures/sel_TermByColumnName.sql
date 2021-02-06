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
*		Generated Date			: 05/04/2016 16:28:21
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 02/05/2018
*
*/
CREATE PROCEDURE [DTG].[sel_TermByColumnName]
	@TableColumnName VARCHAR(200),
	@LanguageId TINYINT = 1
AS
	SET NOCOUNT ON;

	SELECT
		T.TermId,
		T.TermCode,
		T.Name,
		T.NameEN,
		T.[Description],
		T.DescriptionEN,
		L1.ParamCode AS Level1Domain,
		L1.ParamDescription AS Level1DomainName,
		L2.ParamCode AS Level2Domain,
		L2.ParamDescription AS Level2DomainName,
		Inf.ParamCode AS [InformationTypeId],
		Inf.ParamValue AS [InformationType],
		S.ParamCode AS SensitivityId,
		S.ParamValue AS Sensitivity,
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
		T.IsPrivateData,
		T.IsBusinessUnitTerm,
		T.ValidatedByBusinessUnit,
		T.ValidatedByCustomerRightsUnit,
		T.UserName,
		T.UpdateUserName
	 FROM [DTG].[Term] T WITH (NOLOCK)
	 INNER JOIN DTG.vParameter Inf WITH (NOLOCK) ON
		Inf.ParamGroupCode = 'DTG' AND
		Inf.ParamType = 'INFORMATIONTYPE' AND
		T.[Type] = Inf.ParamCode AND 
		Inf.LanguageId = @LanguageId
	 LEFT JOIN DTG.vParameter S WITH (NOLOCK) ON
		S.ParamGroupCode = 'DTG' AND
		S.ParamType = 'SENSITIVITY' AND
		T.Sensitivity = S.ParamCode AND 
		S.LanguageId = @LanguageId
	 LEFT JOIN DTG.vParameter L1 WITH (NOLOCK) 
		   ON L1.[ParamCode] = T.Level1Domain 
		   AND L1.Paramtype='BusinessArchitecture' 
		   AND L1.LanguageId = @LanguageId
	LEFT JOIN DTG.vParameter L2 WITH (NOLOCK) 
		   ON L2.[ParamCode] = T.Level2Domain 
		   AND L2.Paramtype='BusinessArchitecture' 
		   AND L2.LanguageId = @LanguageId
	 LEFT JOIN [BOA].[AUT].[WorkGroup] ow WITH (NOLOCK) 
			ON ow.[WorkGroupId] = T.DataOwner
	 LEFT JOIN [BOA].[AUT].[WorkGroup] mn WITH (NOLOCK) 
			ON mn.[WorkGroupId] = T.DataManager
	 LEFT JOIN [BOA].[AUT].[WorkGroup] st WITH (NOLOCK) 
			ON st.[WorkGroupId] = T.DataSteward
	 LEFT JOIN [DTG].[TermRule] TR WITH (NOLOCK) 
			ON TR.TermId = T.TermId AND TR.TemplateType = 3
	 LEFT JOIN [DTG].[DataType] DT WITH (NOLOCK) 
			ON DT.DataTypeId = CAST(TR.Value AS INT)
	 LEFT JOIN [DTG].[TermRule] TR2 WITH (NOLOCK) 
			ON TR2.TermId = T.TermId 
			AND TR2.TemplateType = 1
	 LEFT JOIN [DTG].[TermRule] TR3 WITH (NOLOCK) 
			ON TR3.TermId = T.TermId 
			AND TR3.TemplateType = 5
	WHERE
		TR3.Value = @TableColumnName