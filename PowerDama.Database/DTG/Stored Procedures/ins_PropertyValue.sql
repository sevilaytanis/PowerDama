
CREATE PROCEDURE [DTG].[ins_PropertyValue]
(
	@EntityId INT,
	@PropertyId INT,
	@BoolValue TINYINT= NULL,
	@DateValue DATETIME = NULL,
	@TextValue NVARCHAR(255) = NULL,
	@NumericValue DECIMAL(38,4) = NULL,
	@RichTextValue NVARCHAR(MAX) = NULL,
	@ParamCode INT = NULL,
	@UserName VARCHAR(10) = NULL,
	@HostName VARCHAR(20) = NULL,
	@HostIP VARCHAR(15) = NULL
)
AS
	SET NOCOUNT ON

	INSERT INTO [DTG].[PropertyValue]
	(
		[EntityId]
		,[PropertyId]
		,[BoolValue]
		,[DateValue]
		,[TextValue]
		,[NumericValue]
		,[RichTextValue]
		,[ParamCode]
		,[UserName]
		,[SystemDate]
		,[HostName]
		,[HostIP]
	)
	VALUES
	(
		@EntityId
		,@PropertyId
		,@BoolValue
		,@DateValue
		,@TextValue
		,@NumericValue
		,@RichTextValue
		,@ParamCode
		,@UserName
		,GETDATE()
		,@HostName
		,@HostIP
	)

	SELECT CAST(SCOPE_IDENTITY() AS INT)