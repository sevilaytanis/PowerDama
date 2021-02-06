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
*		Generated Date			: 06/02/2018
*		File Version			: 1.5
*		Purpose					: ATLAS veritabanları için BFIX ortamında bozulması gereken alanların listesini hazırlar
*		Last Modified By		: karadayi
*		Last Modification Date	: 28/02/2018
*/

CREATE PROCEDURE [DTG].[tsk_TableColumnDataMaskBFix]
AS
    SET NOCOUNT ON
	BEGIN
	
	CREATE TABLE #prm(
		TermId INT NOT NULL,
		DataType TINYINT NOT NULL
	)

	CREATE TABLE #tmp(
		DBName VARCHAR(100) NOT NULL,
		SchemaName VARCHAR(100) NOT NULL,
		TableName VARCHAR(100) NOT NULL,
		ColumnName VARCHAR(150) NULL,
		PhysicalDataType VARCHAR(50),
		DataType TINYINT,
		TermId INT,
		Flag BIT
	)

	DECLARE @ParamValue VARCHAR(50), @ParamValue2 VARCHAR(50), @TermIdString VARCHAR(50)

	DECLARE main_cursor CURSOR FOR
	SELECT [ParamValue]
		  ,[ParamValue2]
		FROM BOACatalog.DTG.Parameter WITH (NOLOCK)
		WHERE
			ParamType = 'BFIXDisorder' AND
			LanguageId = 1

	OPEN main_cursor
	FETCH NEXT FROM main_cursor INTO @ParamValue, @ParamValue2

	WHILE @@FETCH_STATUS = 0  
	BEGIN

		DECLARE @Index INT
		SET @Index = CHARINDEX(',',@ParamValue)
		SET @TermIdString = @ParamValue

		WHILE (@Index>0 OR @TermIdString IS NOT NULL)
		BEGIN
			INSERT INTO #prm(TermId, DataType)
			VALUES(CAST(LTRIM(RTRIM(SUBSTRING(@TermIdString, 1, CASE @Index WHEN 0 THEN LEN(@TermIdString) ELSE @Index - 1 END))) AS INT), @ParamValue2)

			IF @Index <> 0
			BEGIN
				SET @TermIdString = SUBSTRING(@TermIdString, @Index + 1, LEN(@TermIdString))
				SET @Index = CHARINDEX(',',@TermIdString)
			END
			ELSE
			BEGIN
				SET @TermIdString = NULL
				SET @Index = 0
			END
		END
	
		INSERT INTO #tmp
		-- Aranan kavrama Tablonun kendisinin bağlı olduğu durumlarda Reference kolonlar içşerisinde ara
		-- BOA.CUS.Customer tablosu Customerid veya BOA.CUS.Person tablosu Personid alanları Id ile ilişkili olduğu için Reference kolon ile bulabiliriz.
		SELECT TBL.DBName, TBL.SchemaName, TBL.TableName, CLM.ColumnName, CLM.DataType, P.DataType, P.TermId, 0
		  FROM BOACatalog.DTG.[Table] AS TBL WITH (NOLOCK)
		INNER JOIN BOACatalog.DTG.TableColumn AS CLM WITH (NOLOCK) ON CLM.TableId = TBL.TableId AND CLM.IsReference = 1
		INNER JOIN BOACatalog.DTG.Term AS T WITH (NOLOCK) ON T.TermId = TBL.TermId -- Tablonun kendisi aranan kavrama bağlı
		INNER JOIN #prm AS P WITH (NOLOCK) ON T.TermId = P.TermId OR T.BaseTermId = P.TermId
		LEFT JOIN BOACatalog.dtg.DatabaseLocation AS L WITH (NOLOCK) ON L.DBName = TBL.DBName AND L.Environment = 'Production'
		WHERE L.[Location] = 'ATLAS'

		UNION
		
		-- Aranan kavrama kolonun kendisinin bağlı olsuğu durumlar
		SELECT TBL.DBName, TBL.SchemaName, TBL.TableName, CLM.ColumnName, CLM.DataType, P.DataType, P.TermId, 0
		  FROM BOACatalog.DTG.TableColumn AS CLM WITH (NOLOCK)
		INNER JOIN BOACatalog.DTG.[Table] AS TBL WITH (NOLOCK) ON TBL.TableId = CLM.TableId
		INNER JOIN BOACatalog.DTG.Term AS T WITH (NOLOCK) ON T.TermId = CLM.TermId	-- kolonun kendisi aranan kavrama bağlı
		INNER JOIN #prm AS P WITH (NOLOCK) ON T.TermId = P.TermId OR T.BaseTermId = P.TermId
		LEFT JOIN BOACatalog.dtg.DatabaseLocation AS L WITH (NOLOCK) ON L.DBName = TBL.DBName AND L.Environment = 'Production'
		WHERE L.[Location] = 'ATLAS'

		UNION
	
		-- Aranan kavrama Tablonun kendisinin bağlı olduğu durumlarda Reference kolonlar içşerisinde ara
		-- BOA.CUS.Customer tablosu Customerid veya BOA.CUS.Person tablosu Personid alanları Id ile ilişkili olduğu için Reference kolon ile bulabiliriz.
		SELECT TBL.DBName, TBL.SchemaName, TBL.TableName, CLM.ColumnName, CLM.DataType, P.DataType, P.TermId, 0
		  FROM BOACatalog.DTG.[TableDraft] AS TBL WITH (NOLOCK)
		INNER JOIN BOACatalog.DTG.TableColumnDraft AS CLM WITH (NOLOCK) ON CLM.TableDraftId = TBL.TableDraftId AND CLM.IsReference = 1
		INNER JOIN BOACatalog.DTG.Term AS T WITH (NOLOCK) ON T.TermId = TBL.TermId -- Tablonun kendisi aranan kavrama bağlı
		INNER JOIN #prm AS P WITH (NOLOCK) ON T.TermId = P.TermId OR T.BaseTermId = P.TermId
		LEFT JOIN BOACatalog.dtg.DatabaseLocation AS L WITH (NOLOCK) ON L.DBName = TBL.DBName AND L.Environment = 'Production'
		WHERE L.[Location] = 'ATLAS'

		UNION
	
		-- Aranan kavrama kolonun kendisinin bağlı olsuğu durumlar
		SELECT TBL.DBName, TBL.SchemaName, TBL.TableName, CLM.ColumnName, CLM.DataType, P.DataType, P.TermId, 0
		  FROM BOACatalog.DTG.TableColumnDraft AS CLM WITH (NOLOCK)
		INNER JOIN BOACatalog.DTG.[TableDraft] AS TBL WITH (NOLOCK) ON TBL.TableDraftId = CLM.TableDraftId
		INNER JOIN BOACatalog.DTG.Term AS T WITH (NOLOCK) ON T.TermId = CLM.TermId	-- kolonun kendisi aranan kavrama bağlı
		INNER JOIN #prm AS P WITH (NOLOCK) ON T.TermId = P.TermId OR T.BaseTermId = P.TermId
		LEFT JOIN BOACatalog.dtg.DatabaseLocation AS L WITH (NOLOCK) ON L.DBName = TBL.DBName AND L.Environment = 'Production'
		WHERE L.[Location] = 'ATLAS'

		DELETE FROM #prm

		FETCH NEXT FROM main_cursor INTO @ParamValue, @ParamValue2
	END   
	CLOSE main_cursor;  
	DEALLOCATE main_cursor;

	DECLARE @ExecuteString NVARCHAR(1000)
	DECLARE search_table_cursor CURSOR FOR 
	SELECT N'USE ' + DBName + '; 
	IF EXISTS (SELECT TOP 1 1 FROM [' + DBName + '].sys.tables AS t WITH (NOLOCK)
				INNER JOIN [' + DBName + '].sys.columns AS c WITH (NOLOCK) ON t.object_id = c.object_id
				WHERE t.type = ''U'' AND SCHEMA_NAME(t.schema_id) = ''' + SchemaName + ''' AND t.name = ''' + TableName + ''' AND c.name = ''' + ColumnName + ''') 
	BEGIN 
		UPDATE #tmp SET Flag = 1 WHERE DBName = ''' + DBName + ''' AND SchemaName = ''' + SchemaName + ''' AND TableName = ''' + TableName + '''  AND ColumnName = ''' + ColumnName + '''
	END'
	  FROM #tmp

	OPEN search_table_cursor  

	FETCH NEXT FROM search_table_cursor   
	INTO @ExecuteString  

	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		BEGIN TRY
			--PRINT @ExecuteString
			EXECUTE sp_executesql @ExecuteString
		END TRY
		BEGIN CATCH
			--PRINT ERROR_MESSAGE()
		END CATCH

		FETCH NEXT FROM search_table_cursor   
		INTO @ExecuteString
	END   
	CLOSE search_table_cursor;  
	DEALLOCATE search_table_cursor;

	TRUNCATE TABLE BOACatalog.DTG.TableColumnDataMaskBFix
	INSERT INTO BOACatalog.DTG.TableColumnDataMaskBFix
	SELECT DBName, SchemaName, TableName, ColumnName, DataType, PhysicalDataType
	  FROM #tmp
	 WHERE Flag = 1

 END