
CREATE PROCEDURE [DTG].[sel_TermTextApprovalJournalByColumns]
	@TermId INT,
	@Status TINYINT = NULL,
	@TextApprovalStatus TINYINT = NULL
AS
	SET NOCOUNT ON

	SELECT
		TTAJ.[TermTextApprovalJournalId]
		,TTAJ.[TermId]
		,TTAJ.[TextApprovalStatus]
		,TTAJ.[Description]
		,TTAJ.[Status]
		,TTAJ.[UserName]
		,TTAJ.[SystemDate]
		,TTAJ.[HostName]
		,TTAJ.[HostIP]
	FROM [DTG].[TermTextApprovalJournal] TTAJ WITH (NOLOCK)	 
	WHERE TTAJ.TermId = @TermId
		AND ((@Status IS NULL) OR TTAJ.Status = @Status)
		AND ((@TextApprovalStatus IS NULL) OR TTAJ.TextApprovalStatus = @TextApprovalStatus)
	ORDER BY TTAJ.[TermTextApprovalJournalId] DESC