
CREATE PROCEDURE [DTG].[ins_TermTextApprovalJournal]
(
	@TermId INT,
	@TextApprovalStatus TINYINT,
	@Status TINYINT,
	@Description VARCHAR(2000) = NULL,
	@UserName VARCHAR(10) = NULL,
	@HostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL,
	@TermRecommendationId INT = NULL
)
AS
	SET NOCOUNT ON
	
	UPDATE [DTG].[Term] SET CopyWriterApproval = @TextApprovalStatus, UpdateSystemDate = GETDATE(), UpdateUserName = @UserName, UpdateHostName = @HostName, HostIP = @HostIP WHERE TermId = @TermId
	UPDATE [DTG].[TermTextApprovalJournal] SET Status = 0 WHERE Status = 1 AND TermId = @TermId

	INSERT INTO [DTG].[TermTextApprovalJournal]
	(
		[TermId]
		,[TextApprovalStatus]
		,[Description]
		,[Status]
		,[UserName]
		,[SystemDate]
		,[HostName]
		,[HostIP]
		,[TermRecommendationId]
	)
	VALUES
	(
		@TermId
		,@TextApprovalStatus
		,@Description
		,@Status
		,@UserName
		,GETDATE()
		,@HostName
		,@HostIP
		,@TermRecommendationId
	)
	SELECT CAST(SCOPE_IDENTITY() AS INT)