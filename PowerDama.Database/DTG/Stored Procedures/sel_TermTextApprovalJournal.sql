
CREATE PROCEDURE [DTG].[sel_TermTextApprovalJournal]
	@TermId INT
AS
	SET NOCOUNT ON

	SELECT
	  TTAJ.TermTextApprovalJournalId 
	  ,TTAJ.TermId
	  ,TTAJ.TextApprovalStatus
	  ,TTAJ.Description
	  ,TTAJ.Status 
	  ,TTAJ.UserName
	  ,TTAJ.SystemDate
	  ,TTAJ.HostName 
	  ,TTAJ.HostIP
	  ,TTAJ.UpdateUserName 
	  ,TTAJ.UpdateHostName
	  ,TTAJ.UpdateSystemDate
	  ,TR.TermRecommendationId
	  ,TR.Name AS TermName
	  ,TR.NameEN AS TermNameEN
	  ,TR.Description AS TermDescription
	  ,TR.DescriptionEN AS TermDescriptionEN
	  FROM DTG.TermTextApprovalJournal AS TTAJ WITH (NOLOCK)
	  LEFT OUTER JOIN DTG.TermRecommendation AS TR WITH (NOLOCK) ON TR.TermRecommendationId = TTAJ.TermRecommendationId
	  WHERE TTAJ.TermId = @TermId
	ORDER BY TTAJ.TermTextApprovalJournalId DESC