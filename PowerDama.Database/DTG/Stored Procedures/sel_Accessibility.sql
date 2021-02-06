CREATE PROCEDURE [DTG].[sel_Accessibility]
@LanguageId TINYINT = 1
AS
	 
SET NOCOUNT ON;

	SELECT *
	FROM [BOACatalog].[DTG].[Accessibility] WITH (NOLOCK)
	WHERE LanguageId = @LanguageId