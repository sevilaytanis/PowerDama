
CREATE PROCEDURE [DTG].[ins_TableColumnProperty]
(
    @DBName VARCHAR(100),
    @SchemaName VARCHAR(100),
    @TableName VARCHAR(100),
    @ColumnName VARCHAR(50),
    @PropertyType TINYINT,
    @PropertyValue VARCHAR(50) = NULL
)
AS
     
SET NOCOUNT ON

    INSERT INTO DTG.TableColumnProperty
    (
        DatabaseName,
        SchemaName,
        TableName,
        ColumnName,
        PropertyType,
        PropertyValue
    )
    VALUES
    (
    @DBName,
    @SchemaName,
    @TableName,
    @ColumnName,
    @PropertyType,
    @PropertyValue 
    )