USE [master]
GO
/****** Object:  Database [Rental]    Script Date: 3/2/2024 8:44:23 PM ******/
CREATE DATABASE [Rental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Rental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Rental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Rental] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Rental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Rental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Rental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Rental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Rental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Rental] SET ARITHABORT OFF 
GO
ALTER DATABASE [Rental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Rental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Rental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Rental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Rental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Rental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Rental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Rental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Rental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Rental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Rental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Rental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Rental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Rental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Rental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Rental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Rental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Rental] SET RECOVERY FULL 
GO
ALTER DATABASE [Rental] SET  MULTI_USER 
GO
ALTER DATABASE [Rental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Rental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Rental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Rental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Rental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Rental] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Rental', N'ON'
GO
ALTER DATABASE [Rental] SET QUERY_STORE = OFF
GO
USE [Rental]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 3/2/2024 8:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/2/2024 8:44:23 PM ******/
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
	[Zip] [varchar](9) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](256) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furnature]    Script Date: 3/2/2024 8:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furnature](
	[FurnitureID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[QuantityOwned] [int] NOT NULL,
	[QuantityRented] [int] NOT NULL,
	[DailyRentalRate] [money] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[StyleID] [int] NOT NULL,
 CONSTRAINT [PK_Furnature] PRIMARY KEY CLUSTERED 
(
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 3/2/2024 8:44:23 PM ******/
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
	[Zip] [varchar](9) NOT NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalLineItems]    Script Date: 3/2/2024 8:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalLineItems](
	[RentalID] [int] NOT NULL,
	[FurnitureID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_RentalLineItems] PRIMARY KEY CLUSTERED 
(
	[RentalID] ASC,
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTransactions]    Script Date: 3/2/2024 8:44:23 PM ******/
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
/****** Object:  Table [dbo].[ReturnLineItems]    Script Date: 3/2/2024 8:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnLineItems](
	[ReturnID] [int] NOT NULL,
	[RentalID] [int] NOT NULL,
	[FurnitureID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ReturnLineItems] PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC,
	[RentalID] ASC,
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnTransactions]    Script Date: 3/2/2024 8:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnTransactions](
	[ReturnID] [int] NOT NULL,
	[DateReturned] [datetime] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
 CONSTRAINT [PK_ReturnTransactions] PRIMARY KEY CLUSTERED 
(
	[ReturnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Styles]    Script Date: 3/2/2024 8:44:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Styles](
	[StyleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Styles] PRIMARY KEY CLUSTERED 
(
	[StyleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Furnature]  WITH CHECK ADD  CONSTRAINT [FK_Furnature_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Furnature] CHECK CONSTRAINT [FK_Furnature_Categories]
GO
ALTER TABLE [dbo].[Furnature]  WITH CHECK ADD  CONSTRAINT [FK_Furnature_Styles] FOREIGN KEY([StyleID])
REFERENCES [dbo].[Styles] ([StyleID])
GO
ALTER TABLE [dbo].[Furnature] CHECK CONSTRAINT [FK_Furnature_Styles]
GO
ALTER TABLE [dbo].[RentalLineItems]  WITH CHECK ADD  CONSTRAINT [FK_RentalLineItems_Furnature] FOREIGN KEY([FurnitureID])
REFERENCES [dbo].[Furnature] ([FurnitureID])
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
ALTER TABLE [dbo].[ReturnLineItems]  WITH CHECK ADD  CONSTRAINT [FK_ReturnLineItems_RentalTransactions1] FOREIGN KEY([RentalID])
REFERENCES [dbo].[RentalTransactions] ([RentalID])
GO
ALTER TABLE [dbo].[ReturnLineItems] CHECK CONSTRAINT [FK_ReturnLineItems_RentalTransactions1]
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
USE [master]
GO
ALTER DATABASE [Rental] SET  READ_WRITE 
GO
