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
*		Generated Date			: 11/03/2016 08:46:45
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 05/12/2017
*
*/
CREATE PROCEDURE [DTG].[sel_UpdateItemAuthorizationForTableDDLScript]
AS
	 
SET NOCOUNT ON
	BEGIN

	SELECT U.UserId, U.UserCode, U.[Name], U.Email, U.WorkgroupId, U.ServiceName, U.DepartmentName	
	  FROM [DTG].[UpdateItemAuthorizationForTableDDLScript] AS A WITH (NOLOCK) 
	 INNER JOIN [DTG].[vUser] AS U WITH (NOLOCK) ON U.UserCode = A.UserCode
END