
CREATE PROCEDURE [DTG].[upd_TermRecommendation]
(
	@TermRecommendationId INT,
	@Status TINYINT,
	@Name VARCHAR(200) = NULL,
	@NameEN VARCHAR(200) = NULL,
	@Description VARCHAR(2000) = NULL,
	@DescriptionEN VARCHAR(2000) = NULL,
	@UpdateUserName VARCHAR(10) = NULL,
	@UpdateHostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL
)
AS
	SET NOCOUNT ON
	
	UPDATE [DTG].[TermRecommendation] SET
		[Status] = @Status,
		[Name] = @Name,
		[NameEN] = @NameEN,
		[Description] = @Description,
		[DescriptionEN] = @DescriptionEN,
		UpdateUserName = @UpdateUserName,
		UpdateHostName = @UpdateHostName,
		UpdateSystemDate = GETDATE(),
		HostIP = @HostIP
	WHERE TermRecommendationId = @TermRecommendationId