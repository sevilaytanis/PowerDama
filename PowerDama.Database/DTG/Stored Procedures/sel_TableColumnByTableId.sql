
CREATE PROCEDURE [DTG].[sel_TableColumnByTableId]
(
    @TableId INT,
    @LanguageId TINYINT = 1
)
AS
 
SET NOCOUNT ON
BEGIN

    SELECT
        TC.TableColumnId,
        TC.TableId,
        TC.TermId,
        T.[Name] AS TermName,
        T.[Description] AS TermDescription,
        T.Level1Domain AS TermLevel1Domain,
        T.Level2Domain AS TermLevel2Domain,
        TC.ColumnName,
        TC.IsKey,
        TC.DataTypeChanged,
        TC.DataType,
        TC.Nullable,
        S.ParamCode AS SensitivityId,
        S.ParamValue AS Sensitivity,
        TC.[Description],
        TC.[IsReference],
        TC.[IsIdentity],
        (
            SELECT    
                CASE WHEN COUNT(CP.TableColumnPropertyId) > 0
                THEN 1 ELSE 0 END
            FROM    DTG.[Table] T    WITH(NOLOCK)
            INNER JOIN DTG.TableColumnProperty CP WITH (NOLOCK)
                ON    T.TableId = @TableId
                AND    T.DBName = CP.DatabaseName
                AND T.SchemaName = CP.SchemaName
                AND T.TableName = CP.TableName
                AND TC.ColumnName = CP.ColumnName 
        ) AS IsIdentifier, 
        Inf.ParamValue AS InformationType,
        Inf.ParamCode AS InformationTypeId,
        ow.[Name] AS DataOwner,
        mn.[Name] AS DataManager
    FROM [DTG].[TableColumn] AS TC WITH (NOLOCK)
    LEFT JOIN DTG.Term AS T WITH (NOLOCK)
        ON T.TermId = TC.TermId
    LEFT JOIN [CORParameter].[dbo].[Parameter] Inf WITH (NOLOCK) ON
        Inf.ParamGroupCode = 'DTG' AND
        Inf.ParamType = 'INFORMATIONTYPE' AND
        T.[Type] = Inf.ParamCode and
        Inf.LanguageId = @LanguageId
    LEFT JOIN [CORParameter].[dbo].[Parameter] S WITH (NOLOCK) ON
        S.ParamGroupCode = 'DTG' AND
        S.ParamType = 'SENSITIVITY' AND
        T.Sensitivity = S.ParamCode AND 
        S.LanguageId = @LanguageId
    LEFT JOIN [BOA].[AUT].[WorkGroup] ow WITH (NOLOCK) 
            ON ow.[WorkGroupId] = T.DataOwner
    LEFT JOIN [BOA].[AUT].[WorkGroup] mn WITH (NOLOCK) 
            ON mn.[WorkGroupId] = T.DataManager
    WHERE TC.TableId = @TableId

END