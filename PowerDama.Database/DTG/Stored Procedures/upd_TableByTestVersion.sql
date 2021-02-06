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
*		Generated Date			: 08/08/2016
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 26/01/2017
*
*/
CREATE PROCEDURE [DTG].[upd_TableByTestVersion]
(
	@DBName VARCHAR(50),
	@SchemaName VARCHAR(20),
	@TableName VARCHAR(50),
	@Version TINYINT = NULL
)
AS
	SET NOCOUNT ON

	UPDATE [DTG].[Table] SET
		TestVersion = @Version
	WHERE DBName = @DBName
		AND SchemaName = @SchemaName
		AND TableName = @TableName