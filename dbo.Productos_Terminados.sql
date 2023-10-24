CREATE TABLE [dbo].[Productos_Terminados] (
    [Id_Producto_Terminado] INT             NOT NULL,
    [Nombre]                NVARCHAR (50)   NOT NULL,
    [Precio_Venta]          FLOAT NOT NULL,
    [Cantidad_Total]        INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Producto_Terminado] ASC),
);

