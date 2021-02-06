
CREATE PROCEDURE [DTG].[sel_Property]
AS
	SET NOCOUNT ON

	SELECT
	  [PropertyId]
      ,[Name]
      ,[NameEN]
      ,[Description]
      ,[DescriptionEN]
      ,[PropertyCode]
      ,[DataType]
      ,[DataCount]
      ,[IsRequired]
      ,[ParameterType]
      ,[UserName]
      ,[SystemDate]
      ,[HostName]
      ,[UpdateUserName]
      ,[UpdateHostName]
      ,[UpdateSystemDate]
      ,[HostIP]
      ,[TargetEntity]
	 FROM [DTG].[Property] P WITH (NOLOCK)
	 ORDER BY [Name] ASC