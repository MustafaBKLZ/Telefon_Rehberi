USE [master]
GO
/****** Object:  Database [Telefon_Rehberi]    Script Date: 10.02.2022 08:42:29 ******/
CREATE DATABASE [Telefon_Rehberi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Telefon_Rehberi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL2017\MSSQL\DATA\Telefon_Rehberi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Telefon_Rehberi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL2017\MSSQL\DATA\Telefon_Rehberi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Telefon_Rehberi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Telefon_Rehberi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Telefon_Rehberi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET ARITHABORT OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Telefon_Rehberi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Telefon_Rehberi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Telefon_Rehberi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Telefon_Rehberi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Telefon_Rehberi] SET  MULTI_USER 
GO
ALTER DATABASE [Telefon_Rehberi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Telefon_Rehberi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Telefon_Rehberi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Telefon_Rehberi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Telefon_Rehberi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Telefon_Rehberi] SET QUERY_STORE = OFF
GO
USE [Telefon_Rehberi]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Telefon_Rehberi]
GO
/****** Object:  Table [dbo].[KISI_TELEFON_LISTESI]    Script Date: 10.02.2022 08:42:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KISI_TELEFON_LISTESI](
	[tel_RECno] [int] IDENTITY(1,1) NOT NULL,
	[tel_KayitTarih] [datetime] NULL,
	[tel_DegistirmeTarih] [datetime] NULL,
	[tel_Kaydeden] [int] NULL,
	[tel_Degistiren] [int] NULL,
	[tel_TelSahibi] [nvarchar](150) NULL,
	[tel_CepTelNo_1] [nvarchar](50) NULL,
	[tel_CepTelNo_2] [nvarchar](50) NULL,
	[tel_IsTelNo_1] [nvarchar](50) NULL,
	[tel_IsTelNo_2] [nvarchar](50) NULL,
	[tel_FaxNo_1] [nvarchar](50) NULL,
	[tel_FaxNo_2] [nvarchar](50) NULL,
	[tel_EMailAdres_1] [nvarchar](50) NULL,
	[tel_EMailAdres_2] [nvarchar](50) NULL,
	[tel_Aciklama] [nvarchar](max) NULL,
 CONSTRAINT [PK_KISI_TELEFON_LISTESI] PRIMARY KEY CLUSTERED 
(
	[tel_RECno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KULLANICILAR]    Script Date: 10.02.2022 08:42:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KULLANICILAR](
	[kul_RECno] [int] IDENTITY(1,1) NOT NULL,
	[kul_Kod] [int] NULL,
	[kul_Adi] [nvarchar](50) NULL,
	[kul_sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_KULLANICILAR] PRIMARY KEY CLUSTERED 
(
	[kul_RECno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Kisi_Bilgileri_Getir]    Script Date: 10.02.2022 08:42:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE	 FUNCTION [dbo].[Kisi_Bilgileri_Getir]
(	
@id as int 
)
RETURNS TABLE 
AS
RETURN 
(

SELECT [tel_RECno] as [KAYITNO]
      ,[tel_TelSahibi] as [Kişi Adı]
      ,[tel_CepTelNo_1] as [Cep No 1]
      ,[tel_CepTelNo_2]as [Cep No 2]
      ,[tel_IsTelNo_1]as [İş No 1]
      ,[tel_IsTelNo_2] as [İş No 2]
      ,[tel_FaxNo_1] as [Fax No 1]
      ,[tel_FaxNo_2]as [Fax No 2]
      ,[tel_EMailAdres_1] as [E-Posta 1]
      ,[tel_EMailAdres_2]as [E-Posta 2]
      ,[tel_Aciklama]as [Açıklama]
      
	  

      ,[tel_Kaydeden] as [Kaydeden Kod]
	  , (select kul_Adi from KULLANICILAR where  kul_Kod = [tel_Kaydeden]) as [Kaydeden]
	  ,[tel_KayitTarih] AS [Kayıt Tarih]
      

	  ,[tel_Degistiren] as [Değiştiren Kod]
	  , (select kul_Adi from KULLANICILAR where  kul_Kod = [tel_Degistiren]) as Değiştiren
      ,[tel_DegistirmeTarih] as [Değiştirme Tarih]


  FROM [dbo].[KISI_TELEFON_LISTESI] 


)
GO
/****** Object:  StoredProcedure [dbo].[YeniKisi_Kaydet_Guncelle]    Script Date: 10.02.2022 08:42:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[YeniKisi_Kaydet_Guncelle]
 @recno as int ,
 @kullanic_kod as int ,
 @adi as nvarchar(150),
 @ceptel1 as nvarchar(50),
 @ceptel2 as nvarchar(50),
 @istel1 as nvarchar(50),
 @istel2 as nvarchar(50),
 @fax1 as nvarchar(50),
 @fax2 as nvarchar(50),
 @eposta1 as nvarchar(50),
 @eposta2 as nvarchar(50),
 @aciklama as nvarchar(MAX)
 
 AS
BEGIN

if @recno = 0
begin

INSERT INTO [dbo].[KISI_TELEFON_LISTESI]
           ([tel_KayitTarih]
           ,[tel_Kaydeden]
           ,[tel_TelSahibi]
           ,[tel_CepTelNo_1]
           ,[tel_CepTelNo_2]
           ,[tel_IsTelNo_1]
           ,[tel_IsTelNo_2]
           ,[tel_FaxNo_1]
           ,[tel_FaxNo_2]
           ,[tel_EMailAdres_1]
           ,[tel_EMailAdres_2]
           ,[tel_Aciklama])
     VALUES
           (getdate()
           ,@kullanic_kod
           ,@adi
           ,@ceptel1
           ,@ceptel2
           ,@istel1
           ,@istel2
           ,@fax1
           ,@fax2
           ,@eposta1
           ,@eposta2
           ,@aciklama
		   )

end

else 
begin

update [dbo].[KISI_TELEFON_LISTESI] set 
            tel_DegistirmeTarih  =  getdate()
           ,tel_Degistiren		 =  @kullanic_kod
           ,[tel_TelSahibi]		 =  @adi
           ,[tel_CepTelNo_1]	 =  @ceptel1
           ,[tel_CepTelNo_2]	 =  @ceptel2
           ,[tel_IsTelNo_1]		 =  @istel1
           ,[tel_IsTelNo_2]		 =  @istel2
           ,[tel_FaxNo_1]		 =  @fax1
           ,[tel_FaxNo_2]		 =  @fax2
           ,[tel_EMailAdres_1]	 =  @eposta1
           ,[tel_EMailAdres_2]	 =  @eposta2
           ,[tel_Aciklama]		 =  @aciklama
		   
where tel_RECno = @recno
		   

end




END
GO
USE [master]
GO
ALTER DATABASE [Telefon_Rehberi] SET  READ_WRITE 
GO
