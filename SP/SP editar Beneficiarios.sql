/*Procedimiento que edita los beneficiarios*/
ALTER PROCEDURE EditarBeneficiarios @inNumeroCuenta INT
	,@inValorDocIdentidadBeneficiario INT
	,@inParentezcoId INT
	,@inPorcentaje INT
	,@inAccion VARCHAR(10)
AS
BEGIN
	SET NOCOUNT ON

	/*Validaciones*/
	IF @inNumeroCuenta IN (
			SELECT 1
			FROM CuentaAhorro
			WHERE NumeroCuenta = @inNumeroCuenta
			)
		RETURN 5001	--El numero de cuenta no existe

	IF @inValorDocIdentidadBeneficiario IN (
			SELECT 1
			FROM Cliente
			WHERE ValorDocIdentidad = @inValorDocIdentidadBeneficiario
			)
		RETURN 5002 --el beneficiario no existe

	IF @inParentezcoId NOT IN (
			SELECT 1
			FROM Parentezco
			WHERE id = @inParentezcoId
			)
		RETURN 5002	--El parentezco no existe

	IF @inPorcentaje < 0
		OR @inPorcentaje > 100
		RETURN 5003	--El porcentaje es mayor a cien o negativo

	/*Agrega un nuevo beneficiario*/
	IF @inAccion = 'AGREGAR'
	BEGIN
		INSERT INTO Beneficiarios (
			NumeroCuenta
			,ValorDocumentoIdentidadBeneficiario
			,ParentezcoId
			,Porcentaje
			)
		VALUES (
			@inNumeroCuenta
			,@inValorDocIdentidadBeneficiario
			,@inParentezcoId
			,@inPorcentaje
			)
	END

	/*Editar beneficiario*/
	IF @inAccion = 'EDITAR'
	BEGIN
		UPDATE Beneficiarios
		SET NumeroCuenta = @inNumeroCuenta
			,ValorDocumentoIdentidadBeneficiario = @inValorDocIdentidadBeneficiario
			,ParentezcoId = @inParentezcoId
			,Porcentaje = @inPorcentaje
		WHERE NumeroCuenta = @inNumeroCuenta
	END

	/*Eliminar beneficiario*/
	IF @inAccion = 'ELIMINAR'
		BEGIN
			UPDATE Beneficiarios
			SET Activo = 0
				,FechaDesactivacion = GETDATE()
			WHERE NumeroCuenta = @inNumeroCuenta
		END
	SET NOCOUNT OFF
END;