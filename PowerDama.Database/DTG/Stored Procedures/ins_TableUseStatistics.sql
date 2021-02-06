CREATE proc [DTG].[ins_TableUseStatistics] (@dbname varchar(50))
as
--  exec BOACatalog.DTG.ins_TableUseStatistics @dbname='AnaliticData'
declare @stmt varchar(max)='
USE '+@dbname + '
BEGIN TRY
BEGIN TRAN
DELETE FROM BOACATALOG.DTG.TableUseStatistics WHERE DatabaseName='''+@dbname+'''

declare @restart datetime=(select sqlserver_start_time from sys.dm_os_sys_info)

	INSERT INTO BOACATALOG.DTG.TableUseStatistics
	(DatabaseName,TableName,[RowCount],CreateDate,LastUserUpdateDate,
	ElapsedDayForLastUpdate,ElapsedDayForLastSQLRestart,SystemDate)
	SELECT 
	distinct db_Name() as DatabaseName,
	SCHEMA_NAME(t.schema_id) +''.''+ t.[name] AS TableName,
	s.row_count AS [RowCount],
	t.create_date AS CreateDate,
	u.last_user_update as LastUserUpdateDate,
	DATEDIFF(day, u.last_user_update, GETDATE()) AS ElapsedDayForLastUpdate,
	DATEDIFF(day, @restart,getdate()) AS ElapsedDayForLastSQLRestart,
	Getdate() as SystemDate
	
	FROM sys.tables AS t WITH (NOLOCK)
	INNER JOIN sys.dm_db_partition_stats AS s WITH (NOLOCK)
	ON t.object_id = s.object_id
	AND t.type_desc = ''USER_TABLE''
	LEFT JOIN sys.dm_db_index_usage_stats AS u WITH (NOLOCK)
    ON t.object_id = u.object_id
	AND u.database_id = db_id()

 
END TRY
BEGIN CATCH
    SELECT 
        ERROR_NUMBER() AS ErrorNumber
        ,ERROR_SEVERITY() AS ErrorSeverity
        ,ERROR_STATE() AS ErrorState
        ,ERROR_PROCEDURE() AS ErrorProcedure
        ,ERROR_LINE() AS ErrorLine
        ,ERROR_MESSAGE() AS ErrorMessage;

    IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
END CATCH;

IF @@TRANCOUNT > 0
    COMMIT TRANSACTION
GO'


exec (@stmt)