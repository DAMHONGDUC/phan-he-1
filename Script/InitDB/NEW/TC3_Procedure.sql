drop PROCEDURE DELETE_HSBA;
drop PROCEDURE DELETE_HSBA_DV;
drop PROCEDURE INSERT_HSBA;
drop PROCEDURE INSERT_HSBA_DV;

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