/*
	Francia Minaya Jhon - 30/06/2020 11:16
	Versión 1.0 - Sistema para venta de SOAT
	Inicio de construcción de tablas

	//Motor de base de datos 2019
	https://www.microsoft.com/es-es/sql-server/sql-server-downloads

	//Interfaz gestionar SQL Server 2019
	https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15

*/
CREATE DATABASE SOAT
GO

USE SOAT
GO

/*
	PRIMARY KEY			: Clave primaria
	UNIQUE				: Único (impedir duplicidad)
*/

CREATE TABLE DEPARTAMENTOS
(	
	IdDepartamento		CHAR(12) NOT NULL,
	Departamento		NVARCHAR(100) NOT NULL,
	CapitalDepartamento	NVARCHAR(100) NOT NULL,
	CONSTRAINT pk_iddepartamento PRIMARY KEY CLUSTERED(IdDepartamento),
	CONSTRAINT uk_departamento_depa UNIQUE (Departamento),
	CONSTRAINT uk_capitaldepar_depa UNIQUE (CapitalDepartamento)
)
GO

CREATE TABLE PROVINCIAS
(	
	IdProvincia			CHAR(12) NOT NULL,
	Provincia			NVARCHAR(100) NOT NULL,
	CapitalProvincia	NVARCHAR(100) NOT NULL,
	IdDepartamento		CHAR(12) NOT NULL,
	CONSTRAINT pk_idprovincia PRIMARY KEY CLUSTERED(IdProvincia),
	CONSTRAINT fk_iddepartamento_prov FOREIGN KEY (IdDepartamento) REFERENCES DEPARTAMENTOS(IdDepartamento),
	CONSTRAINT uk_provincia_prov UNIQUE (Provincia),
	CONSTRAINT uk_capitalprov_prov UNIQUE (CapitalProvincia)
)
GO 

CREATE TABLE DISTRITOS
(	
	IdDistrito			CHAR(12) NOT NULL,
	Distrito			NVARCHAR(100) NOT NULL,
	IdProvincia			CHAR(12) NOT NULL,
	CONSTRAINT pk_iddistrito PRIMARY KEY CLUSTERED(IdDistrito),
	CONSTRAINT fk_iddistrito_dist FOREIGN KEY (IdProvincia) REFERENCES PROVINCIAS(IdProvincia),
	CONSTRAINT uk_distrito_dist UNIQUE (IdProvincia,Distrito)
)
GO 


CREATE TABLE PERSONAS
(
	idpersona		SMALLINT IDENTITY (1,1),
	apellidos		VARCHAR(40)	NOT NULL,
	nombres			VARCHAR(40) NOT NULL,
	dni				CHAR(8)		NOT NULL, -- Siempre tiene 8 dígitos / CHAR = Character (caracteres: 0-9, a-z, A-Z, "#%&@)
	direccion		VARCHAR(100)NOT NULL,
	telefono		CHAR(9)		NOT NULL,
	iddistrito		CHAR(12)	NOT NULL,
	CONSTRAINT pk_idpersona_per PRIMARY KEY (idpersona),
	CONSTRAINT uk_dni_per UNIQUE (dni),
	CONSTRAINT ck_dni_per CHECK (dni LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT ck_telefono_per CHECK (telefono LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT fk_iddistrito_per FOREIGN KEY (iddistrito) REFERENCES DISTRITOS (iddistrito)
)
GO

CREATE TABLE EMPRESAS
(
	idempresa		SMALLINT IDENTITY (1,1),
	razonsocial		VARCHAR(150)	NOT NULL,
	ruc				CHAR(11)		NOT NULL,
	direccion		VARCHAR(100)	NOT NULL,
	telefono		CHAR(9)			NOT NULL,
	iddistrito		CHAR(12)		NOT NULL,
	CONSTRAINT pk_idempresa_emp PRIMARY KEY (idempresa),
	CONSTRAINT uk_ruc_emp UNIQUE (ruc),
	CONSTRAINT ck_telefono_emp CHECK (telefono LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT fk_iddistrito_emp FOREIGN KEY (iddistrito) REFERENCES DISTRITOS (iddistrito)
)
GO

/*
Jueves 02 de julio 2020
Continuación de creación BD SOAT
Tablas: marcas, vehículos, SOAT
*/

CREATE TABLE MARCAS
(
	idmarca			SMALLINT IDENTITY (1,1),
	marca			VARCHAR(50)	NOT NULL,
	CONSTRAINT pk_idmarca_mar PRIMARY KEY (idmarca),
	CONSTRAINT uk_marca_mar UNIQUE (marca)
)
GO

INSERT INTO MARCAS (marca) VALUES ('Toyota')
INSERT INTO MARCAS (marca) VALUES ('Nissan')
INSERT INTO MARCAS (marca) VALUES ('KIA')
INSERT INTO MARCAS (marca) VALUES ('Volvo')
GO


CREATE TABLE VEHICULOS
(
	idvehiculo			INT IDENTITY (1,1),
	placa				CHAR(7)		NOT NULL,
	afabricacion		CHAR(4)		NOT NULL, -- 4 Dígitos: 2005
	numero				TINYINT		NOT NULL, -- 0 a 255 (entero)
	uso					VARCHAR(30) NOT NULL, -- Particular, Laboral, Industrial, Taxi
	categoria			VARCHAR(100)NOT NULL, -- https://comparamejor.com/co/ayuda/clasificacion-de-automoviles/
	idmarca				SMALLINT	NOT NULL,
	modelo				VARCHAR(100)NOT NULL,
	numserie			VARCHAR(40) NOT NULL,
	color				VARCHAR(40) NOT NULL,
	estado				CHAR(1)		NOT NULL,
	CONSTRAINT pk_idvehiculo_veh PRIMARY KEY (idvehiculo),
	CONSTRAINT ck_placa_veh CHECK (placa LIKE '[0-9,A-Z][0-9,A-Z][0-9,A-Z][-][0-9,A-Z][0-9,A-Z][0-9,A-Z]'),
	CONSTRAINT ck_afabricacion_veh CHECK (afabricacion LIKE '[1-2][0-9][0-9][0-9]'),
	CONSTRAINT ck_uso_veh CHECK (uso IN ('Particular','Laboral','Industrial','Taxi')),
	CONSTRAINT ck_categoria_veh CHECK (categoria IN ('Vehículos familiares','Motos','Camionetas','Buses')),
	CONSTRAINT fk_idmarca_veh FOREIGN KEY (idmarca) REFERENCES MARCAS (idmarca)
)
GO

-- TABLA PRINCIPAL 
-- Representan procesos: Compras, Ventas, Alquiler, Préstamos, Reservaciones, Devoluciones, etc.

CREATE TABLE SOAT
(
	idsoat			INT IDENTITY (1,1),
	serie			CHAR(2)		NOT NULL, -- Valores numéricos
	numero			CHAR(8)		NOT NULL, -- Valores numéricos
	informacion		CHAR(15)	NOT NULL,
	fechainiciosoat	DATE		NOT NULL,
	fechafinsoat	DATE		NOT NULL,
	fechainiciopoli	DATE		NOT NULL,
	fechafinpoli	DATE		NOT NULL,
	idempresa		SMALLINT	NULL,
	idpersona		SMALLINT	NULL,
	idvehiculo		INT			NOT NULL,
	fechatrasaccion	DATE		NOT NULL, -- No se solicita, se calcula GETDATE()
	hora			TIME		NOT NULL, -- No se solicita, se calcula GETDATE()
	monto			DECIMAL(5,2)NOT NULL, -- Más caro: 500 (motocicleta), 120 (automóvil) => 999.99
	CONSTRAINT pk_idsoat_sot PRIMARY KEY (idsoat),
	CONSTRAINT ck_serie_sot CHECK (serie LIKE '[0-9][0-9]'),
	CONSTRAINT ck_numero_sot CHECK (numero LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	CONSTRAINT ck_fechainiciosoat_sot CHECK (fechainiciosoat >= GETDATE()),
	CONSTRAINT ck_fechafinsoat_sot CHECK (fechafinsoat > fechainiciosoat),
	CONSTRAINT ck_fechainiciopoli_sot CHECK (fechainiciopoli >= GETDATE()),
	CONSTRAINT ck_fechafinpoli_sot CHECK (fechafinpoli > fechainiciopoli),
	CONSTRAINT fk_idempresa_sot FOREIGN KEY (idempresa) REFERENCES EMPRESAS (idempresa),
	CONSTRAINT fk_idpersona_sot FOREIGN KEY (idpersona) REFERENCES PERSONAS (idpersona),
	CONSTRAINT fk_idvehiculo_sot FOREIGN KEY (idvehiculo) REFERENCES VEHICULOS (idvehiculo),
	CONSTRAINT ck_monto_sot CHECK (monto >= 0)
)
GO

-- Fecha y hora actual
SELECT GETDATE()
GO


/* JUEVES 09 DE JULIO 2020 */
/* AÑADIR CAMPO ESTADO A VEHICULOS CHAR(1) */
/*
ALTER TABLE VEHICULOS ADD estado CHAR(1)
UPDATE VEHICULOS SET estado = '1'
SELECT * FROM VEHICULOS
GO
*/

/* Jueves 16 julio 2020  */
/* ACTUALIZANDO TABLAS */
-- Desvinculando de las tablas dependientes
/*
ALTER TABLE PERSONAS DROP CONSTRAINT fk_iddistrito_per
ALTER TABLE EMPRESAS DROP CONSTRAINT fk_iddistrito_emp
GO

DROP TABLE DISTRITOS
DROP TABLE PROVINCIAS
DROP TABLE DEPARTAMENTOS
GO
*/

-- NOTA: Ahora ejecute el código para la creación de las nuevas tablas: D/P/D (inicio del script)

/* ACTUALIZANDO FORÁNEAS PARA LAS TABLAS PERSONAS Y EMPRESAS */
/*
ALTER TABLE PERSONAS ALTER COLUMN iddistrito CHAR(12) NOT NULL
ALTER TABLE EMPRESAS ALTER COLUMN iddistrito CHAR(12) NOT NULL
GO

ALTER TABLE PERSONAS ADD CONSTRAINT fk_iddistrito_per FOREIGN KEY (iddistrito) REFERENCES DISTRITOS (iddistrito)
ALTER TABLE EMPRESAS ADD CONSTRAINT fk_iddistrito_emp FOREIGN KEY (iddistrito) REFERENCES DISTRITOS (iddistrito)
GO
*/