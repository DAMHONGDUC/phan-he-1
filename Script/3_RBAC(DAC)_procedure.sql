--PH1
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

--TC1
-- Procedure tao user BENHNHAN hoac NHANVIEN (co them vai tro)
create or replace procedure createUser
(user_name in varchar2, pwd in varchar2, ty in int , vaitro in NVARCHAR2)
as
    lv_stmt   VARCHAR2 (1000);
begin
    --TAO USER
    lv_stmt := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE ( lv_stmt ); 
    lv_stmt := 'CREATE USER ' || user_name || ' IDENTIFIED BY ' || pwd;
    EXECUTE IMMEDIATE ( lv_stmt ); 
    lv_stmt := 'GRANT CREATE SESSION TO ' || user_name || '';
    EXECUTE IMMEDIATE ( lv_stmt ); 
    
    -- THANHTRA(NHANVIEN)
    IF ty = 1
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(USERNAME, VAITRO) VALUES(''' || user_name || ''', ''' || vaitro || ''')';        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_THANHTRA TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    -- COSOYTE(NHANVIEN)
    ELSIF ty = 2
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(USERNAME, VAITRO) VALUES(''' || user_name || ''', ''' || vaitro || ''')';        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_CSYT TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    -- YBACSI(NHANVIEN)    
    ELSIF ty = 3
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(USERNAME, VAITRO) VALUES(''' || user_name || ''', ''' || vaitro || ''')';        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_YBACSI TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    -- NGHIENCUU(NHANVIEN)    
    ELSIF ty = 4
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(USERNAME, VAITRO) VALUES(''' || user_name || ''', ''' || vaitro || ''')';        
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_NHANVIEN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
        lv_stmt:= 'GRANT ROLE_NGHIENCUU TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    -- BENH NHAN
    ELSIF ty = 5
    THEN
        lv_stmt:= 'INSERT INTO BENHNHAN(USERNAME) VALUES(''' || user_name || ''')';
        EXECUTE IMMEDIATE ( lv_stmt ); 
        lv_stmt:= 'GRANT ROLE_BENHNHAN TO ' || user_name || '';
        EXECUTE IMMEDIATE ( lv_stmt );
    END IF;
end;

/
--TC3
-- Procedure Xoa HSBA by MAHSBA
drop PROCEDURE DELETE_HSBA;

CREATE OR REPLACE PROCEDURE DELETE_HSBA
(MAHSBA_IN number) 
AS
    monthYear VARCHAR2(100);
    fromDate            VARCHAR2(100);
    toDate              VARCHAR2(100);  
     login_user varchar2(255);
    macsytTemp number;
    mahsbaTemp number;
BEGIN
    login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    SELECT MACSYT INTO macsytTemp 
    FROM CSYT
    WHERE USERNAME = login_user;
    
    SELECT MAHSBA  INTO mahsbaTemp 
    FROM U_AD.HSBA
    WHERE MACSYT  = macsyt AND MAHSBA = MAHSBA_IN;
    
    -- delete from 5-27 
    select  to_char(to_date(current_date, 'yyyy/mm/dd'), 'yyyy/mm') into monthYear  from dual;
    fromDate :=  concat(monthYear,'/05');
    toDate := concat(monthYear, '/27');
    
    delete from U_AD.HSBA WHERE MAHSBA = mahsbaTemp AND NGAY >= to_date(fromDate, 'yyyy/mm/dd') AND NGAY <= to_date(toDate,'yyyy/mm/dd');
    COMMIT;
END;

/
--TC3
-- Procuderu xoa HSBA_DV by MAHSBA, MADV, NGAY
drop PROCEDURE DELETE_HSBA_DV;
CREATE OR REPLACE PROCEDURE DELETE_HSBA_DV
(
    MAHSBA_DV_IN number,
    MADV_IN number,
    NGAY_IN date
) 
AS
    monthYear VARCHAR2(100);
    fromDate            VARCHAR2(100);
    toDate              VARCHAR2(100);  
    login_user varchar2(255);
    macsytTemp number;
    mahsbaDvTemp number;
BEGIN
     login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    SELECT MACSYT INTO macsytTemp 
    FROM CSYT
    WHERE USERNAME = login_user;
    
    SELECT MAHSBA  INTO mahsbaDvTemp 
    FROM U_AD.HSBA
    WHERE MACSYT  = macsytTemp AND MAHSBA = MAHSBA_DV_IN;
    -- detele from 5-27
    select  to_char(to_date(current_date, 'yyyy/mm/dd'), 'yyyy/mm') into monthYear  from dual;
    fromDate :=  concat(monthYear,'/05');
    toDate := concat(monthYear, '/27');
    delete from U_AD.HSBA_DV WHERE MA_HSBA  = mahsbaDvTemp AND NGAY = NGAY_IN AND MADV = MADV_IN AND NGAY >= to_date(fromDate, 'yyyy/mm/dd') AND NGAY <= to_date(toDate,'yyyy/mm/dd');
    COMMIT;    
END;

/
--TC3
-- Procedure insert HSBA
drop PROCEDURE INSERT_HSBA;
CREATE OR REPLACE PROCEDURE INSERT_HSBA
(
    MABN_IN NUMBER,
    NGAY_IN DATE,
    CHANDOAN_IN  NVARCHAR2,
    MABS_IN NUMBER ,
    MAKHOA_IN NUMBER ,
    MACSYT_IN NUMBER ,
    KETLUAN_IN NVARCHAR2
)
AS
    login_user varchar2(255);
    macsytTemp number;
BEGIN
    login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    SELECT MACSYT INTO macsytTemp 
    FROM CSYT
    WHERE USERNAME = login_user;
    if (MACSYT_IN <> macsytTemp) then
          return;
    else
          INSERT INTO HSBA(MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN)
            VALUES(MABN_IN, NGAY_IN, CHANDOAN_IN,MABS_IN,MAKHOA_IN,MACSYT_IN,KETLUAN_IN);
            COMMIT;
    end if;
END;

/
--TC3
-- Procudure Insert HSBA_DV
CREATE OR REPLACE PROCEDURE INSERT_HSBA_DV
(
    MAHSBA_IN number,
    MADV_IN number,
    NGAY_IN DATE,
    MAKTV_IN  number,
    KETQUA_IN NVARCHAR2
)
AS
    login_user varchar2(255);
    macsytTemp number;
    macsyt number;
BEGIN
    login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    SELECT MACSYT INTO macsytTemp 
    FROM CSYT
    WHERE USERNAME = login_user;
    
    SELECT MACSYT  INTO macsyt
    FROM HSBA
    WHERE MAHSBA = MAHSBA_IN;
    if (macsyt <> macsytTemp) then
          return;
    else
          INSERT INTO HSBA_DV(MA_HSBA, MADV, NGAY, MAKTV, KETQUA)
            VALUES(MAHSBA_IN, MADV_IN, NGAY_IN,MAKTV_IN,KETQUA_IN);
            COMMIT;
    end if;
END;