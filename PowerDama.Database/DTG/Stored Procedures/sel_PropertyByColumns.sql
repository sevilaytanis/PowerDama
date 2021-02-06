
CREATE PROCEDURE [DTG].[sel_PropertyByColumns]
	@Name VARCHAR(200) = NULL,
	@NameEN VARCHAR(200) = NULL,
	@TargetEntity TINYINT = NULL
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
	 WHERE (@TargetEntity IS NULL OR P.TargetEntity = @TargetEntity) AND (@Name IS NULL OR P.Name LIKE '%' + @Name + '%') AND (@NameEN IS NULL OR P.NameEN LIKE '%' + @NameEN + '%')
	 ORDER BY [Name] ASC