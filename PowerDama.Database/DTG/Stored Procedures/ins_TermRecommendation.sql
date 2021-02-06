
CREATE PROCEDURE [DTG].[ins_TermRecommendation]
(
	@TermId INT,
	@Status TINYINT,
	@Name VARCHAR(200) = NULL,
	@NameEN VARCHAR(200) = NULL,
	@Description VARCHAR(2000) = NULL,
	@DescriptionEN VARCHAR(2000) = NULL,
	@UserName VARCHAR(10) = NULL,
	@HostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL
)
AS
	SET NOCOUNT ON
	INSERT INTO [DTG].[TermRecommendation]
	(
		[TermId]
		,[Name]
		,[NameEN]
		,[Description]
		,[DescriptionEN]
		,[Status]
		,[UserName]
		,[SystemDate]
		,[HostName]
		,[HostIP]
	)
	VALUES
	(
		@TermId
		,@Name
		,@NameEN
		,@Description
		,@DescriptionEN
		,@Status
		,@UserName
		,GETDATE()
		,@HostName
		,@HostIP
	)
	SELECT CAST(SCOPE_IDENTITY() AS INT)