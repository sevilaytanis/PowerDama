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
*		Generated Date			: 15/03/2016 15:42:31
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 15/03/2016 15:42:31
*
*/
CREATE PROCEDURE [DTG].[del_TableDraft]
(
	@TableDraftId INT
)
AS
	SET NOCOUNT ON;
BEGIN

	DELETE FROM [DTG].[TableDraft]
	 WHERE TableDraftId = @TableDraftId

END