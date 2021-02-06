
CREATE PROCEDURE [DTG].[upd_PropertyValue]
(
	@PropertyValueId INT,
	@BoolValue TINYINT= NULL,
	@DateValue DATETIME = NULL,
	@TextValue NVARCHAR(255) = NULL,
	@NumericValue DECIMAL(38,4) = NULL,
	@RichTextValue NVARCHAR(MAX) = NULL,
	@ParamCode INT = NULL,
	@UpdateUserName VARCHAR(10) = NULL,
	@UpdateHostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL
)
AS
SET NOCOUNT ON
BEGIN

	UPDATE [DTG].[PropertyValue] 
	   SET
		BoolValue = @BoolValue,
		DateValue = @DateValue,
		TextValue = @TextValue,
		NumericValue = @NumericValue,
		RichTextValue = @RichTextValue,
		ParamCode = @ParamCode,
		UpdateUserName = @UpdateUserName,
		UpdateHostName = @UpdateHostName,
		UpdateSystemDate = GETDATE(),
		HostIP = @HostIP
	WHERE PropertyValueId = @PropertyValueId

END