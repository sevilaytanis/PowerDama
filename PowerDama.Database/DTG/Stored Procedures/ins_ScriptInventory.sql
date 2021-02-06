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
*		Generated Date			: 10/07/2018
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: 
*		Last Modification Date	: 
*
*/
CREATE PROCEDURE [DTG].[ins_ScriptInventory]
@ScriptInventoryType TINYINT
,@ScriptDefinitionId INT
,@TermId INT = NULL
,@DatabaseName VARCHAR(100)
,@SchemaName VARCHAR(100)
,@TableName VARCHAR(100)
,@ColumnName VARCHAR(50)
,@UserName VARCHAR(10)
,@HostName VARCHAR(20)
,@HostIP VARCHAR(15)
AS
SET NOCOUNT ON
BEGIN
   INSERT INTO [DTG].[ScriptInventory]
           ([ScriptInventoryType]
           ,[ScriptDefinitionId]
		   ,[TermId]
           ,[DatabaseName]
           ,[SchemaName]
           ,[TableName]
           ,[ColumnName]
           ,[UserName]
           ,[HostName]
           ,[SystemDate]
           ,[HostIP])
     VALUES
           (@ScriptInventoryType
           ,@ScriptDefinitionId
		   ,@TermId
           ,@DatabaseName
           ,@SchemaName
           ,@TableName
           ,@ColumnName
           ,@UserName
           ,@HostName
           ,GETDATE()
           ,@HostIP)

	SELECT CAST(SCOPE_IDENTITY() AS INT)
END