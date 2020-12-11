CREATE PROCEDURE CreateModelByProcedure  
(  
     @Procedure SYSNAME ,  
     @Classe VARCHAR(500),
	 @Result VARCHAR(MAX) OUT
)  
AS  
BEGIN  
    DECLARE @SQL VARCHAR(255)
	
	DECLARE @TABELA TABLE (

	is_hidden BIT, 
	column_ordinal INT, 
	name VARCHAR(255), 
	is_nullable BIT, 
	system_type_id INT, 
	system_type_name VARCHAR(255), 
	max_length INT, 
	precision INT, 
	scale INT, 
	collation_name VARCHAR(255), 
	user_type_id BIGINT, 
	user_type_database VARCHAR(255), 
	user_type_schema VARCHAR(255), 
	user_type_name VARCHAR(255), 
	assembly_qualified_type_name VARCHAR(255), 
	xml_collection_id BIGINT, 
	xml_collection_database VARCHAR(255), 
	xml_collection_schema VARCHAR(255), 
	xml_collection_name VARCHAR(255), 
	is_xml_document BIT, 
	is_case_sensitive BIT, 
	is_fixed_length_clr_type BIT, 
	source_server VARCHAR(255), 
	source_database VARCHAR(255), 
	source_schema VARCHAR(255), 
	source_table VARCHAR(255), 
	source_column VARCHAR(255), 
	is_identity_column BIT, 
	is_part_of_unique_key BIT, 
	is_updateable BIT, 
	is_computed_column BIT, 
	is_sparse_column_set BIT, 
	ordinal_in_order_by_list BIT, 
	order_by_is_descending BIT, 
	order_by_list_length BIT, 
	tds_type_id BIGINT, 
	tds_length BIGINT, 
	tds_collation_id BIGINT, 
	tds_collation_sort_id BIGINT

)

	SET @SQL = 'EXEC sp_describe_first_result_set N'
	SET @SQL = @SQL + '''' + @Procedure + ''''

	INSERT	INTO @TABELA
	EXEC(@SQL)
  
    SET @Result = 'public class ' + @Classe + '  
	{'  
  
	SELECT @Result = @Result + '  
		public ' + ColumnType + NullableSign + ' ' + ColumnName + ' { get; set; }'  
	FROM  
	(  
		SELECT   
			REPLACE(T.name, ' ', '_') ColumnName,  
			ROW_NUMBER() OVER (ORDER BY T.column_ordinal ) ColumnId,  
			CASE TY.name
				WHEN 'bigint' THEN 'long'  
				WHEN 'binary' THEN 'byte[]'  
				WHEN 'bit' THEN 'bool'  
				WHEN 'char' THEN 'string'  
				WHEN 'date' THEN 'DateTime'  
				WHEN 'datetime' THEN 'DateTime'  
				WHEN 'datetime2' then 'DateTime'  
				WHEN 'datetimeoffset' THEN 'DateTimeOffset'  
				WHEN 'decimal' THEN 'decimal'  
				WHEN 'float' THEN 'float'  
				WHEN 'image' THEN 'byte[]'  
				WHEN 'int' THEN 'int'  
				WHEN 'money' THEN 'decimal'  
				WHEN 'nchar' THEN 'char'  
				WHEN 'ntext' THEN 'string'  
				WHEN 'numeric' THEN 'decimal'  
				WHEN 'nvarchar' THEN 'string'  
				WHEN 'real' THEN 'double'  
				WHEN 'smalldatetime' THEN 'DateTime'  
				WHEN 'smallint' THEN 'short'  
				WHEN 'smallmoney' THEN 'decimal'  
				WHEN 'text' THEN 'string'  
				WHEN 'time' THEN 'TimeSpan'  
				WHEN 'timestamp' THEN 'DateTime'  
				WHEN 'tinyint' THEN 'byte'  
				WHEN 'uniqueidentifier' THEN 'Guid'  
				WHEN 'varbinary' THEN 'byte[]'  
				WHEN 'varchar' THEN 'string'  
				ELSE 'UNKNOWN_' + ty.NAME  
			END ColumnType,  
			CASE   
				WHEN T.is_nullable = 1 and ty.NAME in ('bigint', 'bit', 'date', 'datetime', 'datetime2', 'datetimeoffset', 'decimal', 'float', 'int', 'money', 'numeric', 'real', 'smalldatetime', 'smallint', 'smallmoney', 'time', 'tinyint', 'uniqueidentifier')   
				THEN '?'   
				ELSE ''   
			END NullableSign  
		FROM @TABELA T INNER JOIN SYS.types TY ON T.system_type_id = TY.system_type_id
	) t  
	ORDER BY ColumnId  
	SET @Result = @Result  + '  
	}'  
  
	PRINT @Result  
  
END