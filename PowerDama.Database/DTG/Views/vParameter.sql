









CREATE VIEW  [DTG].[vParameter]
AS

SELECT ParamType, ParamCode, ParamDescription, ParamValue, ParamValue2, ParamValue3, ParamValue4, ParamValue5, ParamValue6, ParamValue7, ParamValue8, ParamDate, LanguageId, UserName, HostName, SystemDate, UpdateUserName, UpdateHostName, UpdateSystemDate ,ParamGroupCode, SortOrder
  FROM [CORParameter].[dbo].[Parameter] WITH (NOLOCK)
 WHERE ParamGroupCode = 'DTG' AND
	ParamType = 'INFORMATIONTYPE'
UNION
SELECT ParamType, ParamCode, ParamDescription, ParamValue, ParamValue2, ParamValue3, ParamValue4, ParamValue5, ParamValue6, ParamValue7, ParamValue8, ParamDate, LanguageId, UserName, HostName, SystemDate, UpdateUserName, UpdateHostName, UpdateSystemDate ,ParamGroupCode, SortOrder
  FROM [CORParameter].[dbo].[Parameter] WITH (NOLOCK)
 WHERE ParamGroupCode = 'DTG' AND
	ParamType = 'SENSITIVITY'
UNION

SELECT ParamType, ParamCode, ParamDescription, ParamValue, ParamValue2, ParamValue3, ParamValue4, ParamValue5, ParamValue6, ParamValue7, ParamValue8, ParamDate, LanguageId, UserName, HostName, SystemDate, UpdateUserName, UpdateHostName, UpdateSystemDate ,ParamGroupCode, SortOrder
  FROM [CORParameter].[dbo].[Parameter] WITH (NOLOCK)
 WHERE ParamGroupCode = 'DTG' AND
	ParamType = 'INTEGRITY'

UNION

SELECT ParamType, ParamCode, ParamDescription, ParamValue, ParamValue2, ParamValue3, ParamValue4, ParamValue5, ParamValue6, ParamValue7, ParamValue8, ParamDate, LanguageId, UserName, HostName, SystemDate, UpdateUserName, UpdateHostName, UpdateSystemDate ,ParamGroupCode, SortOrder
  FROM [CORParameter].[dbo].[Parameter] WITH (NOLOCK)
 WHERE ParamGroupCode = 'DTG' AND
	ParamType = 'ACCESSIBILITY'
UNION

SELECT ParamType, ParamCode, ParamDescription, ParamValue, ParamValue2, ParamValue3, ParamValue4, ParamValue5, ParamValue6, ParamValue7, ParamValue8, ParamDate, LanguageId, UserName, HostName, SystemDate, UpdateUserName, UpdateHostName, UpdateSystemDate ,ParamGroupCode, SortOrder
  FROM [CORParameter].[dbo].[Parameter] WITH (NOLOCK)
 WHERE ParamGroupCode = 'DTG' AND
	ParamType = 'TABLETYPE'
UNION
SELECT ParamType, ParamCode, ParamDescription, ParamValue, ParamValue2, ParamValue3, ParamValue4, ParamValue5, ParamValue6, ParamValue7, ParamValue8, ParamDate, LanguageId, UserName, HostName, SystemDate, UpdateUserName, UpdateHostName, UpdateSystemDate ,ParamGroupCode, SortOrder
  FROM [CORParameter].[dbo].[Parameter] WITH (NOLOCK)
 WHERE ParamGroupCode = 'DTG' AND
	ParamType = 'DATAMASK'