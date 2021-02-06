
CREATE PROCEDURE [DTG].[sel_TermRecommendationByColumns]
	@TermId INT,
	@Status TINYINT = NULL
AS
	SET NOCOUNT ON

	SELECT
		TR.[TermRecommendationId]
		,TR.[TermId]
		,TR.[Name]
		,TR.[NameEN]
		,TR.[Description]
		,TR.[DescriptionEN]
		,TR.[Status]
		,TR.[UserName]
		,TR.[SystemDate]
		,TR.[HostName]
		,TR.[HostIP]
	FROM [DTG].[TermRecommendation] TR WITH (NOLOCK)	 
	WHERE TR.TermId = @TermId
		AND ((@Status IS NULL) OR TR.Status = @Status)
	ORDER BY TR.[TermRecommendationId] DESC