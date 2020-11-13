USE [ProyectoBD1]
GO
/****** Object:  StoredProcedure [dbo].[EditarBeneficiarios]    Script Date: 11/12/2020 7:18:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Procedimiento que edita los beneficiarios*/
ALTER PROCEDURE [dbo].[EditarBeneficiarios]
	@inNumeroCuenta INT
	,@inValorDocIdentidadBeneficiario INT
	,@inParentezcoId INT
	,@inPorcentaje INT
	,@inAccion VARCHAR(10)

AS
DECLARE @outErrorCode int = 0
BEGIN
	SET NOCOUNT ON
	/*Agrega un nuevo beneficiario*/
	IF @inAccion = 'AGREGAR'
	BEGIN
		IF NOT EXISTS (SELECT NumeroCuenta FROM CuentaAhorro WHERE NumeroCuenta = @inNumeroCuenta)
			SET @outErrorCode = 5001	--El numero de cuenta no existe
	
		IF NOT EXISTS (SELECT ValorDocIdentidad FROM Cliente WHERE ValorDocIdentidad = @inValorDocIdentidadBeneficiario )
			SET @outErrorCode = 5002	--El beneficiario no existe

		IF (SELECT COUNT(*) FROM Beneficiarios where NumeroCuenta = @inNumeroCuenta) > 3
			Set @outErrorCode = 5005	--Posee más de 3 beneficiarios

		IF @inPorcentaje < 0 OR @inPorcentaje > 100
			SET @outErrorCode = 5004	--El porcentaje es mayor o igual 100 o negativo

		IF EXISTS(SELECT ValorDocumentoIdentidadBeneficiario from Beneficiarios where @inValorDocIdentidadBeneficiario = ValorDocumentoIdentidadBeneficiario)
			Set @outErrorCode = 5006	--El Beneficiario ya existe

		ELSE
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
		IF NOT EXISTS (SELECT ValorDocIdentidad FROM Cliente WHERE ValorDocIdentidad = @inValorDocIdentidadBeneficiario )
			SET @outErrorCode = 5002 --El beneficiario no existe

		IF NOT EXISTS(SELECT id FROM Parentezco WHERE id = @inParentezcoId)
			SET @outErrorCode = 5003	--El parentezco no existe

		IF @inPorcentaje < 0 OR @inPorcentaje > 100
			SET @outErrorCode = 5004	--El porcentaje es mayor o igual 100 o negativo

		IF  EXISTS(SELECT ValorDocumentoIdentidadBeneficiario from Beneficiarios where ValorDocumentoIdentidadBeneficiario = @inValorDocIdentidadBeneficiario)
			Set @outErrorCode = 5006	--El Beneficiario ya existe
		ELSE
			UPDATE Beneficiarios
			SET ValorDocumentoIdentidadBeneficiario = @inValorDocIdentidadBeneficiario
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
	RETURN @outErrorCode
END;