
CREATE PROCEDURE [DTG].[upd_TableColumnProperty]
(
    @TableColumnPropertyId INT,
    @DBName VARCHAR(100),
    @SchemaName VARCHAR(100),
    @TableName VARCHAR(100),
    @ColumnName VARCHAR(50),
    @PropertyType TINYINT,
    @PropertyValue VARCHAR(50) = NULL
)
AS
 
SET NOCOUNT ON
BEGIN

    UPDATE [DTG].[TableColumnProperty] 
       SET

        DatabaseName = @DBName,
        SchemaName = @SchemaName,
        TableName = @TableName,
        ColumnName = @ColumnName,
        PropertyType = @PropertyType,
        PropertyValue = @PropertyValue 

    WHERE TableColumnPropertyId = @TableColumnPropertyId

END