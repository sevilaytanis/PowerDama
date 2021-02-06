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
*		Generated Date			: 11/03/2016 08:46:45
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 15/06/2017 
*
*/
CREATE PROCEDURE [DTG].[sel_TableByKey]
(
	@TableId INT
)
AS
	SET NOCOUNT ON

	SELECT
		TBL.TableId,
		TBL.DBName,
		TBL.SchemaName,
		TBL.TableName,
		TBL.TermId,
		T.Name AS TermName,
		T.Description AS TermDescription, 
		T.Level1Domain AS TermLevel1Domain,
		T.Level2Domain AS TermLevel2Domain,
		TBL.IsEntity,
		TBL.[Description],
		TBL.[Status],
		TBL.UserName,
		TBL.UpdateUserName,
		TBL.DevVersion,
		TBL.TestVersion,
		TBL.PrepVersion,
		TBL.ProdVersion,
		TBL.LogTableName,
		TBL.TableType
	FROM [DTG].[Table] AS TBL WITH (NOLOCK)
	LEFT JOIN DTG.Term AS T WITH (NOLOCK)
		ON T.TermId = TBL.TermId
	WHERE TBL.TableId = @TableId