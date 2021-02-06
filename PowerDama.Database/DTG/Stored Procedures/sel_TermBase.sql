CREATE PROC [DTG].[sel_TermBase]
AS
BEGIN
    SELECT CAST([TermId] AS INT) AS                                    [TermId]
	    , [BaseTermId]
	    , [BOACatalog].[dbo].[fn_RoorRecursiveTermId] ( [TermId] ) AS [RootBaseTermId]
	    , [Name]
	    , [NameEN]
	    , [Description]
	    , [DescriptionEN]
	    , [Type]
	    , [Sensitivity]
	    , [Accessibility]
	    , [Integrity]
	    , [SystemDate]
	    , [UpdateSystemDate]
	    , [IsPrivateData]
    FROM [boacatalog].[dtg].[term]
    ORDER BY CAST([TermId] AS INT)
END