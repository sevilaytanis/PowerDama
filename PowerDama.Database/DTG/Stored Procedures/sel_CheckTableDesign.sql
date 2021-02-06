﻿/* KUWAIT TURKISH PARTICIPATION BANK INC.
*
*  All rights are reserved. Reproduction or transmission in whole or in part, in
*  any form or by any means, electronic, mechanical or otherwise, is prohibited
*  without the prior written consent of the copyright owner.
*
*
*  Generator Information
*		Generator				: BOAContainer
*		Generated By			: karadayi
*		Generated Date			: 10/07/2017
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 12/01/2018
*
*/
CREATE PROCEDURE [DTG].[sel_CheckTableDesign]
	@DBName VARCHAR(20),
	@SchemaName VARCHAR(20),
	@TableName VARCHAR(50),
	@IsDraftControl TINYINT = 1,
	@LanguageId TINYINT = 1
AS
	SET NOCOUNT ON
	BEGIN

	DECLARE 
		@Count INT = 0,
		@ExecuteString NVARCHAR(MAX)

	CREATE TABLE #TMP(Id INT IDENTITY(1,1), Severity VARCHAR(20), [ItemType] VARCHAR(20), [ItemName] VARCHAR(100), [Error] VARCHAR(100), [Description] VARCHAR(250))

	SET @ExecuteString = N'
	-- Fiziksel İfade Kontrolü
	INSERT INTO #TMP
	SELECT "Error", "Term", TBL.TableName, "Fiziksel İfade Kullanımı", """" + T.Name + """ kavramının adında veya açıklamasında tablo, kolon, alan gibi fiziksel ifadeler geçmektedir."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON TBL.TermId = T.TermId
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		(
			(T.Name LIKE "% tablo%") OR 
			(T.Description LIKE "% tablo%") OR 
			(T.Name LIKE "% kolon%") OR 
			(T.Description LIKE "% kolon%") OR 
			(T.Name LIKE "%tutuldu_u alan%") OR 
			(T.Description LIKE "%tutuldu_u alan%")
		)
	
	INSERT INTO #TMP
	SELECT "Error", "Term", TC.ColumnName, "Fiziksel İfade Kullanımı", """" + T.Name + """ kavramının adında veya açıklamasında tablo, kolon, alan gibi fiziksel ifadeler geçmektedir."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON TC.TermId = T.TermId
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		(
			(T.Name LIKE "% tablo%") OR 
			(T.Description LIKE "% tablo%") OR 
			(T.Name LIKE "% kolon%") OR 
			(T.Description LIKE "% kolon%") OR 
			(T.Name LIKE "%tutuldu_u alan%") OR 
			(T.Description LIKE "%tutuldu_u alan%")
		)

	-- ID Kolonu Kontrolü
	INSERT INTO #TMP
	SELECT "Error", "Column", TC.ColumnName, "Standart Dışı Kullanım", "ID kolonunun adı [" + @TableName + "Id] olmalı."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON TC.TermId = T.TermId
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		T.TermId = 8 AND
		TC.ColumnName <> (TBL.TableName + "Id")

	-- Code Kolonu Kontrolü
	INSERT INTO #TMP
	SELECT "Error", "Column", TC.ColumnName, "Standart Dışı Kullanım", "Code kolonunun adı [" + @TableName + "Code] olmalı."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON TC.TermId = T.TermId
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		T.TermId = 1 AND
		TC.ColumnName <> (TBL.TableName + "Code")
		
	-- Kopyala Yapıştır Kontrolü
	INSERT INTO #TMP
	SELECT "Error", "Term", T.Name, "Hatalı Kavram Tanımı", """" + T.Name + """ kavramının açıklaması isminden kopyalanmış. Açıklama alanı detaylandırılmalı."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TBL.TermId
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		UPPER(T.Name) = UPPER(T.Description)

	INSERT INTO #TMP
	SELECT "Error", "Term", T.Name, "Hatalı Kavram Tanımı", """" + T.Name + """ kavramının açıklaması isminden kopyalanmış. Açıklama alanı detaylandırılmalı."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		UPPER(T.Name) = UPPER(T.Description)	

	-- BIT Veri Tipi Kontrolü
    INSERT INTO #TMP
	SELECT "Error", "Column", TC.ColumnName, "Hatalı Veri Tipi", """" + TC.ColumnName + """ kolonunun ""BIT"" olarak seçilen veri tipi ""TINYINT"" olarak değiştirilmeli."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	  INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		TC.DataType = "BIT"

	-- Hesap Numarası Kontrolü
	INSERT INTO #TMP
	SELECT "Error", "Column", TC.ColumnName, "Kavram İlişkilendirme Hatası", """" + TC.ColumnName + """ kolonu COR.Account tablosunu işaret eden ""Hesap"" kavramı ile ilişkilendirilmeli."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		T.TermId = 67	

	-- Yes/No Veri Tipli Kavramlarda İsim Kontrolü
	INSERT INTO #TMP
	SELECT "Error", "Term", T.[Name], "Hatalı Kavram Tanımı", "Evet/Hayır veri tipindeki """ + T.Name + """ kavramının Türkçe adı ""... Bayrağı"", İngilizce adı da ""... Flag"" şablonunda olmalı." 
	  FROM  [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 INNER JOIN DTG.TermRule AS TR WITH (NOLOCK) ON TR.TermId = T.TermId
	 WHERE		
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND
		TR.[Value] = 2 AND
		(T.[Name] NOT LIKE "%Bayrağı%" OR T.NameEN NOT LIKE "%Flag%")

	-- Veri Tipi Tutar olup Tutar kavramından türememiş kavrama bağlanmış olanlar	
	INSERT INTO #TMP
	SELECT "Error", "Term", T.[Name], "Hatalı Kavram Tanımı", """" + T.Name + """ kavramı ""Tutar"" kavramından türetilmeli."
	  FROM  [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 INNER JOIN DTG.TermRule AS TR WITH (NOLOCK) ON TR.TermId = T.TermId
	 WHERE		
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND -- Veri Tipi Şablonu
		TR.[Value] = 11 AND -- 11: Tutar Veri Tipi
		T.TermId <> 31 AND -- 31: Tutar Kavramı
		(T.BaseTermId <> 31 OR T.BaseTermId IS NULL) -- Tutar Kavramından Türememişler

	-- Veri Tipi İşlem Anahtarı olup İşlem Anahtarı kavramından türememiş kavrama bağlanmış olanlar	
	INSERT INTO #TMP
	SELECT "Error", "Term", T.[Name], "Hatalı Kavram Tanımı", """" + T.Name + """ kavramı ""İşlem Anahtarı"" kavramından türetilmeli." 
	  FROM  [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 INNER JOIN DTG.TermRule AS TR WITH (NOLOCK) ON TR.TermId = T.TermId
	 WHERE		
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND -- Veri Tipi Şablonu
		TR.[Value] = 19 AND -- 19: İşlem Anahtarı Veri Tipi
		T.TermId <> 48 AND -- 48: İşlem Anahtarı Kavramı
		(T.BaseTermId <> 48 OR T.BaseTermId IS NULL) -- İşlem Anahtarı Kavramından Türememişler

	-- Veri Tipi Kart Numarası olup Kart Numarası kavramından türememiş kavrama bağlanmış olanlar	
	INSERT INTO #TMP
	SELECT "Error", "Term", T.[Name], "Hatalı Kavram Tanımı", """" + T.Name + """ kavramı ""Kart Numarası"" kavramından türetilmeli." 
	  FROM  [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 INNER JOIN DTG.TermRule AS TR WITH (NOLOCK) ON TR.TermId = T.TermId
	 WHERE		
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND -- Veri Tipi Şablonu
		TR.[Value] = 21 AND -- 21: Kart Numarası Veri Tipi
		T.TermId <> 97 AND -- 97: Kart Numarası Kavramı
		(T.BaseTermId <> 97 OR T.BaseTermId IS NULL) -- Kart Numarası Kavramından Türememişler

	-- Veri Tipi Kimlik Numarası olup T.C. Kimlik Numarası kavramından türememiş kavrama bağlanmış olanlar	
	INSERT INTO #TMP
	SELECT "Error", "Term", T.[Name], "Hatalı Kavram Tanımı", """" + T.Name + """ kavramı ""T.C. Kimlik Numarası"" kavramından türetilmeli." 
	  FROM  [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 INNER JOIN DTG.TermRule AS TR WITH (NOLOCK) ON TR.TermId = T.TermId
	 WHERE		
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND -- Veri Tipi Şablonu
		TR.[Value] = 22 AND -- 22: Kimlik Numarası Veri Tipi
		T.TermId <> 17125 AND -- 17125: T.C. Kimlik Numarası Kavramı
		(T.BaseTermId <> 17125 OR T.BaseTermId IS NULL) -- T.C. Kimlik Numarası Kavramından Türememişler

	-- Veri Tipi Vergi Numarası olup Vergi Numarası kavramından türememiş kavrama bağlanmış olanlar	
	INSERT INTO #TMP
	SELECT "Error", "Term", T.[Name], "Hatalı Kavram Tanımı", """" + T.Name + """ kavramı ""Vergi Numarası"" kavramından türetilmeli." 
	  FROM  [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 INNER JOIN DTG.TermRule AS TR WITH (NOLOCK) ON TR.TermId = T.TermId
	 WHERE		
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND -- Veri Tipi Şablonu
		TR.[Value] = 23 AND -- 23: Vergi Numarası Veri Tipi
		T.TermId <> 65 AND -- 65: Vergi Numarası Kavramı
		(T.BaseTermId <> 65 OR T.BaseTermId IS NULL) -- Vergi Numarası Kavramından Türememişler

	-- Veri Tipi Döviz Kuru olup Döviz Kuru kavramından türememiş kavrama bağlanmış olanlar	
	INSERT INTO #TMP
	SELECT "Error", "Term", T.[Name], "Hatalı Kavram Tanımı", """" + T.Name + """ kavramı ""Döviz Kuru"" kavramından türetilmeli." 
	  FROM  [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 INNER JOIN DTG.TermRule AS TR WITH (NOLOCK) ON TR.TermId = T.TermId
	 WHERE		
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND -- Veri Tipi Şablonu
		TR.[Value] = 5 AND -- 5: Döviz Kuru Veri Tipi
		T.TermId <> 230 AND -- 230: Döviz Kuru Kavramı
		(T.BaseTermId <> 230 OR T.BaseTermId IS NULL) -- Döviz Kuru Kavramından Türememişler

	-- Birden Fazla Kolona Aynı Kavramın Bağlanması Kontrolü
	SELECT T.TermId, COUNT(1) AS C
	  INTO #TMP2
	  FROM  [DTG].{TBL} AS TBL WITH (NOLOCK)
	 INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	 INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	 WHERE		
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND
		TBL.TableName = @TableName
	 GROUP BY T.TermId
	HAVING COUNT(1) > 1

	INSERT INTO #TMP
	SELECT "Error", "Term", T.[Name], "Kavram İlişkilendirme Hatası", """" + T.Name + """ kavramı aynı tabloda birden fazla kolon ile ilişkilendirilmiş. Bazı istisnalar dışında bir kavram yalnızca bir kolon ile ilişkilendirilmeli." 
	  FROM DTG.Term AS T WITH (NOLOCK)
	 INNER JOIN #TMP2 WITH (NOLOCK) ON T.TermId = #TMP2.TermId

	-- Default Kolon Adı Kontrolü
    INSERT INTO #TMP
	SELECT "Warning", "Column", TC.ColumnName, "Standart Dışı Kullanım", """" + T.Name + """ kavramının standart kolon adı kullanımı [" + TR.Value + "] şeklindedir."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	  INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	  INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	  INNER JOIN DTG.TermRule TR WITH (NOLOCK) ON TR.TermId = T.TermId
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		T.TermId NOT IN(1, 8, 232) AND
		TR.TemplateType = 5 AND
		TC.ColumnName <> TR.Value

	-- Default Kolon Adı Kontrolü (Foreign Key)
    INSERT INTO #TMP
	SELECT "Warning", "Foreign Key", TC.ColumnName, "Standart Dışı Kullanım", """" + T.Name + """ kavramının standart kolon adı kullanımı [" + TC2.ColumnName + "] şeklindedir."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	  INNER JOIN [DTG].{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	  INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	  INNER JOIN DTG.{TBL} AS TBL2 WITH (NOLOCK) ON TBL2.TermId = T.TermId
	  INNER JOIN [DTG].{TC} AS TC2 WITH (NOLOCK) ON TC2.{TID} = TBL2.{TID} AND TC2.IsReference = 1
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		T.TermId NOT IN(1, 8, 232) AND
		TC.ColumnName <> TC2.ColumnName

	-- Default Veri Tipi Kontrolü
    INSERT INTO #TMP
	SELECT
		CASE TR.[Value]
			WHEN "11" THEN "Error"	-- Tutar
			WHEN "19" THEN "Error"	-- İşlem Anahtarı
			WHEN "21" THEN "Error"	-- Kart Numarası
			WHEN "22" THEN "Error"	-- Kimlik Numarası
			WHEN "23" THEN "Error"	-- Vergi Numarası
			WHEN "5" THEN "Error"	-- Döviz Kuru
			ELSE "Warning"
		END,
		"Column", TC.ColumnName, "Standart Dışı Kullanım", """" + T.Name + """ kavramının standart veri tipi kullanımı " + DTM.Value + " şeklindedir."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	  INNER JOIN DTG.{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	  INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	  INNER JOIN DTG.TermRule TR WITH (NOLOCK) ON TR.TermId = T.TermId
	  INNER JOIN DTG.DataTypeMatch DTM WITH (NOLOCK) ON DTM.DataTypeId = TR.Value AND DTM.DataTypeLanguageId = 1
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND
		TC.DataType <> DTM.[Value]

	-- Default Veri Tipi Kontrolü (Foreign Key)
    INSERT INTO #TMP
	SELECT
		CASE TR.[Value]
			WHEN "11" THEN "Error"	-- Tutar
			WHEN "19" THEN "Error"	-- İşlem Anahtarı
			WHEN "21" THEN "Error"	-- Kart Numarası
			WHEN "22" THEN "Error"	-- Kimlik Numarası
			WHEN "23" THEN "Error"	-- Vergi Numarası
			WHEN "5" THEN "Error"	-- Döviz Kuru
			ELSE "Warning"
		END,
		"Foreign Key", TC.ColumnName, "Standart Dışı Kullanım", """" + T.Name + """ kavramının standart veri tipi kullanımı " + DTM.Value + " şeklindedir."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	  INNER JOIN DTG.{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	  INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	  INNER JOIN DTG.[Table] AS TBL2 WITH (NOLOCK) ON TBL2.TermId = T.TermId
	  INNER JOIN DTG.[TableColumn] AS TC2 WITH (NOLOCK) ON TC2.TableId = TBL2.TableId AND TC2.IsReference = 1
	  INNER JOIN DTG.Term AS T2 WITH (NOLOCK) ON T2.TermId = TC2.TermId
	  INNER JOIN DTG.TermRule TR WITH (NOLOCK) ON TR.TermId = T2.TermId
	  INNER JOIN DTG.DataTypeMatch DTM WITH (NOLOCK) ON DTM.DataTypeId = TR.Value AND DTM.DataTypeLanguageId = 1
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND
		TC.DataType <> DTM.[Value]

	-- Fiziksel Veri Tipi İle Kavramsal Veri Tipi Uyumsuzluğu
    INSERT INTO #TMP
	SELECT "Error", "Column", TC.ColumnName, "Veri Tipi Uyumsuzluğu", """" + T.Name + """ kavramının varsayılan " + DTM.Value + " (" + [DTG].[fConvertDataTypeForDataMaskProcess](DTM.Value) + ") veri tipi ile """ 
		+ TC.ColumnName + """ kolonunun tanımlanan " + TC.DataType + " (" + [DTG].[fConvertDataTypeForDataMaskProcess](TC.DataType) + ") veri tipi uyumsuzdur."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	  INNER JOIN DTG.{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	  INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	  INNER JOIN DTG.TermRule TR WITH (NOLOCK) ON TR.TermId = T.TermId
	  INNER JOIN DTG.DataTypeMatch DTM WITH (NOLOCK) ON DTM.DataTypeId = TR.Value
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND
		TC.DataType <> DTM.[Value] AND
		[DTG].[fConvertDataTypeForDataMaskProcess](TC.DataType) <> [DTG].[fConvertDataTypeForDataMaskProcess](DTM.Value)

	-- Fiziksel Veri Tipi İle Kavramsal Veri Tipi Uyumsuzluğu (Foreign Key)
    INSERT INTO #TMP
	SELECT "Error", "Column", TC.ColumnName, "Veri Tipi Uyumsuzluğu", """" + T2.Name + """ kavramının varsayılan " + DTM.Value + " (" + [DTG].[fConvertDataTypeForDataMaskProcess](DTM.Value) + ") veri tipi ile """ 
		+ TC.ColumnName + """ kolonunun tanımlanan " + TC.DataType + " (" + [DTG].[fConvertDataTypeForDataMaskProcess](TC.DataType) + ") veri tipi uyumsuzdur."
	  FROM [DTG].{TBL} AS TBL WITH (NOLOCK)
	  INNER JOIN DTG.{TC} AS TC WITH (NOLOCK) ON TC.{TID} = TBL.{TID}
	  INNER JOIN DTG.Term AS T WITH (NOLOCK) ON T.TermId = TC.TermId
	  INNER JOIN DTG.[Table] AS TBL2 WITH (NOLOCK) ON TBL2.TermId = T.TermId
	  INNER JOIN DTG.[TableColumn] AS TC2 WITH (NOLOCK) ON TC2.TableId = TBL2.TableId AND TC2.IsReference = 1
	  INNER JOIN DTG.Term AS T2 WITH (NOLOCK) ON T2.TermId = TC2.TermId
	  INNER JOIN DTG.TermRule TR WITH (NOLOCK) ON TR.TermId = T2.TermId
	  INNER JOIN DTG.DataTypeMatch DTM WITH (NOLOCK) ON DTM.DataTypeId = TR.Value AND DTM.DataTypeLanguageId = 1
	 WHERE 
		TBL.DBName = @DBName AND 
		TBL.SchemaName = @SchemaName AND 
		TBL.TableName = @TableName AND
		TR.TemplateType = 3 AND
		TC.DataType <> DTM.[Value] AND
		[DTG].[fConvertDataTypeForDataMaskProcess](TC.DataType) <> [DTG].[fConvertDataTypeForDataMaskProcess](DTM.Value)
	'
	
	SELECT @ExecuteString = REPLACE(@ExecuteString, '@DBName', '"' + @DBName +'"')
	SELECT @ExecuteString = REPLACE(@ExecuteString, '@SchemaName', '"' + @SchemaName +'"')
	SELECT @ExecuteString = REPLACE(@ExecuteString, '@TableName', '"' + @TableName +'"')
	SELECT @ExecuteString = REPLACE(@ExecuteString, '"', '''')

	IF @IsDraftControl = 1
	BEGIN
		SELECT @ExecuteString = REPLACE(@ExecuteString, '{TBL}', '[TableDraft]')
		SELECT @ExecuteString = REPLACE(@ExecuteString, '{TC}', '[TableColumnDraft]')
		SELECT @ExecuteString = REPLACE(@ExecuteString, '{TID}', '[TableDraftId]')
	END
	ELSE
	BEGIN
		SELECT @ExecuteString = REPLACE(@ExecuteString, '{TBL}', '[Table]')
		SELECT @ExecuteString = REPLACE(@ExecuteString, '{TC}', '[TableColumn]')
		SELECT @ExecuteString = REPLACE(@ExecuteString, '{TID}', '[TableId]')
	END

	EXECUTE sp_executesql @ExecuteString

	SELECT Id, Severity, [Error], [ItemType], [ItemName], [Description]
	  FROM #TMP
	 ORDER BY Severity, Id

	END