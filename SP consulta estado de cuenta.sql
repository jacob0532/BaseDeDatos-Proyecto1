CREATE PROCEDURE ConsultaEstadoCuenta @inNumeroCuenta INT
AS
BEGIN
	SET NOCOUNT ON

	SELECT TOP (8) id
		,NumeroCuenta
		,FechaInicio
		,FechaFin
		,SaldoInicial
		,SaldoFinal
	FROM EstadoCuenta
	WHERE NumeroCuenta = @inNumeroCuenta
	ORDER BY FechaInicio ASC

	SET NOCOUNT OFF
END;