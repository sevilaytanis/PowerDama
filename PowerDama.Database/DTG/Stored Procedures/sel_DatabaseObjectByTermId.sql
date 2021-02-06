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
*		Generated Date			: 10/05/2016
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 10/05/2016
*
*/
CREATE PROCEDURE [DTG].[sel_DatabaseObjectByTermId]
(
	@TermId INT
)
AS
	SET NOCOUNT ON;
BEGIN

	CREATE TABLE #OBJ(
		Name VARCHAR(50),
		Detail VARCHAR(50) NULL,
		ObjectType VARCHAR(50)
	)

	INSERT INTO #OBJ(Name, Detail, ObjectType)
	SELECT 
		TableName,
		DBName + '.' + SchemaName + '.' + TableName,
		'Table'
	FROM [DTG].[Table] WITH (NOLOCK)
	 WHERE
		TermId = @TermId

	INSERT INTO #OBJ(Name, Detail, ObjectType)
	SELECT 
		CLM.ColumnName,
		TBL.DBName + '.' + TBL.SchemaName + '.' + TBL.TableName,
		'Column'
	  FROM [DTG].[Table] AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].[TableColumn] AS CLM WITH (NOLOCK) 
		ON CLM.TableId = TBL.TableId
	 WHERE
		CLM.[TermId] = @TermId

	INSERT INTO #OBJ(Name, Detail, ObjectType)
	SELECT 
		TableName,
		DBName + '.' + SchemaName + '.' + TableName,
		'Table (Draft)'
	FROM [DTG].[TableDraft] WITH (NOLOCK)
	 WHERE
		TermId = @TermId

	INSERT INTO #OBJ(Name, Detail, ObjectType)
	SELECT 
		CLM.ColumnName,
		TBL.DBName + '.' + TBL.SchemaName + '.' + TBL.TableName,
		'Column (Draft)'
	  FROM [DTG].[TableDraft] AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].[TableColumnDraft] AS CLM WITH (NOLOCK) 
		ON CLM.TableDraftId = TBL.TableDraftId
	 WHERE
		CLM.[TermId] = @TermId

	SELECT
		Name,
		Detail,
		ObjectType
	FROM #OBJ

END