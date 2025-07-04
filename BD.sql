USE [Prueba]
GO
/****** Object:  Table [dbo].[pelicula]    Script Date: 24/06/2025 1:05:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pelicula](
	[Id_pel] [int] NOT NULL,
	[Titulo_pel] [varchar](300) NULL,
	[Anho_pel] [int] NULL,
	[Genero_pel] [varchar](150) NULL,
 CONSTRAINT [pk_cp] PRIMARY KEY CLUSTERED 
(
	[Id_pel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 24/06/2025 1:05:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[Id_us] [int] IDENTITY(1,1) NOT NULL,
	[Email_us] [varchar](100) NULL,
	[Contraseña_us] [varchar](50) NULL,
 CONSTRAINT [pk_cu] PRIMARY KEY CLUSTERED 
(
	[Id_us] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario_pelicula]    Script Date: 24/06/2025 1:05:09 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario_pelicula](
	[Id_us1] [int] NOT NULL,
	[Id_pel1] [int] NOT NULL,
 CONSTRAINT [pk_cup] PRIMARY KEY CLUSTERED 
(
	[Id_us1] ASC,
	[Id_pel1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[pelicula] ([Id_pel], [Titulo_pel], [Anho_pel], [Genero_pel]) VALUES (1098, N'Harry', 2020, N'Drama')
INSERT [dbo].[pelicula] ([Id_pel], [Titulo_pel], [Anho_pel], [Genero_pel]) VALUES (1212, N'Mundo', 2003, N'Accion')
INSERT [dbo].[pelicula] ([Id_pel], [Titulo_pel], [Anho_pel], [Genero_pel]) VALUES (6543, N'Fin del mundo', 2012, N'Accion')
INSERT [dbo].[pelicula] ([Id_pel], [Titulo_pel], [Anho_pel], [Genero_pel]) VALUES (6754, N'Titanic', 2010, N'Drama')
INSERT [dbo].[pelicula] ([Id_pel], [Titulo_pel], [Anho_pel], [Genero_pel]) VALUES (9076, N'Saturno', 2024, N'Accion')
INSERT [dbo].[pelicula] ([Id_pel], [Titulo_pel], [Anho_pel], [Genero_pel]) VALUES (9870, N'Esta alli', 2023, N'Terror')
INSERT [dbo].[pelicula] ([Id_pel], [Titulo_pel], [Anho_pel], [Genero_pel]) VALUES (9876, N'YOU', 2001, N'Comedia')
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (1002, N'Vaed09@gmail.com', N'*707V*')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (1007, N'Pvsam25@gmail.com', N'2505*')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (1456, N'NesAtal@gmail.com', N'NA123')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (1808, N'Tdiar18@gmail.com', N'0809#')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (2106, N'ValarC@gmail.com', N'Vnm56')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (2897, N'RichVR@gmail.com', N'Suhj100')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (3041, N'JsanA@gmail.com', N'SupJ*')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (5662, N'Pcard10@gmail.com', N'2895#')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (7070, N'OlgaL@gmail.com', N'L8080')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (7700, N'iusL07@gmail.com', N'79797')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (7799, N'BermES@gmail.com', N'****')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (7890, N'valenCap@gmail.com', N'Vc49*')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (8900, N'JeisAr@gmail.co', N'JV7856')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (8905, N'JackB0@gmail.com', N'90*jm')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (9087, N'Beta18@gmail.com', N'2834tb')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (9088, N'valentina@gmail.com', N'clave123')
INSERT [dbo].[usuario] ([Id_us], [Email_us], [Contraseña_us]) VALUES (9089, N'Ach87@gmail.com', N'##876')
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
INSERT [dbo].[usuario_pelicula] ([Id_us1], [Id_pel1]) VALUES (5662, 1098)
INSERT [dbo].[usuario_pelicula] ([Id_us1], [Id_pel1]) VALUES (5662, 1212)
INSERT [dbo].[usuario_pelicula] ([Id_us1], [Id_pel1]) VALUES (5662, 6543)
GO
ALTER TABLE [dbo].[usuario_pelicula]  WITH CHECK ADD  CONSTRAINT [fk_Ec1] FOREIGN KEY([Id_us1])
REFERENCES [dbo].[usuario] ([Id_us])
GO
ALTER TABLE [dbo].[usuario_pelicula] CHECK CONSTRAINT [fk_Ec1]
GO
ALTER TABLE [dbo].[usuario_pelicula]  WITH CHECK ADD  CONSTRAINT [fk_Ec2] FOREIGN KEY([Id_pel1])
REFERENCES [dbo].[pelicula] ([Id_pel])
GO
ALTER TABLE [dbo].[usuario_pelicula] CHECK CONSTRAINT [fk_Ec2]
GO
