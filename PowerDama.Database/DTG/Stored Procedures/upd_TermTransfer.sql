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
*		Generated Date			: 16/06/2016
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 16/06/2016
*
*/
CREATE PROCEDURE [DTG].[upd_TermTransfer]
(
	@FromTermId INT,
	@ToTermId INT
)
AS
	SET NOCOUNT ON;

	UPDATE [DTG].[TableDraft] SET
		TermId = @ToTermId
	WHERE TermId = @FromTermId

	UPDATE [DTG].[TableColumnDraft] SET
		TermId = @ToTermId
	WHERE TermId = @FromTermId

	UPDATE [DTG].[Table] SET
		TermId = @ToTermId
	WHERE TermId = @FromTermId

	UPDATE [DTG].[TableColumn] SET
		TermId = @ToTermId
	WHERE TermId = @FromTermId