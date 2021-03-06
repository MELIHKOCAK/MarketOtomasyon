USE [IlkOtomasyon]
GO
/****** Object:  UserDefinedFunction [dbo].[son]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[son](@sayi1 int)
Returns int
As
Begin
set @sayi1 = (select max(s_no) from TBL_SIPARIS)
Set @sayi1 = @sayi1+1
return @sayi1
End
GO
/****** Object:  Table [dbo].[Siparis_Urun_Detay]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis_Urun_Detay](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[S_No] [int] NOT NULL,
	[U_No] [int] NOT NULL,
	[Adet] [smallint] NOT NULL,
	[BFiyat] [int] NOT NULL,
 CONSTRAINT [PK_Siparis_Urun_Detay] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_KATEGORI]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_KATEGORI](
	[K_No] [tinyint] NOT NULL,
	[K_Ad] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TBL_KATEGORİ] PRIMARY KEY CLUSTERED 
(
	[K_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_MUSTERİ]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_MUSTERİ](
	[M_No] [int] NOT NULL,
	[M_Ad] [varchar](30) NOT NULL,
	[M_Soyad] [varchar](30) NOT NULL,
	[M_Tel] [char](15) NOT NULL,
	[M_Mail] [varchar](40) NULL,
 CONSTRAINT [PK_TBL_MÜŞTERİ] PRIMARY KEY CLUSTERED 
(
	[M_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_SIPARIS]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_SIPARIS](
	[S_No] [int] NOT NULL,
	[S_Tarih] [date] NOT NULL,
	[M_No] [int] NOT NULL,
	[S_ToFiyat] [int] NOT NULL,
 CONSTRAINT [PK_TBL_FATURA] PRIMARY KEY CLUSTERED 
(
	[S_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_TEDARIKCILER]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_TEDARIKCILER](
	[T_No] [tinyint] NOT NULL,
	[T_Ad] [varchar](30) NOT NULL,
	[T_Adres] [varchar](200) NOT NULL,
	[T_Tel] [char](15) NOT NULL,
	[T_Mail] [varchar](40) NOT NULL,
 CONSTRAINT [PK_TBL_PERSONEL] PRIMARY KEY CLUSTERED 
(
	[T_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_URUN]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_URUN](
	[U_No] [int] NOT NULL,
	[U_Ad] [varchar](25) NOT NULL,
	[U_Alis] [int] NOT NULL,
	[U_Satis] [int] NOT NULL,
	[K_No] [tinyint] NOT NULL,
	[T_No] [tinyint] NOT NULL,
	[U_Stok] [tinyint] NOT NULL,
 CONSTRAINT [PK_TBL_ÜRÜNLER] PRIMARY KEY CLUSTERED 
(
	[U_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Siparis_Urun_Detay]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Urun_Detay_TBL_SIPARIS] FOREIGN KEY([S_No])
REFERENCES [dbo].[TBL_SIPARIS] ([S_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Siparis_Urun_Detay] CHECK CONSTRAINT [FK_Siparis_Urun_Detay_TBL_SIPARIS]
GO
ALTER TABLE [dbo].[Siparis_Urun_Detay]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Urun_Detay_TBL_URUN] FOREIGN KEY([U_No])
REFERENCES [dbo].[TBL_URUN] ([U_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Siparis_Urun_Detay] CHECK CONSTRAINT [FK_Siparis_Urun_Detay_TBL_URUN]
GO
ALTER TABLE [dbo].[TBL_SIPARIS]  WITH CHECK ADD  CONSTRAINT [FK_TBL_SIPARIS_TBL_MUSTERİ1] FOREIGN KEY([M_No])
REFERENCES [dbo].[TBL_MUSTERİ] ([M_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_SIPARIS] CHECK CONSTRAINT [FK_TBL_SIPARIS_TBL_MUSTERİ1]
GO
ALTER TABLE [dbo].[TBL_URUN]  WITH CHECK ADD  CONSTRAINT [FK_TBL_URUN_TBL_FIRMA] FOREIGN KEY([T_No])
REFERENCES [dbo].[TBL_TEDARIKCILER] ([T_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_URUN] CHECK CONSTRAINT [FK_TBL_URUN_TBL_FIRMA]
GO
ALTER TABLE [dbo].[TBL_URUN]  WITH CHECK ADD  CONSTRAINT [FK_TBL_URUN_TBL_KATEGORI] FOREIGN KEY([K_No])
REFERENCES [dbo].[TBL_KATEGORI] ([K_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TBL_URUN] CHECK CONSTRAINT [FK_TBL_URUN_TBL_KATEGORI]
GO
/****** Object:  StoredProcedure [dbo].[prkeykontrol]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prkeykontrol] (@kontrol int output, @deger int)
AS
select * from TBL_TEDARIKCILER where T_No = @deger
set @kontrol =@@ROWCOUNT
GO
/****** Object:  StoredProcedure [dbo].[prkeykontrolkategori]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prkeykontrolkategori] (@kontrol int output, @deger int)
AS
select * from TBL_KATEGORI where K_No = @deger
set @kontrol =@@ROWCOUNT
GO
/****** Object:  StoredProcedure [dbo].[prkeykontrolmusteri]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prkeykontrolmusteri] (@kontrol int output, @deger int)
AS
select * from TBL_MUSTERİ where M_No = @deger
set @kontrol =@@ROWCOUNT
GO
/****** Object:  StoredProcedure [dbo].[prkeykontrolsiparis]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prkeykontrolsiparis] (@kontrol int output, @deger int)
AS
select * from TBL_SIPARIS where S_No = @deger
set @kontrol =@@ROWCOUNT
GO
/****** Object:  StoredProcedure [dbo].[prkeykontrolurun]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prkeykontrolurun] (@kontrol int output, @deger int)
AS
select * from TBL_URUN where U_No = @deger
set @kontrol =@@ROWCOUNT
GO
/****** Object:  StoredProcedure [dbo].[son1]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[son1] (@deger int output)
as
BEGIN
SELECT @deger=MAX(S_No) FROM TBL_SIPARIS
if @deger = null
begin
	set @deger=1
end
else
BEGIN
	set @deger=@deger+1
END
END
GO
/****** Object:  StoredProcedure [dbo].[tasima]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[tasima] (@deger int output, @deger2 int output, @deger4 int output, @deger5 int output, @deger3 int )
as
BEGIN

select @deger=(select U_No from Siparis_Urun_Detay where S_No=(select S_No from TBL_SIPARIS where S_No = @deger3))
select @deger2=(select adet from Siparis_Urun_Detay where S_No=(select S_No from TBL_SIPARIS where S_No = @deger3))
select @deger4=(select M_No from TBL_SIPARIS where S_No=(select S_No from Siparis_Urun_Detay where S_No = @deger3))
select @deger5=(select BFiyat from Siparis_Urun_Detay where S_No=(select S_No from TBL_SIPARIS where S_No = @deger3))

END
GO
/****** Object:  StoredProcedure [dbo].[toplamfiyat]    Script Date: 7.01.2021 20:59:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[toplamfiyat] (@tfiyat int output, @bfiyat int, @adet int)
as		
set @tfiyat=@adet*@bfiyat
GO
