


CREATE PROCEDURE [DTG].[sel_TableColumnProperty]
(
    @LanguageId INT = 1
)
AS     
 
SET NOCOUNT ON
BEGIN

    SELECT
        T.TableColumnPropertyId,
        T.DatabaseName,
        T.SchemaName,
        T.TableName,
        T.ColumnName,
        T.PropertyType,
        P.ParamDescription AS PropertyTypeName,
        T.PropertyValue
    FROM [DTG].[TableColumnProperty] AS T WITH (NOLOCK)
    INNER JOIN [CORParameter].[dbo].[Parameter] AS P WITH (NOLOCK) 
        ON P.ParamCode = T.PropertyType AND  ParamType = 'TableColumnProperty'
    WHERE P.LanguageId = @LanguageId

END