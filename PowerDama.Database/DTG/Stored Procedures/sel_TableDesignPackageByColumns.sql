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
*		Generated Date			: 20/03/2016 21:52:29
*		File Version			: 1.0
*		Purpose					: UserCode fields added to the select list
*		Last Modified By		: karadayi
*		Last Modification Date	: 29/11/2017
*
*/
CREATE PROCEDURE [DTG].[sel_TableDesignPackageByColumns]
(
	@DBName VARCHAR(20) = NULL,
	@SchemaName VARCHAR(3) = NULL,
	@TableName VARCHAR(100) = NULL,
	@Status TINYINT = NULL,
	@UserName VARCHAR(10) = NULL,
	@StartDate DATETIME = NULL,
	@EndDate DATETIME = NULL,
	@LanguageId TINYINT = 1
)
AS
	 
SET NOCOUNT ON

	SELECT
		TD.TableDesignPackageId,
		TD.DBName,
		TD.SchemaName,
		TD.TableName,
		TD.RejectReason,
		TD.Script,
		TD.[Status],
		CASE @LanguageId
			WHEN 1 THEN S.Name
			ELSE S.NameEN
		END AS StatusDescription,
		U.UserCode,
		U.[Name] AS UserName,
		TD.HostName,
		U2.UserCode AS UpdateUserCode,
		U2.[Name] AS UpdateUserName,
		TD.UpdateHostName,
		TD.HostIP,
		TD.SystemDate,
		TD.UpdateSystemDate,
		TD.[Version],
		TD.DevelopmentLocation
  FROM [DTG].[TableDesignPackage] TD WITH (NOLOCK)
  INNER JOIN DTG.[Status] S WITH (NOLOCK)
		  ON S.StatusId = TD.[Status]
  LEFT JOIN [BOA].[COR].[BOAUSER] U WITH (NOLOCK)
			ON TD.UserName = U.UserCode
  LEFT JOIN [BOA].[COR].[BOAUSER] U2 WITH (NOLOCK)
			ON TD.UpdateUserName = U2.UserCode
  WHERE (@DBName IS NULL OR DBName = @DBName)
    AND (@SchemaName IS NULL OR SchemaName = @SchemaName)
    AND (@TableName IS NULL OR TableName = @TableName)
    AND (@Status IS NULL OR TD.[Status] = @Status)
    AND (@UserName IS NULL OR TD.UserName = @UserName)
	AND (
			(@StartDate IS NULL AND @EndDate IS NULL)
			OR TD.SystemDate BETWEEN @StartDate AND @EndDate
		)
  ORDER BY TD.UpdateSystemDate DESC, TD.SystemDate DESC