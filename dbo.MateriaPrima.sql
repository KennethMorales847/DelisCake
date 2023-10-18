CREATE TABLE [dbo].[MateriaPrima] (
    [Id_Ingrediente] INT           NOT NULL DEFAULT 0000,
    [Nombre]      NVARCHAR(50) NOT NULL ,
    [Categoria]    NVARCHAR(25)           NULL ,
    [Fecha_Compra] DATE NOT NULL DEFAULT 01/01/1111, 
    [Fecha_Vencimiento] DATE NOT NULL DEFAULT 01/01/1111, 
	[Proveedor] NCHAR(10) NULL, 
    [Numero_Lote] INT NOT NULL DEFAULT 000, 
    [Unidad_Medida] NVARCHAR(10) NULL , 
    [Cantidad_Inventario] INT NOT NULL DEFAULT 1, 
    [Costo_Unitario] MONEY NOT NULL DEFAULT 00.00, 
    [IVA_Unitario] MONEY NOT NULL DEFAULT 00.00, 
    [Costo_Total] MONEY NOT NULL DEFAULT 00.00, 
    PRIMARY KEY CLUSTERED ([Id_Ingrediente] ASC) 
);

