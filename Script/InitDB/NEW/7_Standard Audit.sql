-- B1: Dang nhap bang SYS va chay lan luot 3 cau lenh sau
alter system set audit_trail = DB,EXTENDED scope = spfile;
shutdown immediate;
startup;

--B2: kich hoat audit
AUDIT ALL ON U_AD.NHANVIEN BY ACCESS;
AUDIT ALL ON U_AD.HSBA BY ACCESS;
AUDIT ALL ON U_AD.HSBA_DV BY ACCESS;
AUDIT ALL ON U_AD.BENHNHAN BY ACCESS;
AUDIT ALL ON U_AD.KHOA BY ACCESS;
AUDIT ALL ON U_AD.CSYT BY ACCESS;

-- Test audit
SELECT * FROM U_AD.BENHNHAN;

-- Xem ket qua audit
select username, EXTENDED_TIMESTAMP ,obj_name, action_name, sql_text 
from dba_audit_trail
WHERE OBJ_NAME = 'BENHNHAN';