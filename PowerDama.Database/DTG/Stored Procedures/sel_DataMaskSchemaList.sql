-- =============================================
-- Author:		Abdullah Sinan Direk (tpsinan)
-- Create date: 26.12.2016
-- Description:	Table-Column Masking Details
-- =============================================
CREATE PROCEDURE [DTG].[sel_DataMaskSchemaList]
	@DatabaseName VARCHAR(40) = NULL
AS
SET NOCOUNT ON
BEGIN
	SELECT 
		DISTINCT DM.SchemaName, DM.DatabaseName
	FROM DTG.TableColumnDataMaskDetail DM WITH(NOLOCK)
	WHERE
		(@DatabaseName IS NULL OR DM.DatabaseName = @DatabaseName)
	ORDER BY DM.DatabaseName, DM.SchemaName
END