
CREATE PROCEDURE [DTG].[upd_ValidateByCustomerRightsUnit]
(
	@TermId INT,
	@IsPrivateData TINYINT,
	@ValidatedByCustomerRightsUnit TINYINT = 1,
	@UpdateUserName VARCHAR(10) = NULL,
	@UpdateHostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL
)
AS
SET NOCOUNT ON
BEGIN

	UPDATE [DTG].[Term] 
	   SET
		ValidatedByCustomerRightsUnit = @ValidatedByCustomerRightsUnit,
		IsPrivateData = @IsPrivateData,
		UpdateUserName = @UpdateUserName,
		UpdateHostName = @UpdateHostName,
		UpdateSystemDate = GETDATE(),
		HostIP = @HostIP
	WHERE TermId = @TermId

END