-- Generado por Oracle SQL Developer Data Modeler 21.2.0.183.1957
--   en:        2021-10-11 12:33:35 CST
--   sitio:      SQL Server 2012
--   tipo:      SQL Server 2012



CREATE TABLE Alquiler 
    (
     id_alquiler INTEGER NOT NULL IDENTITY(1,1) , 
     fecha DATETIME NOT NULL , 
     direccionCarga VARCHAR (200) NOT NULL , 
     direccionEntrega VARCHAR (200) NOT NULL , 
     Sucursal_id_sucursal INTEGER NOT NULL , 
     Cliente_id_cliente INTEGER NOT NULL 
    )
GO

ALTER TABLE Alquiler ADD CONSTRAINT Alquiler_PK PRIMARY KEY CLUSTERED (id_alquiler)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Cliente 
    (
     id_cliente INTEGER NOT NULL IDENTITY(1,1) , 
     nombre VARCHAR (30) NOT NULL , 
     telefono VARCHAR (30) NOT NULL , 
     nit VARCHAR (30) NOT NULL , 
     direccion VARCHAR (30) NOT NULL 
    )
GO

ALTER TABLE Cliente ADD CONSTRAINT Cliente_PK PRIMARY KEY CLUSTERED (id_cliente)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Departamento 
    (
     id_departamento INTEGER NOT NULL IDENTITY(1,1) , 
     nombre VARCHAR (100) NOT NULL 
    )
GO

ALTER TABLE Departamento ADD CONSTRAINT Departamento_PK PRIMARY KEY CLUSTERED (id_departamento)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE DetalleAlquiler 
    (
     peso DECIMAL (12,4) , 
     Vehiculo_id_vehiculo INTEGER NOT NULL , 
     Empleado_id_empleado INTEGER NOT NULL , 
     Alquiler_id_alquiler INTEGER NOT NULL 
    )
GO

CREATE TABLE Empleado 
    (
     id_empleado INTEGER NOT NULL IDENTITY(1,1) , 
     nombre VARCHAR (100) NOT NULL , 
     telefono VARCHAR (20) NOT NULL , 
     estado BIT NOT NULL , 
     direccion VARCHAR (30) NOT NULL , 
     TipoEmpleado_id_tipoempleado INTEGER NOT NULL 
    )
GO

ALTER TABLE Empleado ADD CONSTRAINT Empleado_PK PRIMARY KEY CLUSTERED (id_empleado)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Sucursal 
    (
     id_sucursal INTEGER NOT NULL IDENTITY(1,1) , 
     nombre VARCHAR (100) NOT NULL , 
     direccion VARCHAR (100) NOT NULL , 
     Departamento_id_departamento INTEGER NOT NULL 
    )
GO

ALTER TABLE Sucursal ADD CONSTRAINT Sucursal_PK PRIMARY KEY CLUSTERED (id_sucursal)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE TipoCarga 
    (
     id_tipocarga INTEGER NOT NULL IDENTITY(1,1) , 
     descripcion VARCHAR (100) NOT NULL 
    )
GO

ALTER TABLE TipoCarga ADD CONSTRAINT TipoCarga_PK PRIMARY KEY CLUSTERED (id_tipocarga)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE TipoEmpleado 
    (
     id_tipoempleado INTEGER NOT NULL IDENTITY(1,1) , 
     descripcion VARCHAR (100) NOT NULL 
    )
GO

ALTER TABLE TipoEmpleado ADD CONSTRAINT TipoEmpleado_PK PRIMARY KEY CLUSTERED (id_tipoempleado)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

CREATE TABLE Vehiculo 
    (
     id_vehiculo INTEGER NOT NULL IDENTITY(1,1) , 
     capacidad DECIMAL (12,4) NOT NULL , 
     consumo DECIMAL (12,4) NOT NULL , 
     depreciacion DECIMAL (12,4) NOT NULL , 
     TipoCarga_id_tipocarga INTEGER NOT NULL , 
     Sucursal_id_sucursal INTEGER NOT NULL 
    )
GO

ALTER TABLE Vehiculo ADD CONSTRAINT Vehiculo_PK PRIMARY KEY CLUSTERED (id_vehiculo)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
GO

ALTER TABLE Alquiler 
    ADD CONSTRAINT Alquiler_Cliente_FK FOREIGN KEY 
    ( 
     Cliente_id_cliente
    ) 
    REFERENCES Cliente 
    ( 
     id_cliente 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Alquiler 
    ADD CONSTRAINT Alquiler_Sucursal_FK FOREIGN KEY 
    ( 
     Sucursal_id_sucursal
    ) 
    REFERENCES Sucursal 
    ( 
     id_sucursal 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DetalleAlquiler 
    ADD CONSTRAINT DetalleAlquiler_Alquiler_FK FOREIGN KEY 
    ( 
     Alquiler_id_alquiler
    ) 
    REFERENCES Alquiler 
    ( 
     id_alquiler 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DetalleAlquiler 
    ADD CONSTRAINT DetalleAlquiler_Empleado_FK FOREIGN KEY 
    ( 
     Empleado_id_empleado
    ) 
    REFERENCES Empleado 
    ( 
     id_empleado 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE DetalleAlquiler 
    ADD CONSTRAINT DetalleAlquiler_Vehiculo_FK FOREIGN KEY 
    ( 
     Vehiculo_id_vehiculo
    ) 
    REFERENCES Vehiculo 
    ( 
     id_vehiculo 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Empleado 
    ADD CONSTRAINT Empleado_TipoEmpleado_FK FOREIGN KEY 
    ( 
     TipoEmpleado_id_tipoempleado
    ) 
    REFERENCES TipoEmpleado 
    ( 
     id_tipoempleado 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Sucursal 
    ADD CONSTRAINT Sucursal_Departamento_FK FOREIGN KEY 
    ( 
     Departamento_id_departamento
    ) 
    REFERENCES Departamento 
    ( 
     id_departamento 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Vehiculo 
    ADD CONSTRAINT Vehiculo_Sucursal_FK FOREIGN KEY 
    ( 
     Sucursal_id_sucursal
    ) 
    REFERENCES Sucursal 
    ( 
     id_sucursal 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Vehiculo 
    ADD CONSTRAINT Vehiculo_TipoCarga_FK FOREIGN KEY 
    ( 
     TipoCarga_id_tipocarga
    ) 
    REFERENCES TipoCarga 
    ( 
     id_tipocarga 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO



-- Informe de Resumen de Oracle SQL Developer Data Modeler: 
-- 
-- CREATEaa TABLE                             9
-- CREATE INDEX                             0
-- ALTER TABLE                             17
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE DATABASE                          0
-- CREATE DEFAULT                           0
-- CREATE INDEX ON VIEW                     0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE ROLE                              0
-- CREATE RULE                              0
-- CREATE SCHEMA                            0
-- CREATE SEQUENCE                          0
-- CREATE PARTITION FUNCTION                0
-- CREATE PARTITION SCHEME                  0
-- 
-- DROP DATABASE                            0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0
