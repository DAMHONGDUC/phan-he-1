-- B1: Dang nhap bang SYS va chay cau lenh sau:
GRANT SELECT ON dba_audit_trail TO U_AD;

-- B2: Dang nhap bang U_AD va chay lan luot cac cau lenh sau
alter system set audit_trail = DB,EXTENDED scope = spfile;
shutdown immediate;
startup;

-- kich hoat audit
AUDIT ALL ON U_AD.NHANVIEN BY ACCESS;
AUDIT ALL ON U_AD.HSBA BY ACCESS;
AUDIT ALL ON U_AD.HSBA_DV BY ACCESS;
AUDIT ALL ON U_AD.BENHNHAN BY ACCESS;
AUDIT ALL ON U_AD.KHOA BY ACCESS;
AUDIT ALL ON U_AD.CSYT BY ACCESS;

--------------------AUDIT TESTING--------------------
--B1: dang nhap bang user (khac U_AD) va chay cau lenh sau:
SELECT * FROM U_AD.BENHNHAN;

-- B2: dang nhap bang U_AD, chay cau lenh sau de xem ket qua audit:
select username, EXTENDED_TIMESTAMP ,obj_name, action_name, sql_text 
from dba_audit_trail
WHERE OBJ_NAME = 'BENHNHAN';