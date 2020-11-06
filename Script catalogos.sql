--Se lee el archivo XML
DECLARE @xmlData XML
SET @xmlData = ( 
	SELECT * FROM OPENROWSET(
		BULK 'D:\s3\Datos.xml',SINGLE_BLOB
	) AS xmlData
)

--Inserta el tipo de documento de indentidad de los xml
	INSERT INTO TipoDocIdentidad(
		ID, 
		NOMBRE)

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