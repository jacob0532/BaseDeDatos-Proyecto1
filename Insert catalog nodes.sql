--CREATE PROCEDURE InsertarNodosCatalogoXML
--AS
--BEGIN

--Se lee el archivo XML
DECLARE @xmlData XML
SET @xmlData = ( 
	SELECT * FROM OPENROWSET(
		BULK 'D:\s3\Datos_Tarea1.xml',SINGLE_BLOB
	) AS xmlData
)

--Inserta el tipo de documento de indentidad de los xml
	INSERT INTO TipoDocIdentidad(ID, NOMBRE)

	SELECT 
		ref.value('@Id', 'int'),
		ref.value('@Nombre', 'VARCHAR(100)')     

	FROM @xmlData.nodes('Datos/Tipo_Doc/TipoDocuIdentidad') 
	xmlData( ref )

	WHERE ref.value('@Id', 'int') not in(select id from TipoDocIdentidad)

--Inserta los tipos de moneda
	INSERT INTO TipoMoneda(
		id, 
		Nombre, 
		Simbolo)

	SELECT
		ref.value('@Id', 'int'),
		ref.value('@Nombre', 'VARCHAR(100)'),
		ref.value('@Simbolo', 'char(10)')

	FROM @xmlData.nodes('Datos/Tipo_Moneda/TipoMoneda')
	xmlData( ref )

	WHERE ref.value('@Id', 'int') not in(select id from TipoMoneda)

--Inserta los datos del parentezco
	INSERT INTO Parentezco(ID, NOMBRE)

	SELECT
		ref.value('@Id', 'int'),
		ref.value('@Nombre', 'VARCHAR(100)') 

	FROM @xmlData.nodes('Datos/Parentezcos/Parentezco')
	xmlData( ref )

	WHERE ref.value('@Id', 'int') not in(select id from Parentezco)
	
--Inserta los datos de tipo de cuenta ahorro
	INSERT INTO TipoCuentaAhorro(
		id,
		Nombre,
		IdTipoMoneda,
		SaldoMinimo,
		MultaSaldoMin, 
		CargoAnual,
		NumRetirosHumano, 
		NumRetirosAutomatico, 
		ComisionHumano, 
		ComisionAutomatico, 
		Interes)

	SELECT
		ref.value('@Id', 'int'),
		ref.value('@Nombre', 'varchar(100)'),
		ref.value('@IdTipoMoneda', 'int'),
		ref.value('@SaldoMinimo', 'money'),
		ref.value('@MultaSaldoMin', 'float'),
		ref.value('@CargoAnual', 'float'),
		ref.value('@NumRetirosHumano', 'int'),
		ref.value('@NumRetirosAutomatico', 'int'),
		ref.value('@ComisionHumano', 'int'),
		ref.value('@ComisionAutomatico', 'int'),
		ref.value('@Interes', 'int')	

	FROM @xmlData.nodes('Datos/Tipo_Cuenta_Ahorros/TipoCuentaAhorro')
	xmlData( ref )
	WHERE ref.value('@Id', 'int') not in(select id from TipoCuentaAhorro)

---------------Datos de no catalogos---------------
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
	WHERE ref.value('@ValorDocumentoIdentidadDelCliente', 'int') not in(select Clienteid from CuentaAhorro)

--Inserta los datos de beneficiarios
	INSERT INTO Beneficiarios (
		NumeroCuenta,
		ValorDocumentoIdentidadBeneficiario, 
		ParentezcoId, 
		Porcentaje)

	SELECT 
		ref.value('@NumeroCuenta', 'int'),
		ref.value('@ValorDocumentoIdentidadBeneficiario','int'),
		ref.value('@ParentezcoId','int'),
		ref.value('@Porcentaje','int')

	FROM @xmlData.nodes('Datos/Beneficiarios/Beneficiario ')
	xmlData( ref )	
	WHERE ref.value('@ValorDocumentoIdentidad', 'int') not in(select ValorDocIdentidad from Cliente)

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
	WHERE ref.value('@NumeroCuenta', 'int') not in(select NumeroCuenta from EstadoCuenta)

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

	--delete TipoDocIdentidad
	--delete TipoMoneda	
	--delete Parentezco
	--delete TipoCuentaAhorro
	--delete Cliente
	--delete CuentaAhorro
	--delete Beneficiarios
	--delete EstadoCuenta
	--delete Usuario
	--delete UsuarioPuedeVer
	

	Select * from TipoDocIdentidad
	Select * from TipoMoneda	
	Select * from Parentezco
	Select * from TipoCuentaAhorro
	Select * from Cliente
	Select * from CuentaAhorro
	Select * from Beneficiarios
	Select * from EstadoCuenta
	Select * from Usuario
	Select * from UsuarioPuedeVer
