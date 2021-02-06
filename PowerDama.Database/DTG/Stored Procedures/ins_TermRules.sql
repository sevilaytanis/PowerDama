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
*		Generated Date			: 03/03/2016 10:17:29
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 03/03/2016 10:17:29
*
*/
CREATE PROCEDURE [DTG].[ins_TermRules]
(
	@TermId INT,
	@IsTemplateDataType VARCHAR(10) = '0',
	@IfDataTypeInconsistencyExists VARCHAR(10) = '0',
	@DataTemplate VARCHAR(200) = NULL,
	@ValueSet VARCHAR(200) = NULL,
	@TableColumnName VARCHAR(50) = NULL
)
AS
	SET NOCOUNT ON;
BEGIN
	IF @IsTemplateDataType = UPPER('TRUE')
		SET @IsTemplateDataType = '1'
	ELSE IF @IsTemplateDataType = UPPER('FALSE')
		SET @IsTemplateDataType = '0'
		
	IF @IfDataTypeInconsistencyExists = UPPER('TRUE')
		SET @IfDataTypeInconsistencyExists = '1'
	ELSE IF @IfDataTypeInconsistencyExists = UPPER('FALSE')
		SET @IfDataTypeInconsistencyExists = '0'

	--1	Şablon veri tipi mi? 
	IF NOT EXISTS(SELECT 1 FROM DTG.TermRule WITH (NOLOCK)
				   WHERE TermId = @TermId
				     AND TemplateType = 1)
	BEGIN
		INSERT INTO DTG.TermRule(TermId,TemplateType,Value,AlertStatus)
		VALUES (@TermId,1,@IsTemplateDataType,1)
	END
	ELSE
	BEGIN
		UPDATE DTG.TermRule
		   SET Value = @IsTemplateDataType
		 WHERE TermId = @TermId AND TemplateType = 1 
	END

	--2	Şablon veri tipi uyuşmazlığı var mı?
	IF NOT EXISTS(SELECT 1 FROM DTG.TermRule WITH (NOLOCK)
	               WHERE TermId = @TermId
				     AND TemplateType = 2)
	BEGIN
		INSERT INTO DTG.TermRule(TermId,TemplateType,Value,AlertStatus)
		VALUES (@TermId,2,@IfDataTypeInconsistencyExists,1)
	END
	ELSE
	BEGIN
		UPDATE DTG.TermRule
		   SET Value = @IfDataTypeInconsistencyExists
		 WHERE TermId = @TermId AND TemplateType = 2 
	END

	--3	Veri şablonu
	IF @DataTemplate IS NOT NULL
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM DTG.TermRule WITH (NOLOCK)
		               WHERE TermId = @TermId
					     AND TemplateType = 3)
		BEGIN
			INSERT INTO DTG.TermRule(TermId,TemplateType,Value,AlertStatus)
			VALUES (@TermId,3,@DataTemplate,1)
		END
		ELSE
		BEGIN
			UPDATE DTG.TermRule
			   SET Value = @DataTemplate
			 WHERE TermId = @TermId AND TemplateType = 3 
		END
	END

	--4	Değer seti
	IF @ValueSet IS NOT NULL
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM DTG.TermRule WITH (NOLOCK)
		               WHERE TermId = @TermId
					     AND TemplateType = 4)
		BEGIN
			INSERT INTO DTG.TermRule(TermId,TemplateType,Value,AlertStatus)
			VALUES (@TermId,4,@ValueSet,1)
		END
		ELSE
		BEGIN
			UPDATE DTG.TermRule
			   SET Value = @ValueSet
			 WHERE TermId = @TermId AND TemplateType = 4
		END
	END

	--5	Tablo kolon adı
	IF @TableColumnName IS NOT NULL
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM DTG.TermRule WITH (NOLOCK)
		               WHERE TermId = @TermId
					     AND TemplateType = 5)
		BEGIN
			INSERT INTO DTG.TermRule(TermId,TemplateType,Value,AlertStatus)
			VALUES (@TermId,5,@TableColumnName,1)
		END
		ELSE
		BEGIN
			UPDATE DTG.TermRule
			   SET Value = @TableColumnName
			 WHERE TermId = @TermId AND TemplateType = 5
		END
	END
END