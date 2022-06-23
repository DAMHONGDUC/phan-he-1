
--Chay voi user U_AD
--XOA CAC BANG
DROP TABLE CT_PHIEUMUON;
DROP TABLE PHIEUMUONSACH;
DROP TABLE NHANVIEN;
DROP TABLE LOAINHANVIEN;
DROP TABLE SACH;
DROP TABLE LOAISACH;  
DROP TABLE DOCGIA;
DROP TABLE THUVIEN;
DROP TABLE QUANLY;

--****************A. TAO CSDL****************--

--TAO BANG SACH
CREATE TABLE SACH
(
    MASACH VARCHAR2(5),
    MATHUVIEN VARCHAR2(5),
    TENSACH NVARCHAR2(100),
    LOAISACH VARCHAR2(5),
    
    PRIMARY KEY (MASACH)
);

--TAO BANG LOAISACH
CREATE TABLE LOAISACH
(
    MALOAISACH VARCHAR2(5),
    TENLOAISACH NVARCHAR2(20),
    
    PRIMARY KEY (MALOAISACH)
);

--TAO BANG DOCGIA
CREATE TABLE DOCGIA
(
    MADOCGIA VARCHAR2(5),  
    HOTEN NVARCHAR2(20),
    CMND VARCHAR2(15),
    SDT VARCHAR2(15),
    NGAYSINH DATE,
    
    PRIMARY KEY (MADOCGIA)
);

--TAO BANG THUVIEN
CREATE TABLE THUVIEN
(
    MATHUVIEN VARCHAR2(5),
    TENTHUVIEN NVARCHAR2(100),
    
    PRIMARY KEY (MATHUVIEN)
);

--TAO BANG LOAINHANVIEN
CREATE TABLE LOAINHANVIEN
(
    MALOAINV VARCHAR2(5),
    TENLOIANV NVARCHAR2(20),
    
    PRIMARY KEY (MALOAINV)
);

--TAO BANG PHIEUMUONSACH
CREATE TABLE PHIEUMUONSACH
(
    MAPHIEU VARCHAR2(5),
    MATHUVIEN VARCHAR2(5),
    MADOCGIA VARCHAR2(5),
    THOIGIAN DATE,
    SOLUONG NUMBER(5),
    MATHUTHU VARCHAR2(5),
    
    PRIMARY KEY (MAPHIEU)
);

--TAO BANG CT_PHIEUMUON
CREATE TABLE CT_PHIEUMUON
(
    MAPHIEU VARCHAR2(5),
    MASACH VARCHAR2(5),  
    SOLUONGSACH NUMBER(5), 
    
    PRIMARY KEY (MAPHIEU,MASACH)
);

--TAO BANG NHANVIEN
CREATE TABLE NHANVIEN
(
    MANV VARCHAR2(5),
    MATHUVIEN VARCHAR2(5),
    LOAINV VARCHAR2(5),
    HOTEN NVARCHAR2(20),
    NGAYSINH DATE, 
    SDT VARCHAR2(15),
    EMAIL VARCHAR2(20),
    LUONG NUMBER(7,2),
    
    PRIMARY KEY (MANV)
);

--BANG QUANLY
CREATE TABLE QUANLY
(
    MA VARCHAR2(5),
    USERNAME VARCHAR2(20),
    RLS VARCHAR2(20),
    
    PRIMARY KEY (MA)
);

-- TAO KHOA NGOAI CHO BANG SACH
ALTER TABLE SACH
ADD (
    CONSTRAINT FK_SACH_LOAISACH
    FOREIGN KEY (LOAISACH)
    REFERENCES LOAISACH (MALOAISACH),
    
    CONSTRAINT FK_SACH_THUVIEN
    FOREIGN KEY (MATHUVIEN)
    REFERENCES THUVIEN (MATHUVIEN) 
);

-- TAO KHOA NGOAI CHO BANG PHIEUMUONSACH
ALTER TABLE PHIEUMUONSACH
ADD (
    CONSTRAINT FK_PHIEUMUONSACH_DOCGIA
    FOREIGN KEY (MADOCGIA)
    REFERENCES DOCGIA (MADOCGIA),
    
    CONSTRAINT FK_PHIEUMUONSACH_THUVIEN
    FOREIGN KEY (MATHUVIEN)
    REFERENCES THUVIEN (MATHUVIEN),
    
    CONSTRAINT FK_PHIEUMUONSACH_NHANVIEN
    FOREIGN KEY (MATHUTHU)
    REFERENCES NHANVIEN (MANV)
);

-- TAO KHOA NGOAI CHO BANG CT_PHIEUMUON
ALTER TABLE CT_PHIEUMUON
ADD (
    CONSTRAINT FK_CT_PHIEUMUON_PHIEUMUONSACH
    FOREIGN KEY (MAPHIEU)
    REFERENCES PHIEUMUONSACH (MAPHIEU),
    
    CONSTRAINT FK_CT_PHIEUMUON_SACH
    FOREIGN KEY (MASACH)
    REFERENCES SACH (MASACH)
);

-- TAO KHOA NGOAI CHO BANG NHANVIEN
ALTER TABLE NHANVIEN
ADD (
    CONSTRAINT FK_NHANVIEN_THUVIEN
    FOREIGN KEY (MATHUVIEN)
    REFERENCES THUVIEN (MATHUVIEN),
    
    CONSTRAINT FK_NHANVIEN_LOAINHANVIEN
    FOREIGN KEY (LOAINV)
    REFERENCES LOAINHANVIEN (MALOAINV)
);

--****************B. NHAP DU LIEU MAU****************--

--INSERT DU LIEU BANG LOAISACH
INSERT INTO LOAISACH VALUES ('LS1','Poetry');
INSERT INTO LOAISACH VALUES ('LS2','Drama');
INSERT INTO LOAISACH VALUES ('LS3','Prose');
INSERT INTO LOAISACH VALUES ('LS4','Nonfiction');
INSERT INTO LOAISACH VALUES ('LS5','Media');

--INSERT DU LIEU BANG THUVIEN
INSERT INTO THUVIEN VALUES ('TV1','Library of Congress');
INSERT INTO THUVIEN VALUES ('TV2','Shanghai Library');
INSERT INTO THUVIEN VALUES ('TV3','New York Public Library');


--INSERT DU LIEU BANG DOCGIA
INSERT INTO DOCGIA VALUES ('DG1','John Sena','285810506','0355521136',TO_DATE('07-11-2001','dd-mm-yyyy'));
INSERT INTO DOCGIA VALUES ('DG2','Steve Agee','285810507','0355521137',TO_DATE('08-11-2001','dd-mm-yyyy'));
INSERT INTO DOCGIA VALUES ('DG3','Robert Patrick','285810508','0355521138',TO_DATE('09-11-2001','dd-mm-yyyy'));
INSERT INTO DOCGIA VALUES ('DG4','Freddie Stroma','285810509','0355521139',TO_DATE('10-11-2001','dd-mm-yyyy'));
INSERT INTO DOCGIA VALUES ('DG5','Jennifer Holland','285810540','0355521140',TO_DATE('11-11-2001','dd-mm-yyyy'));
INSERT INTO DOCGIA VALUES ('DG6','Harper','285810550','0355521140',TO_DATE('01-11-2001','dd-mm-yyyy'));
INSERT INTO DOCGIA VALUES ('DG7','Gianna','285810560','0355521120',TO_DATE('02-11-2001','dd-mm-yyyy'));
INSERT INTO DOCGIA VALUES ('DG8','Evelyn','285810570','0355521110',TO_DATE('03-11-2001','dd-mm-yyyy'));
INSERT INTO DOCGIA VALUES ('DG9','Aria','285810580','0355521180',TO_DATE('04-11-2001','dd-mm-yyyy'));

--INSERT DU LIEU BANG SACH
INSERT INTO SACH VALUES ('S1','TV1','In Search of Lost Time','LS1');
INSERT INTO SACH VALUES ('S2','TV2','Ulysses','LS2');
INSERT INTO SACH VALUES ('S3','TV3','Don Quixote','LS3');
INSERT INTO SACH VALUES ('S4','TV1','The Great Gatsby','LS4');
INSERT INTO SACH VALUES ('S5','TV2','Moby Dick','LS5');

--INSERT DU LIEU BANG LOAINHANVIEN
INSERT INTO LOAINHANVIEN VALUES ('LNV1','Librarian');
INSERT INTO LOAINHANVIEN VALUES ('LNV2','Manager');

--INSERT DU LIEU BANG NHANVIEN
INSERT INTO NHANVIEN VALUES ('NV1','TV1','LNV1','James',TO_DATE('11-11-2001','dd-mm-yyyy'),'0355521140','james@gmail.com',2000);
INSERT INTO NHANVIEN VALUES ('NV2','TV1','LNV1','Robert',TO_DATE('10-11-2001','dd-mm-yyyy'),'0355521150','robert@gmail.com',1000);
INSERT INTO NHANVIEN VALUES ('NV3','TV1','LNV2','John',TO_DATE('11-9-2001','dd-mm-yyyy'),'0355521130','john@gmail.com',1500);
INSERT INTO NHANVIEN VALUES ('NV4','TV2','LNV1','Liam',TO_DATE('11-11-2001','dd-mm-yyyy'),'0355521140','liam@gmail.com',2000);
INSERT INTO NHANVIEN VALUES ('NV5','TV2','LNV1','Noah',TO_DATE('10-11-2001','dd-mm-yyyy'),'0355521150','noah@gmail.com',1000);
INSERT INTO NHANVIEN VALUES ('NV6','TV2','LNV2','Oliver',TO_DATE('11-9-2001','dd-mm-yyyy'),'0355521130','oliver@gmail.com',1500);
INSERT INTO NHANVIEN VALUES ('NV7','TV3','LNV1','William',TO_DATE('11-11-2001','dd-mm-yyyy'),'0355521140','william@gmail.com',2000);
INSERT INTO NHANVIEN VALUES ('NV8','TV3','LNV1','David',TO_DATE('10-11-2001','dd-mm-yyyy'),'0355521150','david@gmail.com',1000);
INSERT INTO NHANVIEN VALUES ('NV9','TV3','LNV2','Richard',TO_DATE('11-9-2001','dd-mm-yyyy'),'0355521130','richard@gmail.com',1500);

--INSERT DU LIEU BANG PHIEUMUONSACH
INSERT INTO PHIEUMUONSACH VALUES('P1','TV1','DG1',TO_DATE('11-03-2001','dd-mm-yyyy'),1,'NV1');
INSERT INTO PHIEUMUONSACH VALUES('P2','TV1','DG2',TO_DATE('12-03-2001','dd-mm-yyyy'),2,'NV2');
INSERT INTO PHIEUMUONSACH VALUES('P3','TV1','DG3',TO_DATE('14-03-2001','dd-mm-yyyy'),3,'NV1');
INSERT INTO PHIEUMUONSACH VALUES('P4','TV2','DG4',TO_DATE('15-03-2001','dd-mm-yyyy'),4,'NV4');
INSERT INTO PHIEUMUONSACH VALUES('P5','TV2','DG5',TO_DATE('15-03-2001','dd-mm-yyyy'),3,'NV5');
INSERT INTO PHIEUMUONSACH VALUES('P6','TV2','DG6',TO_DATE('15-03-2001','dd-mm-yyyy'),3,'NV4');
INSERT INTO PHIEUMUONSACH VALUES('P7','TV3','DG7',TO_DATE('15-03-2001','dd-mm-yyyy'),3,'NV7');
INSERT INTO PHIEUMUONSACH VALUES('P8','TV3','DG8',TO_DATE('15-03-2001','dd-mm-yyyy'),2,'NV8');
INSERT INTO PHIEUMUONSACH VALUES('P9','TV3','DG9',TO_DATE('15-03-2001','dd-mm-yyyy'),1,'NV7');

--INSERT DU LIEU BANG CT_PHIEUMUON
INSERT INTO CT_PHIEUMUON VALUES('P1','S1',1);
INSERT INTO CT_PHIEUMUON VALUES('P2','S2',2);
INSERT INTO CT_PHIEUMUON VALUES('P3','S3',3);
INSERT INTO CT_PHIEUMUON VALUES('P4','S4',4);
INSERT INTO CT_PHIEUMUON VALUES('P5','S5',3);
INSERT INTO CT_PHIEUMUON VALUES('P6','S1',3);
INSERT INTO CT_PHIEUMUON VALUES('P7','S2',3);
INSERT INTO CT_PHIEUMUON VALUES('P8','S3',2);
INSERT INTO CT_PHIEUMUON VALUES('P9','S4',1);

--INSERT DU LIEU BANG QUANLY
INSERT INTO QUANLY VALUES('DG0','U_AD','R_AD');
INSERT INTO QUANLY VALUES('DG1','U_JohnSena','R_Readers');
INSERT INTO QUANLY VALUES('DG2','U_SteveAgee','R_Readers');
INSERT INTO QUANLY VALUES('DG3','U_RobertPatrick','R_Readers');
INSERT INTO QUANLY VALUES('DG4','U_FreddieStroma','R_Readers');
INSERT INTO QUANLY VALUES('DG5','U_JenniferHolland','R_Readers');
INSERT INTO QUANLY VALUES('DG6','U_Harper','R_Readers');
INSERT INTO QUANLY VALUES('DG7','U_Gianna','R_Readers');
INSERT INTO QUANLY VALUES('DG8','U_Evelyn','R_Readers');
INSERT INTO QUANLY VALUES('DG9','U_Aria','R_Readers');


-- Procedure thu hoi ROLE tu USER
-- drop procedure sp_RevokeRoleFromUser_OR_Role;
create or replace procedure sp_RevokeRoleFromUser_OR_Role
(role_name in varchar2, userORrole_name in varchar2)
as
    revoke_statement varchar2(255);
begin
    revoke_statement := 'revoke ' || role_name || ' from ' || userORrole_name;
    execute immediate revoke_statement;
end;
/

-- CAC PROC PHAN QUYEN TREN BANG
-- Procedure gan quyen tren bang bat ky
-- drop procedure sp_grantPrivilegeOnTable;
create or replace procedure sp_grantPrivilegeOnTable
(table_name in varchar2, userOrRole_name in varchar2, priv in varchar2, grant_option in varchar2)
as
    grant_statement varchar2(255);
    grant_statement_opt varchar2(255);
begin
    if(grant_option = 'N')
    then
        grant_statement := 'grant ' || priv || ' on '|| table_name || ' to ' || userOrRole_name;
        execute immediate grant_statement;
    else
         grant_statement_opt := 'grant ' || priv || ' on '|| table_name || ' to ' || userOrRole_name || ' with grant option';
        execute immediate grant_statement_opt;
    end if;
end;
/

-- Procedure thu hoi quyen tren bang bat ky
-- drop procedure sp_revokePrivilegeOnTable;
create or replace procedure sp_revokePrivilegeOnTable
(table_name in varchar2, userOrRole_name in varchar2, priv in varchar2)
as
    revoke_statement varchar2(255);
begin
    revoke_statement := 'revoke ' || priv || ' on '|| table_name || ' from ' || userOrRole_name;
    execute immediate revoke_statement;
end;
/


-- Procedure kiem tra xem user/role co ton tai hay khong
-- drop procedure sp_checkIfUserOrRoleExist;
create or replace procedure sp_checkIfUserOrRoleExist
(userOrRole_name in varchar2, result out varchar2)
as
    row_countUser number;
    row_countRole number;
begin
    select count(*) into row_countUser from DBA_USERS where Username = userOrRole_name;
    if row_countUser <> 0
    then
        result := 'User';
        return;
    end if;
    
    select count(*) into row_countRole from DBA_ROLES where Role = userOrRole_name;
    if row_countRole <> 0
    then
        result := 'Role';
        return;
    end if;
    
    result := 'NoExist';
end;
/


-- Procedure kiem tra xem user co privilege nay hay khong
-- drop procedure sp_checkIfPrivilegeBelongToUser;
-- LUU Y: Ten userTable_name, user_priv phai IN HOA !!!!
create or replace procedure sp_checkIfPrivilegeBelongToUser
(user_name in varchar2, userTable_name in varchar2, user_priv in varchar2, grant_opt in varchar2, checkResult out varchar2)
as
    row_count number;
begin
    select count(*) into row_count from DBA_TAB_PRIVS where grantee = user_name
    and table_name = userTable_name and privilege = user_priv and grantable = grant_opt;
    if row_count <> 0
    then
        checkResult := 'Yes';
        return;
    else
        checkResult := 'No';
    end if;
end;
/


-- Procedure kiem tra xem role co privilege nay hay khong
-- drop procedure sp_checkIfPrivilegeBelongToRole;
-- LUU Y: Ten roleTable_name, role_priv phai IN HOA !!!!
create or replace procedure sp_checkIfPrivilegeBelongToRole
(role_name in varchar2, roleTable_name in varchar2, role_priv in varchar2, grant_opt in varchar2, checkResult out varchar2)
as
    row_count number;
begin
    select count(*) into row_count from ROLE_TAB_PRIVS where role = role_name
    and table_name = roleTable_name and privilege = role_priv and grantable = grant_opt;
    if row_count <> 0
    then
        checkResult := 'Yes';
        return;
    else
        checkResult := 'No';
    end if;
end;
/


-- Procedure gan role cho user bat ky
-- drop procedure sp_grantRoleToUser;
create or replace procedure sp_grantRoleToUser
(role_name in varchar2, userOrRole_name in varchar2)
as
    grant_statement varchar2(255);
begin
    grant_statement := 'grant ' || role_name || ' to ' || userOrRole_name;
    execute immediate grant_statement; 
end;
/