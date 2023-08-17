create or alter procedure dbo.MeasurementDelete(
	@MeasurementId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @MeasurementId = isnull(@MeasurementId,0)

	delete ri
	from Measurement m
	join RecipeIngredients ri
	on m.MeasurementId = ri.MeasurementId
	where m.MeasurementId = @MeasurementId

	delete m
	from Measurement m
	where m.MeasurementId = @MeasurementId
	
	return @return
end
go