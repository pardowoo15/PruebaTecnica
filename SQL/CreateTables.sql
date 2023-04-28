USE Prueba

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMPLEADO]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[EMPLEADO](
        [IdEmpleado] [numeric](18, 0) IDENTITY(1,1) NOT NULL primary key,
        [Nombres] [nvarchar](250) NOT NULL,
        [Apellidos] [nvarchar](250) NOT NULL,
        [Direccion] [nvarchar](250) NOT NULL,
        [Email] [nvarchar](250) NOT NULL,
        [IdGenero] [numeric](18, 0) NOT NULL,
        [IdCiudad] [numeric](18, 0) NOT NULL
    ) ON [PRIMARY]
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VINCULACION]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[VINCULACION](
        [IdVinculacion] [numeric](18, 0) IDENTITY(1,1) NOT NULL primary key,
        [IdEmpleado] [numeric](18, 0) NOT NULL,
        [FechaIngreso] [date] NOT NULL,
        [IdCargo] [numeric](18, 0) NOT NULL,
        [FechaRetiro] [date] NOT NULL,
        [FechaRegistro] [date] NOT NULL,
        CONSTRAINT fk_Vinculacion FOREIGN KEY (IdEmpleado) REFERENCES dbo.EMPLEADO (IdEmpleado),
    ) ON [PRIMARY]
END