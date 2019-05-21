CREATE DATABASE EgitimKayit
GO
USE EgitimKayit 
GO
CREATE TABLE Ogrenci(
Id UNIQUEIDENTIFIER CONSTRAINT OgrenciId PRIMARY KEY ,
OgrenciAdi NVARCHAR(30),OgrenciSoyadi NVARCHAR(30),Telefon NVARCHAR(30),Mail NVARCHAR(30)
);
CREATE TABLE Ogretmen(
Id UNIQUEIDENTIFIER CONSTRAINT OgretmenId PRIMARY KEY ,
OgretmenAdi NVARCHAR(30)
);
CREATE TABLE Sube(
Id UNIQUEIDENTIFIER  CONSTRAINT SubeId PRIMARY KEY ,SubeAdi NVARCHAR(30)
);
CREATE TABLE Ders(
Id UNIQUEIDENTIFIER  CONSTRAINT DersId PRIMARY KEY ,
DersAdi NVARCHAR(30)
);
CREATE TABLE Egitim(
 Id UNIQUEIDENTIFIER CONSTRAINT PK_egitimID PRIMARY KEY ,
   subeId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Sube(Id),
   ogretmenlerId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Ogretmen(Id),
   derslerId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Ders(Id)
);
INSERT INTO Sube(Id,SubeAdi) VALUES('d9ef9209-4186-4f7a-a48e-01574c9eebf0','Mecidiyekoy')
INSERT INTO Sube(Id,SubeAdi) VALUES('f373c222-a640-4c87-ae62-44faa8227711','Umraniye')
INSERT INTO Ders(Id,DersAdi) VALUES('b85933a3-29d1-469b-9e96-b0601a899231','Turkce')
INSERT INTO Ders(Id,DersAdi) VALUES('fbfb8f5c-e336-4bba-91e7-2ed6b6a8e36f','Matematik')
INSERT INTO Ders(Id,DersAdi) VALUES('061cabe7-2674-4a16-925d-8f02377c5c61','Kimya')
INSERT INTO Ogretmen(Id,OgretmenAdi) VALUES('3d4cfa0f-73c3-4446-ae28-492cfad551bf','Ali Duru')
INSERT INTO Ogretmen(Id,OgretmenAdi) VALUES('0e318cea-cf0d-4a3b-aefe-3ce119357712','Ahmet Demir')
INSERT INTO Ogrenci(Id,OgrenciAdi,OgrenciSoyadi,Telefon,Mail) VALUES('4163f4d1-d88d-4ac7-aa02-1af41b0e519e','Talha','Ucar','546546524','ee@gmail.com')
INSERT INTO Ogrenci(Id,OgrenciAdi,OgrenciSoyadi,Telefon,Mail) VALUES('c432323e-6b0b-49ec-afcd-db9916308232','Ayhan','Guney','225685634','msd@gmail.com')