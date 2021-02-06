﻿/* KUWAIT TURKISH PARTICIPATION BANK INC.
*
*  All rights are reserved. Reproduction or transmission in whole or in part in
*  any form or by any means electronic mechanical or otherwise is prohibited
*  without the prior written consent of the copyright owner.
*
*
*  Generator Information
*		Generator				: BOAContainer
*		Generated By			: karadayi
*		Generated Date			: 27/12/2017
*		File Version			: 1.0
*		Purpose					: Data Governance - Veri Modelleme Sistemi Parametreleri için update prosedürü
*		Last Modified By		: karadayi
*		Last Modification Date	: 
*
*/
CREATE PROCEDURE [DTG].[upd_Parameter]
(
	@ParamType VARCHAR(20)
    ,@ParamCode VARCHAR(20)
    ,@ParamValue VARCHAR(50)
    ,@ParamDescription VARCHAR(200) = NULL
    ,@ParamValue2 VARCHAR(50) = NULL
    ,@ParamValue3 VARCHAR(50) = NULL
    ,@ParamValue4 VARCHAR(50) = NULL
    ,@ParamValue5 VARCHAR(50) = NULL
    ,@LanguageId INT
    ,@SortOrder TINYINT = NULL
	,@OldParamType VARCHAR(20)
    ,@OldParamCode VARCHAR(20)
	,@OldLanguageId INT
)
AS
	SET NOCOUNT ON
BEGIN

	UPDATE [DTG].[Parameter]
	   SET [ParamType] = @ParamType
		  ,[ParamCode] = @ParamCode
		  ,[ParamValue] = @ParamValue
		  ,[ParamDescription] = @ParamDescription
		  ,[ParamValue2] = @ParamValue2
		  ,[ParamValue3] = @ParamValue3
		  ,[ParamValue4] = @ParamValue4
		  ,[ParamValue5] = @ParamValue5
		  ,[LanguageId] = @LanguageId
		  ,[SortOrder] = @SortOrder
	 WHERE [ParamType] = @OldParamType
		   AND [ParamCode] = @OldParamCode
		   AND [LanguageId] = @OldLanguageId

END