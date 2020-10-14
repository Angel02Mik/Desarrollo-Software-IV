USE SOAT
GO

/* MARTES 07 DE JULIO 2020 */

-- Store Procedure = Procedimiento almacenado | PROGRAMA QUE SE EJECUTA EN SGBD
-- Instrucciones
-- Referencia y acción
-- Conjunto de comandos

-- ¿Ventaja?
-- Encapsular o abstraer la complejidad de ciertas operaciones. SELECT...
-- SPU =  Store Procedure User (Procedimiento almacenado del usuario)

CREATE PROCEDURE SPU_VEHICULOS_REGISTRAR 
	-- Variables IN (defecto), OUT (explícita)
	@placa			CHAR(7),
	@afabricacion	CHAR(4),
	@numero			TINYINT,
	@uso			VARCHAR(30),
	@categoria		VARCHAR(100),
	@idmarca		SMALLINT,
	@modelo			VARCHAR(100),
	@numserie		VARCHAR(40),
	@color			VARCHAR(40)
AS 
BEGIN
	INSERT INTO VEHICULOS (placa, afabricacion, numero, uso, categoria, idmarca, modelo, numserie, color, estado) 
		VALUES (@placa, @afabricacion, @numero, @uso, @categoria, @idmarca, @modelo, @numserie, @color, '1')
END 
GO

EXEC SPU_VEHICULOS_REGISTRAR 'A12-458'
GO

ALTER PROCEDURE SPU_VEHICULOS_LISTAR
AS BEGIN
	SELECT * FROM VEHICULOS WHERE estado = '1'
END 
GO

/* *************** MARCAS ****************** */

CREATE PROCEDURE SPU_MARCAS_LISTAR
AS BEGIN
	SELECT * FROM MARCAS
END
GO

/* JUEVES 09/07/2020 */
CREATE PROCEDURE SPU_VEHICULOS_ELIMINAR
@idvehiculo			INT
AS BEGIN
	UPDATE VEHICULOS SET estado = '0' WHERE idvehiculo = @idvehiculo
END
GO

EXEC SPU_VEHICULOS_ELIMINAR 3
EXEC SPU_VEHICULOS_ELIMINAR 5
EXEC SPU_VEHICULOS_ELIMINAR 6
SELECT * FROM VEHICULOS
UPDATE VEHICULOS SET ESTADO = '1'
GO

/* JUEVES 16 JULIO 2020*/

/* PROCEDIMIENTOS DE UBIGEO (Ubicación en el país) */
CREATE PROCEDURE SPU_DEPARTAMENTOS_LISTAR
AS BEGIN
	SELECT * FROM DEPARTAMENTOS ORDER BY Departamento
END
GO

CREATE PROCEDURE SPU_PROVINCIAS_LISTAR
@IdDepartamento		CHAR(12)
AS BEGIN	
	SELECT * FROM PROVINCIAS WHERE IdDepartamento = @IdDepartamento ORDER BY Provincia
END
GO

CREATE PROCEDURE SPU_DISTRITOS_LISTAR
@IdProvincia		CHAR(12)
AS BEGIN
	SELECT * FROM DISTRITOS WHERE IdProvincia = @IdProvincia ORDER BY Distrito
END
GO

EXEC SPU_DEPARTAMENTOS_LISTAR
EXEC SPU_PROVINCIAS_LISTAR 'DEPART000006'
EXEC SPU_DISTRITOS_LISTAR 'PROVIN000061'
GO