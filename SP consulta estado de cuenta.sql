CREATE PROCEDURE ConsultaEstadoCuenta
	@inNumeroCuenta INT
AS
BEGIN 
	SET NOCOUNT ON
	SELECT * FROM EstadoCuenta WHERE NumeroCuenta = @inNumeroCuenta
	SET NOCOUNT OFF
END;
		