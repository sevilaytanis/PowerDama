CREATE PROCEDURE [DTG].[del_TableColumnProperty]
(
    @TableColumnPropertyId INT
)
AS
     
SET NOCOUNT ON
BEGIN

    DELETE FROM [DTG].[TableColumnProperty]
     WHERE TableColumnPropertyId = @TableColumnPropertyId

END