CREATE  PROCEDURE InsertarNodosNoCatalogoXML
AS
BEGIN 
	--inserta los clientes del xml
	INSERT INTO Cliente(Nombre, Email, FechaNacimiento, Telefono1, Telefono2, TipoDocIdentidadid, ValorDocumentoIdentidad)
	SELECT
		MY_XML.Datos.value('@Nombre', 'VARCHAR(100)'),
		MY_XML.Datos.value('@Email', 'VARCHAR(100)'),
		MY_XML.Datos.value('@FechaNacimiento', 'date'),
		MY_XML.Datos.value('@telefono1', 'VARCHAR(100)'),
		MY_XML.Datos.value('@telefono2', 'VARCHAR(100)'),
		MY_XML.Datos.value('@TipoDocuIdentidad', 'int'),
		MY_XML.Datos.value('@ValorDocumentoIdentidad', 'int')

	FROM (SELECT CAST(MY_XML AS xml)
			FROM OPENROWSET(BULK 'C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\no-catalogos.xml', SINGLE_BLOB) AS T(MY_XML)) AS T(MY_XML)
			CROSS APPLY MY_XML.nodes('Personas/Persona') AS MY_XML (Datos);

	--ingresa las cuentas de ahorros del xml
	INSERT INTO CuentaAhorro(Saldo, FechaCreacion)
	SELECT 
		MY_XML.Datos.value('@Saldo', 'money'),
		MY_XML.Datos.value('@FechaCreacion', 'date')
	FROM (SELECT CAST(MY_XML AS xml)
			FROM OPENROWSET(BULK 'C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\no-catalogos.xml', SINGLE_BLOB) AS T(MY_XML)) AS T(MY_XML)
			CROSS APPLY MY_XML.nodes('Cuentas/Cuenta') AS MY_XML (Datos);

	--ingresa los beneficiarios del xml
	INSERT INTO Beneficiarios(Porcentaje)
	SELECT 
		MY_XML.Datos.value('@Porcentaje', 'float')
	FROM (SELECT CAST(MY_XML AS xml)
			FROM OPENROWSET(BULK 'C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\no-catalogos.xml', SINGLE_BLOB) AS T(MY_XML)) AS T(MY_XML)
			CROSS APPLY MY_XML.nodes('Beneficiarios/Beneficiario') AS MY_XML (Datos);

	--ingresa los estados de cuenta del xml
	INSERT INTO EstadoCuenta(FechaInicio, FechaFin, SaldoInicial, SaldoFinal, SaldoMinimo)
	SELECT 
		--MY_XML.Datos.value('@NumeroCuenta', 'money'),
		MY_XML.Datos.value('@fechaInicio', 'date'),
		MY_XML.Datos.value('@fechafin', 'date'),
		MY_XML.Datos.value('@saldoinicial', 'money'),
		MY_XML.Datos.value('@saldo_final', 'money'),
		MY_XML.Datos.value('@saldo_final', 'money')

	FROM (SELECT CAST(MY_XML AS xml)
			FROM OPENROWSET(BULK 'C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\no-catalogos.xml', SINGLE_BLOB) AS T(MY_XML)) AS T(MY_XML)
			CROSS APPLY MY_XML.nodes('Estados_de_Cuenta/Estado_de_Cuenta') AS MY_XML (Datos);

	--faltan los usuarios y usuarios ver
END;