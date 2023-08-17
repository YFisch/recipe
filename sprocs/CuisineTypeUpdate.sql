create or alter procedure dbo.CuisineTypeUpdate(
		@CuisineTypeId int  output,
		@CuisineTypeName varchar (100),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineTypeId = isnull(@CuisineTypeId,0)
	
	if @CuisineTypeId = 0
	begin
		insert CuisineType(CuisinetypeName)
		values(@CuisineTypeName)

		select @CuisineTypeId= scope_identity()
	end
	else
	begin
		update CuisineType
		set
			@CuisineTypeName = @CuisineTypeName
		where CuisineTypeId = @CuisineTypeId
	end
	
	return @return
end
go