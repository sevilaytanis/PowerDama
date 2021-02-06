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
*		Generated Date			: 21/03/2018
*		File Version			: 1.0
*		Purpose					: KVKK Kapsamında Veri Silme Taleplerini Karşılayabilmek Adını Müşteri Verilerinin Ne Olduğunu Bulan Sistemin Yönetim Detay Tablosundan İlgili Kaydı Siler
*		Last Modified By		: karadayi
*		Last Modification Date	: 21/03/2018
*
*/
CREATE PROCEDURE [DTG].[del_CustomerDataRequestDetail]
(
	@CustomerDataRequestId INT,
	@TermId INT
)
AS
SET NOCOUNT ON
BEGIN

	DELETE FROM [DTG].[CustomerDataRequestDetail]
	 WHERE CustomerDataRequestId = @CustomerDataRequestId AND
		   [TermId] = @TermId

END