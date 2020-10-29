CREATE PROCEDURE EditarBeneficiarios
	@inNumeroCuenta INT
	,@inValorDocIdentidadBeneficiario INT
	,@inParentezcoId INT
	,@inPorcentaje INT
	,@outResultCode INT
AS
BEGIN 
	SET NOCOUNT ON
	SELECT 
		@outResultCode = 0;
	IF NOT EXISTS(SELECT 1 FROM dbo.CuentaAhorro C WHERE C.NumeroCuenta = @inNumeroCuenta )
		BEGIN 
			SET @outResultCode = 50001; --La cuenta no existe
			RETURN 
		END;

	IF NOT EXISTS(SELECT 1 FROM dbo.Parentezco P WHERE P.id = @inParentezcoId)
		BEGIN 
			SET @outResultCode = 50002; --El id parentezco no existe
			RETURN 
		END;

	IF NOT EXISTS(SELECT 1 FROM dbo.Cliente CL WHERE CL.ValorDocIdentidad = @inParentezcoId)
		BEGIN
			SET @outResultCode = 50004; --El tipo de documento de identidad 
			RETURN
		END;

	ELSE 
		BEGIN
			UPDATE [dbo].[Beneficiarios]
				SET [NumeroCuenta] = @inNumeroCuenta
					,[ValorDocumentoIdentidadBeneficiario] = @inValorDocIdentidadBeneficiario
					,[ParentezcoId] = @inParentezcoId
					,[Porcentaje] = @inPorcentaje
		END;
	SET NOCOUNT OFF
END;
GO;
		