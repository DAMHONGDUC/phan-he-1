
--Chay voi user U_AD
--XOA CAC BANG
DROP TABLE HSBA;
DROP TABLE HSBA_DV;
DROP TABLE NHANVIEN;
DROP TABLE BENHNHAN;
DROP TABLE CSYT;

--****************A. TAO CSDL****************--
--TAO BANG CSYT
CREATE TABLE CSYT
(
    MACSYT NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    TENCSYT NVARCHAR2(50) NOT NULL,
    DCCSYT NVARCHAR2(255) NOT NULL,
    SDTCSYT VARCHAR(15) NOT NULL
);

--TAO BANG BENH NHAN
CREATE TABLE BENHNHAN
(
    MABN NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    MACSYT NUMBER NOT NULL,
    TENBN NVARCHAR2(50) NOT NULL,
    CMND VARCHAR(15) NOT NULL,
    NGAYSINH DATE NOT NULL,
    SONHA NVARCHAR2(50),
    TENDUONG NVARCHAR2(50) NOT NULL,
    QUANHUYEN NVARCHAR2(50) NOT NULL,
    TINHTP NVARCHAR2(50) NOT NULL,
    TIENSUBENH NVARCHAR2(255),
    TIENSUBENHGD NVARCHAR2(255),
    DIUNGTHUOC NVARCHAR2(255),
    USERNAME VARCHAR(50),
    PASSWORD VARCHAR(50),
    
    FOREIGN KEY (MACSYT) REFERENCES CSYT(MACSYT)
);

--TAO BANG NHAN VIEN
CREATE TABLE NHANVIEN
(
    MANV NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    HOTEN NVARCHAR2(50) NOT NULL,
    PHAI NVARCHAR2(3) NOT NULL,
    NGAYSINH DATE NOT NULL,
    CMND VARCHAR(15) NOT NULL,
    QUEQUAN NVARCHAR2(50) NOT NULL,
    SODT VARCHAR(15) NOT NULL,
    CSYT NUMBER NOT NULL,
    VAITRO NVARCHAR2(50) CHECK (VAITRO IN (N'Thanh tra', N'C� s? y t?', N'Y s?/ b�c s?', N'Nghi�n c?u')) NOT NULL,
    CHUYENKHOA NVARCHAR2(255),
    USERNAME VARCHAR(50),
    PASSWORD VARCHAR(50),
    
    FOREIGN KEY (CSYT) REFERENCES CSYT(MACSYT)
);


--TAO BANG HSBA_DV
CREATE TABLE HSBA_DV
(
   MAHSBA NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1),
   MADV NUMBER,
   NGAY DATE,
   MAKTV NUMBER NOT NULL,
   KETQUA NVARCHAR2(255),
   
   PRIMARY KEY(MAHSBA,MADV,NGAY),
   FOREIGN KEY (MAKTV) REFERENCES NHANVIEN(MANV)
);

--TAO BANG HSBA
CREATE TABLE HSBA
(
    MAHSBA NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    MABN NUMBER NOT NULL,
    NGAY DATE NOT NULL,
    CHANDOAN NVARCHAR2(255) NOT NULL,
    MABS NUMBER NOT NULL,
    MAKHOA NUMBER NOT NULL,
    MACSYT NUMBER NOT NULL,
    KETLUAN NVARCHAR2(255) NOT NULL,
    
    FOREIGN KEY (MABN) REFERENCES BENHNHAN(MABN),
    FOREIGN KEY (MABS) REFERENCES NHANVIEN(MANV),
    FOREIGN KEY (MACSYT) REFERENCES CSYT(MACSYT)
);
