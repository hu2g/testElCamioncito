-- CREATE
CREATE OR ALTER PROCEDURE ADDVEHICULO(
	@CAPA DECIMAL (12,4),
	@CONS DECIMAL (12,4),
	@DEPR DECIMAL (12,4)
) AS
BEGIN
	INSERT INTO VEHICULO(capacidad, consumo, depreciacion, TipoCarga_id_tipocarga, Sucursal_id_sucursal)
	VALUES (@CAPA, @CONS, @DEPR,1,1);
END;
EXECUTE ADDVEHICULO 11.77,12.77,15.77;

-- READ
CREATE OR ALTER PROCEDURE GETVEHICULOS 
AS
BEGIN
	SELECT id_vehiculo, capacidad, consumo, depreciacion FROM VEHICULO;
END;
EXECUTE GETVEHICULOS;

-- UPDATE
CREATE OR ALTER PROCEDURE UPDATEVEHICULO(
	@ID INTEGER,
	@CAPA DECIMAL (12,4),
	@CONS DECIMAL (12,4),
	@DEPR DECIMAL (12,4)
) AS
BEGIN
	UPDATE VEHICULO
	SET capacidad = @CAPA, consumo=@CONS, depreciacion = @DEPR
	WHERE id_vehiculo = @ID; 
END;
EXECUTE UPDATEVEHICULO 1,11.999,12.999,15.9;



-- DELETE
CREATE OR ALTER PROCEDURE DELETEVEHICULO(
	@ID INTEGER
) AS
BEGIN
	DELETE FROM VEHICULO
	WHERE id_vehiculo = @ID; 
END;
EXECUTE DELETEVEHICULO 2;






-- Obtener el listado de clientes que han utilizado los servicios de transporte al menos en una ocasión 
-- en los departamentos de El Progreso y Zacapa, pero que no han transportado productos refrigerados. 
-- Los datos que debe visualizar Nit, Nombre y datos de contacto.
SELECT C.nombre, C.nit, C.telefono, C.direccion 
FROM Cliente C, Alquiler A, Sucursal S, Departamento D, Vehiculo V, TipoCarga TC, DetalleAlquiler DA
WHERE TC.descripcion = 'refrigerado'
AND TC.id_tipocarga = V.TipoCarga_id_tipocarga
AND DA.Vehiculo_id_vehiculo = V.id_vehiculo
AND DA.Alquiler_id_alquiler = A.id_alquiler
AND A.Sucursal_id_sucursal = S.id_sucursal
AND S.Departamento_id_departamento = D.id_departamento
AND (D.nombre = 'El Progreso' OR D.nombre = 'Zacapa');
