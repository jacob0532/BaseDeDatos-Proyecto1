-------------Datos de no catalogos---------------
--Se lee el archivo XML
DECLARE @xmlData XML
SET @xmlData = ( 
	SELECT * FROM OPENROWSET(
		BULK 'D:\s3\Datos.xml',SINGLE_BLOB
	) AS xmlData
)

--Inserta los datos de las personas
	INSERT INTO Cliente (	
		Nombre, 
		ValorDocIdentidad, 
		Email, 
		FechaNacimiento,
		Telefono1, 
		Telefono2,
		TipoDocIdentidadid)

	SELECT 
		ref.value('@Nombre', 'varchar(100)'),
		ref.value('@ValorDocumentoIdentidad','int'),
		ref.value('@Email','varchar(100)'),
		ref.value('@FechaNacimiento','date'),
		ref.value('@Telefono1','int'),
		ref.value('@Telefono2','int'),
		ref.value('@TipoDocuIdentidad','int')

	FROM @xmlData.nodes('Datos/Personas/Persona')
	xmlData( ref )
	WHERE ref.value('@ValorDocumentoIdentidad', 'int') not in(select ValorDocIdentidad from Cliente)

--Inserta los datos de las cuentas
	INSERT INTO CuentaAhorro (
		Clienteid, 
		TipoCuentaId, 
		NumeroCuenta, 
		FechaCreacion, 
		Saldo)

	SELECT
		ref.value('@ValorDocumentoIdentidadDelCliente', 'int'),
		ref.value('@TipoCuentaId','int'),
		ref.value('@NumeroCuenta','int'),
		ref.value('@FechaCreacion','date'),
		ref.value('@Saldo','money')
		   
	FROM @xmlData.nodes('Datos/Cuentas/Cuenta')	
	xmlData( ref )
	WHERE ref.value('@NumeroCuenta', 'int') not in(select NumeroCuenta from CuentaAhorro)

--Inserta los datos de beneficiarios
	INSERT INTO Beneficiarios (
		NumeroCuenta, 
		ValorDocumentoIdentidadBeneficiario, 
		ParentezcoId, 
		Porcentaje,
		Activo,
		FechaDesactivacion)

	SELECT 
		ref.value('@NumeroCuenta', 'int'),
		ref.value('@ValorDocumentoIdentidadBeneficiario','int'),
		ref.value('@ParentezcoId','int'),
		ref.value('@Porcentaje','int'),
		1,
		null

	FROM @xmlData.nodes('Datos/Beneficiarios/Beneficiario ')
	xmlData( ref )	

--Inserta los datos de los estados de cuenta
	INSERT INTO EstadoCuenta(
		NumeroCuenta,
		FechaInicio,
		FechaFin, 
		SaldoInicial, 
		SaldoFinal)

	SELECT 
		ref.value('@NumeroCuenta', 'int'),
		ref.value('@fechaInicio','Date'),
		ref.value('@fechaFin','Date'),
		ref.value('@saldoInicial','money'),
		ref.value('@saldoFinal','money')

	FROM @xmlData.nodes('Datos/Estados_de_Cuenta/Estado_de_Cuenta')
	xmlData( ref )
	--WHERE ref.value('@NumeroCuenta', 'int') in(select NumeroCuenta from CuentaAhorro)

--Inserta los datos de usuarios
	INSERT INTO Usuario(	
		[User], 
		Pass, 
		ValorDocIdentidad, 
		EsAdmi)

	SELECT 
		ref.value('@User', 'varchar(50)'),
		ref.value('@Pass','varchar(50)'),
		ref.value('@ValorDocumentoIdentidad','int'),
		ref.value('@EsAdministrador','money')

	FROM @xmlData.nodes('Datos/Usuarios/Usuario')
	xmlData( ref )
	WHERE ref.value('@ValorDocumentoIdentidad', 'int') not in(select ValorDocIdentidad from Usuario)

--Inserta los datos de usuarios puede ver
	INSERT INTO UsuarioPuedeVer(
		[User], 
		NumeroCuenta)

	SELECT 
		ref.value('@User', 'varchar(50)'),
		ref.value('@NumeroCuenta', 'int')

	FROM @xmlData.nodes('Datos/Usuarios_Ver/UsuarioPuedeVer ')
	xmlData( ref )
	WHERE ref.value('@NumeroCuenta', 'int') not in(select NumeroCuenta from UsuarioPuedeVer)
