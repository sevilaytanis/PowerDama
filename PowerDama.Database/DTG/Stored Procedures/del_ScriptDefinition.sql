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
*		Generated Date			: 27/07/2018
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: 
*		Last Modification Date	: 
*
*/
CREATE PROCEDURE [DTG].[del_ScriptDefinition]
@ScriptInventoryId INT
AS
SET NOCOUNT ON
BEGIN
	DECLARE @ScriptDefinitionId INT

	SELECT  @ScriptDefinitionId = ScriptDefinitionId
	  FROM [DTG].[ScriptInventory] WITH (NOLOCK)
     WHERE ScriptInventoryId = @ScriptInventoryId

    DELETE FROM [DTG].[ScriptDefinition]
     WHERE ScriptDefinitionId = @ScriptDefinitionId

    DELETE FROM [DTG].[ScriptInventory]
     WHERE ScriptInventoryId = @ScriptInventoryId
END