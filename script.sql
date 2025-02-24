USE [HomelessDogs]
GO
/****** Object:  Table [dbo].[Aviary]    Script Date: 09.02.2025 15:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aviary](
	[Id_aviary] [int] IDENTITY(1,1) NOT NULL,
	[Id_aviary_type] [int] NULL,
 CONSTRAINT [PK_Aviary] PRIMARY KEY CLUSTERED 
(
	[Id_aviary] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AviaryType]    Script Date: 09.02.2025 15:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AviaryType](
	[Id_aviary_type] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_AviaryType] PRIMARY KEY CLUSTERED 
(
	[Id_aviary_type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dog]    Script Date: 09.02.2025 15:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dog](
	[Id_dog] [int] IDENTITY(1,1) NOT NULL,
	[Id_aviary] [int] NULL,
	[Id_gender] [int] NULL,
	[SerialNumber] [nvarchar](max) NULL,
	[Height] [int] NULL,
	[Weight] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[Age] [int] NULL,
	[IsDie] [bit] NULL,
	[IsGive] [bit] NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Photo] [varbinary](max) NULL,
 CONSTRAINT [PK_Dog] PRIMARY KEY CLUSTERED 
(
	[Id_dog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 09.02.2025 15:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id_employee] [int] IDENTITY(1,1) NOT NULL,
	[Id_post] [int] NULL,
	[Surname] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 09.02.2025 15:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Id_gender] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Id_gender] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 09.02.2025 15:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[Id_post] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[Id_post] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 09.02.2025 15:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id_status] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Survey]    Script Date: 09.02.2025 15:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Survey](
	[Id_survey] [int] IDENTITY(1,1) NOT NULL,
	[Id_dog] [int] NULL,
	[Id_doctor] [int] NULL,
	[Id_status] [int] NULL,
	[Illness] [nvarchar](max) NULL,
	[Date] [datetime] NULL,
	[Comment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Survey] PRIMARY KEY CLUSTERED 
(
	[Id_survey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aviary] ON 

INSERT [dbo].[Aviary] ([Id_aviary], [Id_aviary_type]) VALUES (1, 1)
INSERT [dbo].[Aviary] ([Id_aviary], [Id_aviary_type]) VALUES (2, 1)
INSERT [dbo].[Aviary] ([Id_aviary], [Id_aviary_type]) VALUES (3, 2)
INSERT [dbo].[Aviary] ([Id_aviary], [Id_aviary_type]) VALUES (4, 2)
INSERT [dbo].[Aviary] ([Id_aviary], [Id_aviary_type]) VALUES (5, 1)
INSERT [dbo].[Aviary] ([Id_aviary], [Id_aviary_type]) VALUES (6, 1)
INSERT [dbo].[Aviary] ([Id_aviary], [Id_aviary_type]) VALUES (7, 1)
SET IDENTITY_INSERT [dbo].[Aviary] OFF
GO
SET IDENTITY_INSERT [dbo].[AviaryType] ON 

INSERT [dbo].[AviaryType] ([Id_aviary_type], [Name]) VALUES (1, N'Обычный')
INSERT [dbo].[AviaryType] ([Id_aviary_type], [Name]) VALUES (2, N'Для беременных')
SET IDENTITY_INSERT [dbo].[AviaryType] OFF
GO
SET IDENTITY_INSERT [dbo].[Dog] ON 

INSERT [dbo].[Dog] ([Id_dog], [Id_aviary], [Id_gender], [SerialNumber], [Height], [Weight], [Description], [Age], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (1, 1, 1, N'000001', 90, 10, N'Бедная собачка', 3, 0, 0, N'+79356478850', NULL)
INSERT [dbo].[Dog] ([Id_dog], [Id_aviary], [Id_gender], [SerialNumber], [Height], [Weight], [Description], [Age], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (2, 2, 1, N'000002', 88, 8, N'хиханьки да хаханьки', 1, 0, 1, NULL, NULL)
INSERT [dbo].[Dog] ([Id_dog], [Id_aviary], [Id_gender], [SerialNumber], [Height], [Weight], [Description], [Age], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (3, 3, 2, N'000003', 100, 20, N'Беременная мертвая собака', 8, 1, 0, NULL, NULL)
INSERT [dbo].[Dog] ([Id_dog], [Id_aviary], [Id_gender], [SerialNumber], [Height], [Weight], [Description], [Age], [IsDie], [IsGive], [PhoneNumber], [Photo]) VALUES (4, 4, 2, N'000004', 75, 5, N'Просто собака', 5, 0, 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Dog] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id_employee], [Id_post], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (1, 1, N'Иванов', N'Иван', N'Иванович', N'admin', N'adm')
INSERT [dbo].[Employee] ([Id_employee], [Id_post], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (2, 2, N'Петров', N'Петр', N'Петрович', N'petr', N'doc')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([Id_gender], [Name]) VALUES (1, N'Самец')
INSERT [dbo].[Gender] ([Id_gender], [Name]) VALUES (2, N'Самка')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([Id_post], [Name]) VALUES (1, N'Администратор')
INSERT [dbo].[Post] ([Id_post], [Name]) VALUES (2, N'Врач')
SET IDENTITY_INSERT [dbo].[Post] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id_status], [Name]) VALUES (1, N'Первичный')
INSERT [dbo].[Status] ([Id_status], [Name]) VALUES (2, N'Вторичный')
INSERT [dbo].[Status] ([Id_status], [Name]) VALUES (3, N'Завершающий')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
ALTER TABLE [dbo].[Aviary]  WITH CHECK ADD  CONSTRAINT [FK_Aviary_AviaryType] FOREIGN KEY([Id_aviary_type])
REFERENCES [dbo].[AviaryType] ([Id_aviary_type])
GO
ALTER TABLE [dbo].[Aviary] CHECK CONSTRAINT [FK_Aviary_AviaryType]
GO
ALTER TABLE [dbo].[Dog]  WITH CHECK ADD  CONSTRAINT [FK_Dog_Aviary] FOREIGN KEY([Id_aviary])
REFERENCES [dbo].[Aviary] ([Id_aviary])
GO
ALTER TABLE [dbo].[Dog] CHECK CONSTRAINT [FK_Dog_Aviary]
GO
ALTER TABLE [dbo].[Dog]  WITH CHECK ADD  CONSTRAINT [FK_Dog_Gender] FOREIGN KEY([Id_gender])
REFERENCES [dbo].[Gender] ([Id_gender])
GO
ALTER TABLE [dbo].[Dog] CHECK CONSTRAINT [FK_Dog_Gender]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Post] FOREIGN KEY([Id_post])
REFERENCES [dbo].[Post] ([Id_post])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Post]
GO
ALTER TABLE [dbo].[Survey]  WITH CHECK ADD  CONSTRAINT [FK_Survey_Dog] FOREIGN KEY([Id_dog])
REFERENCES [dbo].[Dog] ([Id_dog])
GO
ALTER TABLE [dbo].[Survey] CHECK CONSTRAINT [FK_Survey_Dog]
GO
ALTER TABLE [dbo].[Survey]  WITH CHECK ADD  CONSTRAINT [FK_Survey_Employee] FOREIGN KEY([Id_doctor])
REFERENCES [dbo].[Employee] ([Id_employee])
GO
ALTER TABLE [dbo].[Survey] CHECK CONSTRAINT [FK_Survey_Employee]
GO
ALTER TABLE [dbo].[Survey]  WITH CHECK ADD  CONSTRAINT [FK_Survey_Status] FOREIGN KEY([Id_status])
REFERENCES [dbo].[Status] ([Id_status])
GO
ALTER TABLE [dbo].[Survey] CHECK CONSTRAINT [FK_Survey_Status]
GO
