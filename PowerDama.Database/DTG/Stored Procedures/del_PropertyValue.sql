
CREATE PROCEDURE [DTG].[del_PropertyValue]
(
	@PropertyValueId INT
)
AS
	SET NOCOUNT ON

	DELETE FROM [DTG].[PropertyValue]
	 WHERE PropertyValueId = @PropertyValueId