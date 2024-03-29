USE [ProyectoBD1]
GO
/****** Object:  StoredProcedure [dbo].[SP_VerificarPorcentajeBeneficiarios]    Script Date: 11/14/2020 12:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_VerificarPorcentajeBeneficiarios]
(
	@inNumeroCuenta INT
)
AS
DECLARE @outErrorCode INT;
DECLARE @porcentajeBeneficiarios INT = convert(int,(SELECT SUM(Porcentaje) FROM Beneficiarios where NumeroCuenta = @inNumeroCuenta and Activo = 1))
BEGIN
		IF  @porcentajeBeneficiarios < 100 
			SET @outErrorCode = 5007;	--El porcentaje es menor a 100
		ELSE IF @porcentajeBeneficiarios > 100
			SET @outErrorCode = 5008;	--El porcentaje es MAYOR a 100
		ELSE
			SET @outErrorCode = 0;
	RETURN @outErrorCode
END