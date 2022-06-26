--Chay voi user U_AD
--XOA CAC BANG

DROP TABLE HSBA_DV purge;
DROP TABLE HSBA purge;
DROP TABLE NHANVIEN purge;
DROP TABLE BENHNHAN purge;
DROP TABLE KHOA purge;
DROP TABLE CSYT purge;


--****************A. TAO CSDL****************--
--TAO BANG CSYT
CREATE TABLE CSYT
(
    MACSYT NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    TENCSYT NVARCHAR2(50) NOT NULL,
    DCCSYT NVARCHAR2(255) NOT NULL,
    SDTCSYT VARCHAR(15) NOT NULL,
    USERNAME VARCHAR(50)
);

--TAO BANG BENH NHAN
CREATE TABLE BENHNHAN
(
    MABN NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    MACSYT NUMBER ,
    TENBN NVARCHAR2(50) ,
    CMND VARCHAR2(255) ,
    NGAYSINH DATE ,
    SONHA NVARCHAR2(50),
    TENDUONG NVARCHAR2(50) ,
    QUANHUYEN NVARCHAR2(50) ,
    TINHTP NVARCHAR2(50) ,
    TIENSUBENH NVARCHAR2(255),
    TIENSUBENHGD NVARCHAR2(255),
    DIUNGTHUOC NVARCHAR2(255),
    USERNAME VARCHAR(50),
    
    FOREIGN KEY (MACSYT) REFERENCES CSYT(MACSYT)
);

--TAO BANG NHAN VIEN
CREATE TABLE NHANVIEN
(
    MANV NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    HOTEN NVARCHAR2(50) ,
    PHAI NVARCHAR2(3) ,
    NGAYSINH DATE ,
    CMND VARCHAR2(255) ,
    QUEQUAN NVARCHAR2(50) ,
    SODT VARCHAR(15) ,
    CSYT NUMBER ,
    VAITRO NUMBER CHECK (VAITRO IN (1,2,3,4)),
    CHUYENKHOA NVARCHAR2(255),
    USERNAME VARCHAR(50),
    
    FOREIGN KEY (CSYT) REFERENCES CSYT(MACSYT)
);

--TAO BANG CHUYENKHOA
CREATE TABLE KHOA
(
    MAKHOA NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT by 1) PRIMARY KEY,
    TENKHOA NVARCHAR2(255)
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
    FOREIGN KEY (MACSYT) REFERENCES CSYT(MACSYT),
    FOREIGN KEY (MAKHOA) REFERENCES KHOA(MAKHOA)
);

--TAO BANG HSBA_DV
CREATE TABLE HSBA_DV
(
   MA_HSBA NUMBER,
   MADV NUMBER,
   NGAY DATE,
   MAKTV NUMBER NOT NULL,
   KETQUA NVARCHAR2(255),
   
   PRIMARY KEY(MA_HSBA,MADV,NGAY),
   FOREIGN KEY (MA_HSBA) REFERENCES HSBA(MAHSBA),
   FOREIGN KEY (MAKTV) REFERENCES NHANVIEN(MANV)
);

-- Trigger MA HOA COT KET LUAN CUA BANG HSBA
CREATE OR REPLACE TRIGGER ENCRYPT_HSBA_KETLUAN
BEFORE INSERT OR UPDATE ON HSBA
FOR EACH ROW
WHEN (new.MAHSBA > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.KETLUAN);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.KETLUAN := TO_NCHAR(input_string);
END;
/

-- Trigger MA HOA COT KET QUA CUA BANG HSBA_DV
CREATE OR REPLACE TRIGGER ENCRYPT_HSBADV_KETQUA
BEFORE INSERT OR UPDATE ON HSBA_DV
FOR EACH ROW
WHEN (new.MA_HSBA > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.KETQUA);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.KETQUA := TO_NCHAR(input_string);
END;
/

-- Trigger MA HOA COT CMND CUA BANG BENHNHAN
CREATE OR REPLACE TRIGGER ENCRYPT_BENHNHAN_CMND
BEFORE INSERT OR UPDATE ON BENHNHAN
FOR EACH ROW
WHEN (new.MABN > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.CMND);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.CMND := input_string;
END;
/

-- Trigger MA HOA COT CMND CUA BANG NHANVIEN
CREATE OR REPLACE TRIGGER ENCRYPT_NHANVIEN_CMND
BEFORE INSERT OR UPDATE ON NHANVIEN
FOR EACH ROW
WHEN (new.MANV > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.CMND);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.CMND := input_string;
END;
/

-- Trigger MA HOA COT KET LUAN CUA BANG HSBA
CREATE OR REPLACE TRIGGER ENCRYPT_HSBA_KETLUAN
BEFORE INSERT OR UPDATE ON HSBA
FOR EACH ROW
WHEN (new.MAHSBA > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.KETLUAN);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.KETLUAN := TO_NCHAR(input_string);
END;
/

-- Trigger MA HOA COT KET QUA CUA BANG HSBA_DV
CREATE OR REPLACE TRIGGER ENCRYPT_HSBADV_KETQUA
BEFORE INSERT OR UPDATE ON HSBA_DV
FOR EACH ROW
WHEN (new.MA_HSBA > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.KETQUA);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.KETQUA := TO_NCHAR(input_string);
END;
/

-- Trigger MA HOA COT CMND CUA BANG BENHNHAN
CREATE OR REPLACE TRIGGER ENCRYPT_BENHNHAN_CMND
BEFORE INSERT OR UPDATE ON BENHNHAN
FOR EACH ROW
WHEN (new.MABN > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.CMND);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.CMND := input_string;
END;
/

-- Trigger MA HOA COT CMND CUA BANG NHANVIEN
CREATE OR REPLACE TRIGGER ENCRYPT_NHANVIEN_CMND
BEFORE INSERT OR UPDATE ON NHANVIEN
FOR EACH ROW
WHEN (new.MANV > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.CMND);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    input_string := RAWTOHEX(encrypted_raw);
    :new.CMND := input_string;
END;
