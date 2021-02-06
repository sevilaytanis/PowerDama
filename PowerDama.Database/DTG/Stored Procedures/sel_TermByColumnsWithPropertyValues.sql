
CREATE PROCEDURE [DTG].[sel_TermByColumnsWithPropertyValues]
	@Name VARCHAR(200) = NULL,
	@NameEN VARCHAR(200) = NULL,
	@ModuleId INT = NULL,
	@Level1Domain INT = NULL,
	@Level2Domain INT = NULL,
	@Sensitivity TINYINT = NULL,
	@Type TINYINT = NULL,
	@DataOwner INT = NULL,
	@DataManager INT = NULL,
	@DataSteward INT = NULL,
	@IsPrivateData TINYINT = NULL,
	@ValidatedByCustomerRightsUnit TINYINT = NULL,
	@ValidatedByBusinessUnit TINYINT = NULL,
	@IsBusinessUnitTerm TINYINT = NULL,
	@CopyWriterApproval TINYINT = NULL,
	@LanguageId TINYINT = 1
AS
	SET NOCOUNT ON
	BEGIN

	IF @Level1Domain = 0
	BEGIN
		SELECT @Level1Domain = NULL
	END 

	SELECT
		T.TermId,
		T.TermCode,
		T.Name,
		T.NameEN,
		T.[Description],
		T.DescriptionEN,
		L1.ParamCode AS ModuleId,
		L1.ParamDescription AS ModuleCode,
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
		T.CopyWriterApproval,
		T.ValidatedByBusinessUnit,
		T.ValidatedByCustomerRightsUnit,
		T.UserName,
		T.UpdateUserName,
		T.HashTag,
		(SELECT 
			PV.[PropertyValueId],
			PV.[PropertyId],
			PV.[BoolValue],
			PV.[DateValue],
			PV.[TextValue],
			CAST(PV.[NumericValue] AS INT) [NumericValue],
			PV.[RichTextValue],
			PV.[ParamCode] 
		   FROM [DTG].[PropertyValue] PV WITH(NOLOCK)
		  INNER JOIN [DTG].[Property] P WITH(NOLOCK)
		     ON P.PropertyId = PV.PropertyId AND 
		        P.TargetEntity = 0 AND 
				PV.EntityId = T.TermId 
				FOR XML PATH('PropertyValue')) AS PropertyValues
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
		ON TR.TermId = T.TermId AND 
		TR.TemplateType = 3
	 LEFT JOIN [DTG].[DataType] DT WITH (NOLOCK) 
		ON DT.DataTypeId = CAST(TR.Value AS INT)
	 LEFT JOIN [DTG].[TermRule] TR2 WITH (NOLOCK) 
		ON TR2.TermId = T.TermId AND 
		TR2.TemplateType = 1
	WHERE
		((@Name IS NULL) OR 
		(T.[Name] LIKE '%' + @Name + '%'))
	AND ((@NameEN IS NULL) OR 
		(T.[NameEN] LIKE '%' + @NameEN + '%'))
	AND ((@Level1Domain IS NULL) OR 
		T.Level1Domain = @Level1Domain)
	AND ((@Level2Domain IS NULL) OR 
		T.Level2Domain = @Level2Domain)
	AND ((@Type IS NULL) OR 
		T.[Type] = @Type)
	AND ((@Sensitivity IS NULL) OR 
		@Sensitivity = 0 OR 
		T.Sensitivity = @Sensitivity)
	AND ((@DataOwner IS NULL) OR 
		T.DataOwner = @DataOwner)
	AND ((@DataManager IS NULL) OR 
		T.DataManager = @DataManager)
	AND ((@DataSteward IS NULL) OR 
		T.DataSteward = @DataSteward)
	AND (@ValidatedByCustomerRightsUnit IS NULL OR (T.ValidatedByCustomerRightsUnit = @ValidatedByCustomerRightsUnit OR (@ValidatedByCustomerRightsUnit = 0 AND T.ValidatedByCustomerRightsUnit IS NULL)))
	AND (@ValidatedByBusinessUnit IS NULL OR (T.ValidatedByBusinessUnit = @ValidatedByBusinessUnit OR (@ValidatedByBusinessUnit = 0 AND T.ValidatedByBusinessUnit IS NULL)))
	AND (@IsBusinessUnitTerm IS NULL OR (T.IsBusinessUnitTerm = @IsBusinessUnitTerm OR (@IsBusinessUnitTerm = 0 AND T.IsBusinessUnitTerm IS NULL)))
	AND (@IsPrivateData IS NULL OR (T.IsPrivateData = @IsPrivateData OR (@IsPrivateData = 0 AND T.IsPrivateData IS NULL)))
	AND (@CopyWriterApproval IS NULL OR (T.CopyWriterApproval = @CopyWriterApproval OR (@CopyWriterApproval = 0 AND T.CopyWriterApproval IS NULL)))
	ORDER BY UseCount DESC

	END