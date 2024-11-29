
CREATE DATABASE pruebademo;
GO

USE [pruebademo]
GO

-- Tabla: ventasitems
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventasitems](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [IDVenta] [int] NOT NULL,
    [IDProducto] [int] NOT NULL,
    [PrecioUnitario] [float] NULL,
    [Cantidad] [float] NULL,
    [PrecioTotal] [float] NULL,
PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla: ventas
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [IDCliente] [int] NOT NULL,
    [Fecha] [datetime] NULL,
    [Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Tabla: productos
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[productos](
    [ID] [int] IDENTITY(1,1) NOT NULL,
      NOT NULL,
    [Precio] [float] NULL,
      NULL,
PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- Tabla: clientes
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
    [ID] [int] IDENTITY(1,1) NOT NULL,
      NOT NULL,
      NULL,
      NULL,
PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

-- Relación entre la tabla ventas y clientes
ALTER TABLE [dbo].[ventas]
ADD CONSTRAINT FK_Ventas_Clientes
FOREIGN KEY (IDCliente) REFERENCES [dbo].[clientes](ID)
ON DELETE CASCADE;
GO

-- Relación entre la tabla ventasitems y ventas
ALTER TABLE [dbo].[ventasitems]
ADD CONSTRAINT FK_VentasItems_Ventas
FOREIGN KEY (IDVenta) REFERENCES [dbo].[ventas](ID)
ON DELETE CASCADE;
GO

-- Relación entre la tabla ventasitems y productos
ALTER TABLE [dbo].[ventasitems]
ADD CONSTRAINT FK_VentasItems_Productos
FOREIGN KEY (IDProducto) REFERENCES [dbo].[productos](ID)
ON DELETE CASCADE;
GO
