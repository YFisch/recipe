create or alter procedure dbo.MeasurementUpdate(
		@MeasurementId int  output,
		@UnitOfMeasure varchar (100),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @MeasurementId = isnull(@MeasurementId,0)
	
	if @MeasurementId = 0
	begin
		insert Measurement(UnitOfMeasure)
		values(@UnitOfMeasure)

		select @MeasurementId= scope_identity()
	end
	else
	begin
		update Measurement
		set
			UnitOfMeasure = @UnitOfMeasure
		where MeasurementId = @MeasurementId
	end
	
	return @return
end
go