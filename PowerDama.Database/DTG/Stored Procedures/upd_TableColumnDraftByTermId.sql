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
*		Generated Date			: 09/06/2016 10:55:09
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 09/06/2016 10:55:09
*
*/
CREATE PROCEDURE [DTG].[upd_TableColumnDraftByTermId]
(
	@TableColumnDraftId INT,
	@TermId INT = NULL
)
AS
	SET NOCOUNT ON;
BEGIN

	UPDATE [DTG].[TableColumnDraft] SET
		TermId = @TermId
	WHERE TableColumnDraftId = @TableColumnDraftId

END