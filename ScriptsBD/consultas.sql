
-- CONSULTA A
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