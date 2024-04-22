USE [cs6232-g1]
GO
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/21/2024 9:33:00 PM ******/
DROP PROCEDURE [dbo].[getMostPopularFurnitureDuringDates]
GO
ALTER TABLE [dbo].[ReturnTransactions] DROP CONSTRAINT [FK_ReturnTransactions_Members]
GO
ALTER TABLE [dbo].[ReturnTransactions] DROP CONSTRAINT [FK_ReturnTransactions_Employees]
GO
ALTER TABLE [dbo].[ReturnLineItems] DROP CONSTRAINT [FK_ReturnLineItems_ReturnTransactions]
GO
ALTER TABLE [dbo].[ReturnLineItems] DROP CONSTRAINT [FK_ReturnLineItems_RentalLineItems]
GO
ALTER TABLE [dbo].[RentalTransactions] DROP CONSTRAINT [FK_RentalTransactions_Members]
GO
ALTER TABLE [dbo].[RentalTransactions] DROP CONSTRAINT [FK_RentalTransactions_Employees]
GO
ALTER TABLE [dbo].[RentalLineItems] DROP CONSTRAINT [FK_RentalLineItems_RentalTransactions]
GO
ALTER TABLE [dbo].[RentalLineItems] DROP CONSTRAINT [FK_RentalLineItems_Furnature]
GO
ALTER TABLE [dbo].[Furniture] DROP CONSTRAINT [FK_Furniture_Styles]
GO
ALTER TABLE [dbo].[Furniture] DROP CONSTRAINT [FK_Furniture_Categories]
GO
/****** Object:  Table [dbo].[Styles]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Styles]') AND type in (N'U'))
DROP TABLE [dbo].[Styles]
GO
/****** Object:  Table [dbo].[ReturnTransactions]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReturnTransactions]') AND type in (N'U'))
DROP TABLE [dbo].[ReturnTransactions]
GO
/****** Object:  Table [dbo].[ReturnLineItems]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ReturnLineItems]') AND type in (N'U'))
DROP TABLE [dbo].[ReturnLineItems]
GO
/****** Object:  Table [dbo].[RentalTransactions]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentalTransactions]') AND type in (N'U'))
DROP TABLE [dbo].[RentalTransactions]
GO
/****** Object:  Table [dbo].[RentalLineItems]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentalLineItems]') AND type in (N'U'))
DROP TABLE [dbo].[RentalLineItems]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Members]') AND type in (N'U'))
DROP TABLE [dbo].[Members]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Furniture]') AND type in (N'U'))
DROP TABLE [dbo].[Furniture]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))
DROP TABLE [dbo].[Employees]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 4/21/2024 9:33:00 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categories]') AND type in (N'U'))
DROP TABLE [dbo].[Categories]
GO
USE [master]
GO
/****** Object:  Database [cs6232-g1]    Script Date: 4/21/2024 9:33:00 PM ******/
DROP DATABASE [cs6232-g1]
GO
/****** Object:  Database [cs6232-g1]    Script Date: 4/21/2024 9:33:00 PM ******/
CREATE DATABASE [cs6232-g1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Rental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Rental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-g1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g1] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cs6232-g1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g1] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g1] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g1', N'ON'
GO
ALTER DATABASE [cs6232-g1] SET QUERY_STORE = OFF
GO
USE [cs6232-g1]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Sex] [char](1) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Phone] [varchar](13) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](13) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](256) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[FurnitureID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[QuantityOwned] [int] NOT NULL,
	[QuantityRented] [int] NOT NULL,
	[DailyRentalRate] [money] NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Style] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Furnature] PRIMARY KEY CLUSTERED 
(
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Sex] [char](1) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Phone] [varchar](13) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](13) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalLineItems]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalLineItems](
	[RentalID] [int] NOT NULL,
	[FurnitureID] [int] NOT NULL,
	[QuantityRented] [int] NOT NULL,
	[QuantityReturned] [int] NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_RentalLineItems] PRIMARY KEY CLUSTERED 
(
	[RentalID] ASC,
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTransactions]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalTransactions](
	[RentalID] [int] IDENTITY(1,1) NOT NULL,
	[DateRented] [datetime] NOT NULL,
	[DateDue] [datetime] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
 CONSTRAINT [PK_RentalTransactions] PRIMARY KEY CLUSTERED 
(
	[RentalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnLineItems]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnLineItems](
	[ReturnID] [int] NOT NULL,
	[RentalID] [int] NOT NULL,
	[FurnitureID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Fine] [money] NOT NULL,
	[Refund] [money] NOT NULL,
 CONSTRAINT [PK_ReturnLineItems] PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC,
	[RentalID] ASC,
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnTransactions]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnTransactions](
	[ReturnID] [int] IDENTITY(1,1) NOT NULL,
	[DateReturned] [datetime] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
 CONSTRAINT [PK_ReturnTransactions] PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Styles]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Styles](
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Styles] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categories] ([Name]) VALUES (N'Bed')
INSERT [dbo].[Categories] ([Name]) VALUES (N'Chair')
INSERT [dbo].[Categories] ([Name]) VALUES (N'Night Stand')
INSERT [dbo].[Categories] ([Name]) VALUES (N'Table')
INSERT [dbo].[Categories] ([Name]) VALUES (N'Wardrobe')
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Sex], [DateOfBirth], [Phone], [Address], [City], [State], [Zip], [UserName], [Password], [IsAdmin]) VALUES (1, N'Jane', N'Doe', N'F', CAST(N'2024-03-02' AS Date), N'404-555-1212', N'123 nowhere dr', N'Atlanta', N'Georgia', N'30303', N'jane', N'DA0BEB81A7A05A5D15F6FB770CE1C17E5658C4C361115E8F0827DED238F429CF12205D3F214B8DD3B469602569BEC55AD5FC2C5A9460B9226EC5673FF00AD325', 1)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Sex], [DateOfBirth], [Phone], [Address], [City], [State], [Zip], [UserName], [Password], [IsAdmin]) VALUES (2, N'John', N'Doe', N'M', CAST(N'2024-03-01' AS Date), N'404-555-1213', N'123 somewhere dr', N'Atlanta', N'Georgia', N'30303', N'john', N'DA0BEB81A7A05A5D15F6FB770CE1C17E5658C4C361115E8F0827DED238F429CF12205D3F214B8DD3B469602569BEC55AD5FC2C5A9460B9226EC5673FF00AD325', 0)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Sex], [DateOfBirth], [Phone], [Address], [City], [State], [Zip], [UserName], [Password], [IsAdmin]) VALUES (3, N'Rob', N'Roberts', N'M', CAST(N'2024-03-03' AS Date), N'404-555-1214', N'123 everywhere dr', N'Atlanta', N'Georgia', N'30303', N'rob', N'DA0BEB81A7A05A5D15F6FB770CE1C17E5658C4C361115E8F0827DED238F429CF12205D3F214B8DD3B469602569BEC55AD5FC2C5A9460B9226EC5673FF00AD325', 0)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Furniture] ON 

INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (1, N'Blue Modern Chair', N'Blue Modern Chair', 30, 9, 0.2500, N'Chair', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (2, N'Red Modern Chair', N'Red Modern Chair', 30, 5, 0.2500, N'Chair', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (3, N'Green Victorian Chair', N'Green Victorian Chair', 30, 1, 0.2500, N'Chair', N'Victorian')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (4, N'Brown Mission Chair', N'Brown Mission Chair', 30, 2, 0.2500, N'Chair', N'Mission')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (5, N'Oak Shaker Chair', N'Oak Shaker Chair', 30, 1, 0.2500, N'Chair', N'Shaker')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (6, N'4 Person Table', N'4 Person Table', 30, 8, 2.0000, N'Table', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (7, N'6 Person Table', N'6 Person Table', 30, 0, 2.1000, N'Table', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (8, N'8 Person Table', N'8 Person Table', 30, 0, 2.2000, N'Table', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (9, N'8 Person Oak Table', N'8 Person Oak Table', 30, 0, 2.3000, N'Table', N'Scandinavian')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (10, N'8 Person Cedar Table', N'8 Person Cedar Table', 30, 0, 2.4000, N'Table', N'Mission')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (11, N'8 Person Metal Table', N'8 Person Metal Table', 30, 0, 2.5000, N'Table', N'Shaker')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (12, N'Large Mahogany Wardrobe', N'Large Mahogany Wardrobe', 30, 1, 2.0000, N'Wardrobe', N'Scandinavian')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (13, N'Medium Mahogany Wardrobe', N'Medium Mahogany Wardrobe', 30, 0, 2.1000, N'Wardrobe', N'Scandinavian')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (14, N'Small Mahogany Wardrobe', N'Small Mahogany Wardrobe', 30, 0, 2.2000, N'Wardrobe', N'Scandinavian')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (15, N'Large Oak Wardrobe', N'Large Oak Wardrobe', 30, 1, 2.3000, N'Wardrobe', N'Contemporary')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (16, N'Medium Oak Wardrobe', N'Medium Oak Wardrobe', 30, 0, 2.4000, N'Wardrobe', N'Contemporary')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (17, N'Small Oak Wardrobe', N'Small Oak Wardrobe', 30, 6, 2.5000, N'Wardrobe', N'Contemporary')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (18, N'Twin Bed', N'Basic Twin Bed', 30, 5, 1.0000, N'Bed', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (19, N'Full Bed', N'Basic Full Bed', 30, 0, 1.2500, N'Bed', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (20, N'Queen Bed', N'Basic Queen Bed', 30, 0, 1.5000, N'Bed', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (21, N'King Bed', N'Basic King Bed', 30, 0, 1.7500, N'Bed', N'Modern')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (22, N'4 Post Queen Bed', N'4 Post Queen Bed', 30, 0, 2.2500, N'Bed', N'Victorian')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (23, N'4 Post King Bed', N'4 Post King Bed', 30, 1, 2.5000, N'Bed', N'Victorian')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (24, N'Oak Night Stand', N'Oak Night Stand', 30, 0, 0.5000, N'Night Stand', N'Contemporary')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (25, N'Mahogany Night Stand', N'Mahogany Night Stand', 30, 2, 0.5000, N'Night Stand', N'Scandinavian')
INSERT [dbo].[Furniture] ([FurnitureID], [Name], [Description], [QuantityOwned], [QuantityRented], [DailyRentalRate], [Category], [Style]) VALUES (26, N'Plain Stand', N'Plain Stand', 30, 0, 0.2500, N'Night Stand', N'Modern')
SET IDENTITY_INSERT [dbo].[Furniture] OFF
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([MemberID], [FirstName], [LastName], [Sex], [DateOfBirth], [Phone], [Address], [City], [State], [Zip]) VALUES (1, N'John', N'Doe', N'M', CAST(N'2004-02-22' AS Date), N'404555-1212', N'123 random road', N'Kennesaw', N'Georgia', N'30144')
INSERT [dbo].[Members] ([MemberID], [FirstName], [LastName], [Sex], [DateOfBirth], [Phone], [Address], [City], [State], [Zip]) VALUES (2, N'Tom', N'Smith', N'M', CAST(N'1994-09-12' AS Date), N'4705551212', N'19412 Quantom Loop', N'Tampa', N'Florida', N'33609')
INSERT [dbo].[Members] ([MemberID], [FirstName], [LastName], [Sex], [DateOfBirth], [Phone], [Address], [City], [State], [Zip]) VALUES (3, N'Jack', N'Box', N'M', CAST(N'1999-06-11' AS Date), N'6785551212', N'123 validation lane', N'Atlanta', N'Georgia', N'30303')
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (7, 1, 6, 3, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (7, 6, 1, 0, 2.0000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (8, 12, 1, 0, 2.0000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (8, 21, 1, 1, 1.7500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (8, 25, 2, 0, 0.5000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (9, 4, 4, 2, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (9, 18, 2, 0, 1.0000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (10, 2, 6, 4, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (10, 7, 1, 1, 2.1000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (10, 17, 1, 1, 2.5000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (10, 23, 1, 0, 2.5000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (10, 26, 2, 2, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (11, 2, 2, 2, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (11, 6, 1, 0, 2.0000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (11, 15, 2, 1, 2.3000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (12, 6, 2, 0, 2.0000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (13, 1, 8, 3, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (13, 6, 4, 0, 2.0000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (14, 5, 1, 1, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (15, 5, 1, 1, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (16, 5, 1, 0, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (17, 3, 1, 0, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (18, 2, 4, 1, 0.2500)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (18, 17, 10, 4, 2.5000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (18, 18, 3, 0, 1.0000)
INSERT [dbo].[RentalLineItems] ([RentalID], [FurnitureID], [QuantityRented], [QuantityReturned], [Cost]) VALUES (19, 1, 1, 0, 0.2500)
GO
SET IDENTITY_INSERT [dbo].[RentalTransactions] ON 

INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (7, CAST(N'2024-04-06T22:32:10.983' AS DateTime), CAST(N'2024-04-09T23:59:59.000' AS DateTime), 2, 1)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (8, CAST(N'2024-04-06T22:33:33.137' AS DateTime), CAST(N'2024-04-12T23:59:59.000' AS DateTime), 2, 2)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (9, CAST(N'2024-04-06T22:34:18.247' AS DateTime), CAST(N'2024-04-09T23:59:59.000' AS DateTime), 2, 1)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (10, CAST(N'2024-04-06T22:36:02.240' AS DateTime), CAST(N'2024-04-12T23:59:59.000' AS DateTime), 2, 3)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (11, CAST(N'2024-04-06T22:59:39.960' AS DateTime), CAST(N'2024-04-09T23:59:59.000' AS DateTime), 2, 1)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (12, CAST(N'2024-04-07T00:29:25.187' AS DateTime), CAST(N'2024-04-12T23:59:59.000' AS DateTime), 2, 2)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (13, CAST(N'2024-04-07T17:59:00.000' AS DateTime), CAST(N'2024-04-09T23:59:59.000' AS DateTime), 2, 2)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (14, CAST(N'2024-04-07T11:18:15.440' AS DateTime), CAST(N'2024-04-12T23:59:59.000' AS DateTime), 2, 2)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (15, CAST(N'2024-04-07T22:25:54.517' AS DateTime), CAST(N'2024-04-09T23:59:59.000' AS DateTime), 2, 3)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (16, CAST(N'2024-04-07T22:26:29.403' AS DateTime), CAST(N'2024-04-12T23:59:59.000' AS DateTime), 2, 3)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (17, CAST(N'2024-04-07T22:29:00.080' AS DateTime), CAST(N'2024-04-09T23:59:59.000' AS DateTime), 2, 3)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (18, CAST(N'2024-04-11T13:13:45.217' AS DateTime), CAST(N'2024-04-12T23:59:59.000' AS DateTime), 2, 1)
INSERT [dbo].[RentalTransactions] ([RentalID], [DateRented], [DateDue], [EmployeeID], [MemberID]) VALUES (19, CAST(N'2024-04-21T11:48:37.663' AS DateTime), CAST(N'2024-04-22T23:59:59.000' AS DateTime), 2, 2)
SET IDENTITY_INSERT [dbo].[RentalTransactions] OFF
GO
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (8, 7, 1, 3, 9.0000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (8, 9, 4, 2, 6.0000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (8, 11, 2, 2, 6.0000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (9, 11, 15, 1, 27.6000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (9, 18, 2, 1, 2.2500, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (9, 18, 17, 4, 90.0000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (10, 8, 21, 1, 15.7500, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (10, 13, 1, 3, 9.0000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (10, 14, 5, 1, 2.2500, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (11, 10, 2, 2, 4.5000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (11, 10, 17, 1, 22.5000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (11, 15, 5, 1, 3.0000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (12, 10, 2, 2, 4.5000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (12, 10, 7, 1, 18.9000, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (12, 10, 26, 1, 2.2500, 0.0000)
INSERT [dbo].[ReturnLineItems] ([ReturnID], [RentalID], [FurnitureID], [Quantity], [Fine], [Refund]) VALUES (13, 10, 26, 1, 2.2500, 0.0000)
GO
SET IDENTITY_INSERT [dbo].[ReturnTransactions] ON 

INSERT [dbo].[ReturnTransactions] ([ReturnID], [DateReturned], [EmployeeID], [MemberID]) VALUES (8, CAST(N'2024-04-21T21:26:37.353' AS DateTime), 2, 1)
INSERT [dbo].[ReturnTransactions] ([ReturnID], [DateReturned], [EmployeeID], [MemberID]) VALUES (9, CAST(N'2024-04-21T21:26:50.063' AS DateTime), 2, 1)
INSERT [dbo].[ReturnTransactions] ([ReturnID], [DateReturned], [EmployeeID], [MemberID]) VALUES (10, CAST(N'2024-04-21T21:27:02.280' AS DateTime), 2, 2)
INSERT [dbo].[ReturnTransactions] ([ReturnID], [DateReturned], [EmployeeID], [MemberID]) VALUES (11, CAST(N'2024-04-21T21:27:15.407' AS DateTime), 2, 3)
INSERT [dbo].[ReturnTransactions] ([ReturnID], [DateReturned], [EmployeeID], [MemberID]) VALUES (12, CAST(N'2024-04-21T21:27:27.167' AS DateTime), 2, 3)
INSERT [dbo].[ReturnTransactions] ([ReturnID], [DateReturned], [EmployeeID], [MemberID]) VALUES (13, CAST(N'2024-04-21T21:27:33.280' AS DateTime), 2, 3)
SET IDENTITY_INSERT [dbo].[ReturnTransactions] OFF
GO
INSERT [dbo].[Styles] ([Name]) VALUES (N'Contemporary')
INSERT [dbo].[Styles] ([Name]) VALUES (N'Mission')
INSERT [dbo].[Styles] ([Name]) VALUES (N'Modern')
INSERT [dbo].[Styles] ([Name]) VALUES (N'Scandinavian')
INSERT [dbo].[Styles] ([Name]) VALUES (N'Shaker')
INSERT [dbo].[Styles] ([Name]) VALUES (N'Victorian')
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD  CONSTRAINT [FK_Furniture_Categories] FOREIGN KEY([Category])
REFERENCES [dbo].[Categories] ([Name])
GO
ALTER TABLE [dbo].[Furniture] CHECK CONSTRAINT [FK_Furniture_Categories]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD  CONSTRAINT [FK_Furniture_Styles] FOREIGN KEY([Style])
REFERENCES [dbo].[Styles] ([Name])
GO
ALTER TABLE [dbo].[Furniture] CHECK CONSTRAINT [FK_Furniture_Styles]
GO
ALTER TABLE [dbo].[RentalLineItems]  WITH CHECK ADD  CONSTRAINT [FK_RentalLineItems_Furnature] FOREIGN KEY([FurnitureID])
REFERENCES [dbo].[Furniture] ([FurnitureID])
GO
ALTER TABLE [dbo].[RentalLineItems] CHECK CONSTRAINT [FK_RentalLineItems_Furnature]
GO
ALTER TABLE [dbo].[RentalLineItems]  WITH CHECK ADD  CONSTRAINT [FK_RentalLineItems_RentalTransactions] FOREIGN KEY([RentalID])
REFERENCES [dbo].[RentalTransactions] ([RentalID])
GO
ALTER TABLE [dbo].[RentalLineItems] CHECK CONSTRAINT [FK_RentalLineItems_RentalTransactions]
GO
ALTER TABLE [dbo].[RentalTransactions]  WITH CHECK ADD  CONSTRAINT [FK_RentalTransactions_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[RentalTransactions] CHECK CONSTRAINT [FK_RentalTransactions_Employees]
GO
ALTER TABLE [dbo].[RentalTransactions]  WITH CHECK ADD  CONSTRAINT [FK_RentalTransactions_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
ALTER TABLE [dbo].[RentalTransactions] CHECK CONSTRAINT [FK_RentalTransactions_Members]
GO
ALTER TABLE [dbo].[ReturnLineItems]  WITH CHECK ADD  CONSTRAINT [FK_ReturnLineItems_RentalLineItems] FOREIGN KEY([RentalID], [FurnitureID])
REFERENCES [dbo].[RentalLineItems] ([RentalID], [FurnitureID])
GO
ALTER TABLE [dbo].[ReturnLineItems] CHECK CONSTRAINT [FK_ReturnLineItems_RentalLineItems]
GO
ALTER TABLE [dbo].[ReturnLineItems]  WITH CHECK ADD  CONSTRAINT [FK_ReturnLineItems_ReturnTransactions] FOREIGN KEY([ReturnID])
REFERENCES [dbo].[ReturnTransactions] ([ReturnID])
GO
ALTER TABLE [dbo].[ReturnLineItems] CHECK CONSTRAINT [FK_ReturnLineItems_ReturnTransactions]
GO
ALTER TABLE [dbo].[ReturnTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTransactions_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[ReturnTransactions] CHECK CONSTRAINT [FK_ReturnTransactions_Employees]
GO
ALTER TABLE [dbo].[ReturnTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTransactions_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
ALTER TABLE [dbo].[ReturnTransactions] CHECK CONSTRAINT [FK_ReturnTransactions_Members]
GO
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/21/2024 9:33:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getMostPopularFurnitureDuringDates]
	-- Add the parameters for the stored procedure here
	(@startDate DateTime, @endDate DateTime)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select
        f.FurnitureId as 'Furniture ID',
        c.Name as 'Category',
        f.Name,
        count(distinct ren.RentalId) as 'Qualified Rentals',
        count(distinct all_rentals.RentalId) as 'All Rentals',
        concat(format(count(distinct ren.RentalId) * 1.0 / count(distinct all_rentals.RentalId) * 100.0, '0.00'), '%') as 'Transaction Ratio',
        concat(format(count(certain_members.MemberId) * 1.0 / count(all_members.MemberId) * 100.0, '0.00'), '%') as '% within 18 to 29',
        concat(format(100.0 - (count(certain_members.MemberId) * 1.0 / count(all_members.MemberId) * 100.0), '0.00'), '%') '% outside 18 to 29'
	from
        RentalTransactions ren 
        join RentalLineItems ren_li 
                on ren.RentalId = ren_li.RentalId
        join Furniture f 
                on f.FurnitureId = ren_li.FurnitureId
        join Categories c
                on c.Name = f.Category
        join Members all_members 
                on all_members.MemberId = ren.MemberId
        left join Members certain_members 
                on certain_members.MemberId = ren.MemberId
                and datediff(year, certain_members.DateOfBirth, ren.DateRented) between 18 and 29 
        left join RentalTransactions all_rentals
                on all_rentals.DateRented between @startDate and @endDate
	where
        ren.DateRented between @startDate and @endDate
	group by f.FurnitureId, c.Name, f.Name
	having count(distinct ren.RentalId) > 1
	order by 'Qualified Rentals' desc, f.FurnitureId desc;

END
GO
USE [master]
GO
ALTER DATABASE [cs6232-g1] SET  READ_WRITE 
GO
