CREATE PROCEDURE InsertarXML
AS
BEGIN

	--inserta los datos del tipo de documento de identidad
	INSERT INTO TipoDocIdentidad(ID, NOMBRE)
	SELECT
		MY_XML.Datos.value('@Id', 'int'),
		MY_XML.Datos.value('@Nombre', 'VARCHAR(100)') 
	FROM (SELECT CAST(MY_XML AS xml)
			FROM OPENROWSET(BULK 'C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\catalogos.xml', SINGLE_BLOB) AS T(MY_XML)) AS T(MY_XML)
			CROSS APPLY MY_XML.nodes('Tipo_Doc/TipoDocuIdentidad') AS MY_XML (Datos);

	--inserta los datos del tipo de moneda
	INSERT INTO TipoMoneda(ID, NOMBRE, SIMBOLO)
	SELECT
		MY_XML.Datos.value('@Id', 'int'),
		MY_XML.Datos.value('@Nombre', 'VARCHAR(50)'), 
		MY_XML.Datos.value('@Simbolo', 'VARCHAR(10)')
	FROM (SELECT CAST(MY_XML AS xml)
			FROM OPENROWSET(BULK 'C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\catalogos.xml', SINGLE_BLOB) AS T(MY_XML)) AS T(MY_XML)
			CROSS APPLY MY_XML.nodes('Tipo_Moneda/TipoMoneda') AS MY_XML (Datos);

	--inserta los datos del parentezco
		INSERT INTO Parentezco(ID, NOMBRE)
		SELECT
		   MY_XML.Datos.value('@Id', 'int'),
		   MY_XML.Datos.value('@Nombre', 'VARCHAR(100)') 
		FROM (SELECT CAST(MY_XML AS xml)
			  FROM OPENROWSET(BULK 'C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\catalogos.xml', SINGLE_BLOB) AS T(MY_XML)) AS T(MY_XML)
			  CROSS APPLY MY_XML.nodes('Parentezcos/Parentezco') AS MY_XML (Datos);	

	--inserta los datos de tipo de cuenta ahorro
		INSERT INTO TIPOCUENTAAHORRO(
			ID, 
			NOMBRE, 
			MONEDA, 
			MULTAINCUMPLIMIENTOSALDOMINIMO, 
			SALDOMINIMO, 
			CARGOPORSERVICIOS, 
			MAXOPERACIONESCH, 
			MAXOPERACIONESCA, 
			COMISIONCH, 
			COMISIONCA, 
			TASAINTERESANUAL)

		SELECT
		   MY_XML.Datos.value('@Id', 'int'),
		   MY_XML.Datos.value('@Nombre', 'VARCHAR(100)'),
		   MY_XML.Datos.value('@IdTipoMoneda', 'int'),
		   MY_XML.Datos.value('@MultaSaldoMin', 'float'),
		   MY_XML.Datos.value('@SaldoMinimo', 'float'),
		   MY_XML.Datos.value('@CargoAnual', 'int'),
		   MY_XML.Datos.value('@NumRetirosHumano', 'int'),
		   MY_XML.Datos.value('@NumRetirosAutomatico', 'int'),
		   MY_XML.Datos.value('@comisionHumano', 'int'),
		   MY_XML.Datos.value('@comisionAutomatico', 'int'),
		   MY_XML.Datos.value('@interes', 'int')

		FROM (SELECT CAST(MY_XML AS xml)
			  FROM OPENROWSET(BULK 'C:\Users\dvarg\Desktop\TEC\2020\Segundo Semestre\Bases de datos\Proyectos\Proyecto 1\BaseDeDatos-Proyecto1\catalogos.xml', SINGLE_BLOB) AS T(MY_XML)) AS T(MY_XML)
			  CROSS APPLY MY_XML.nodes('Tipo_Cuenta_Ahorros/TipoCuentaAhorro') AS MY_XML (Datos);	

END;