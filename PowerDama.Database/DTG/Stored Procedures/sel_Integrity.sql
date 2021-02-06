CREATE PROCEDURE [DTG].[sel_Integrity]
@LanguageId TINYINT = 1
AS
	 
SET NOCOUNT ON;

	SELECT *
	FROM [BOACatalog].[DTG].[Integrity] WITH (NOLOCK)
	WHERE LanguageId = @LanguageId