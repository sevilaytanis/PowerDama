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
*		Generated Date			: 31/03/2016 08:46:45
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 08/08/2016
*
*/
CREATE PROCEDURE [DTG].[sel_TableFromSystem]
(
	@ServerName VARCHAR(50),
	@DBName VARCHAR(50),
	@SchemaName VARCHAR(20),
	@TableName VARCHAR(50)
)
AS
	
SET NOCOUNT ON

DECLARE
 @ExecuteString NVARCHAR(1000)

 CREATE TABLE #TableColumns
 (
	ColumnId INT,
	ColumnName VARCHAR(100),
	DataType VARCHAR(50),
	IsPrimaryKey TINYINT,
	IsUnique TINYINT,
	IsIdentity TINYINT,
	[MaxLength] SMALLINT,
	[Precision] TINYINT,
	Scale TINYINT,
	IsNullable TINYINT,
	IndexName VARCHAR(500),
	IndexType VARCHAR(50)
 )

SET @ExecuteString = N'INSERT INTO #TableColumns (ColumnId, ColumnName, DataType, IsIdentity, [MaxLength], [Precision], Scale, IsNullable)
SELECT
	CLM.column_id AS ColumnId,
	CLM.name AS ColumnName, 
	TYP.name AS DataType, 
	CLM.is_identity AS IsIdentity, 
	CLM.max_length AS [MaxLength], 
	CLM.precision AS [Precision], 
	CLM.scale AS Scale, 
	CLM.is_nullable AS IsNullable
  FROM ' + @ServerName + '.' + @DBName + '.sys.columns CLM 
 INNER JOIN ' + @ServerName + '.' + @DBName + '.sys.tables TBL WITH (NOLOCK) ON TBL.object_id = CLM.object_id
 INNER JOIN ' + @ServerName + '.' + @DBName + '.sys.schemas SCH WITH (NOLOCK) ON SCH.schema_id = TBL.schema_id
 INNER JOIN ' + @ServerName + '.' + @DBName + '.sys.types AS TYP WITH (NOLOCK) ON TYP.user_type_id = CLM.user_type_id AND TYP.schema_id = 4
 WHERE
	SCH.name = ''' + @SchemaName + '''
	AND TBL.name = ''' + @TableName + '''
 ORDER BY CLM.column_id'

EXECUTE sp_executesql @ExecuteString

 CREATE TABLE #TableIndexes
 (
	ColumnName VARCHAR(100),
	IsPrimaryKey TINYINT,
	IsUnique TINYINT,
	IndexName VARCHAR(500),
	IndexType VARCHAR(50)
 )

SET @ExecuteString = N'INSERT INTO #TableIndexes
SELECT 
	c.[name],
	i.[is_primary_key],
	i.[is_unique],
	i.[name],
	i.[type_desc]
FROM  ' + @ServerName + '.' + @DBName + '.[sys].[indexes] i 
INNER JOIN ' + @ServerName + '.' + @DBName + '.[sys].[index_columns] ic 
        ON  i.[index_id]    =   ic.[index_id] 
        AND i.[object_id]   =   ic.[object_id] 
INNER JOIN ' + @ServerName + '.' + @DBName + '.[sys].[columns] c 
        ON  ic.[column_id]  =   c.[column_id] 
        AND i.[object_id]   =   c.[object_id] 
INNER JOIN ' + @ServerName + '.' + @DBName + '.[sys].[tables] t 
        ON  i.[object_id] = t.[object_id] 
INNER JOIN ' + @ServerName + '.' + @DBName + '.[sys].[schemas] s 
        ON  s.[schema_id] = t.[schema_id] 
WHERE s.name = ''' + @SchemaName + ''' AND t.name = ''' + @TableName + ''''

EXECUTE sp_executesql @ExecuteString

UPDATE #TableColumns
	SET IsPrimaryKey = TI.IsPrimaryKey,
		IsUnique = TI.IsUnique,
		IndexName = TI.IndexName,
		IndexType = TI.IndexType
FROM #TableColumns AS TC
INNER JOIN #TableIndexes AS TI
		ON TI.ColumnName = TC.ColumnName

SELECT 
	ColumnId,
	ColumnName,
	DataType,
	IsPrimaryKey,
	IsUnique,
	IsIdentity,
	[MaxLength],
	[Precision],
	Scale,
	IsNullable,
	IndexName,
	IndexType
 FROM #TableColumns
ORDER BY ColumnId