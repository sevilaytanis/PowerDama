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
*		Generated Date			: 14/11/2016
*		File Version			: 1.0
*		Purpose					: <Lütfen açıklama giriniz.>
*		Last Modified By		: karadayi
*		Last Modification Date	: 14/11/2016
*
*/
CREATE PROCEDURE [DTG].[tsk_CountUpTheTermUse]

AS
	SET NOCOUNT ON
		
	UPDATE DTG.Term 
	   SET UseCount = DTG.[fGetTermUseCount](TermId)
	  FROM DTG.Term