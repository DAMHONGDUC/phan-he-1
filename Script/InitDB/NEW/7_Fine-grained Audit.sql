--B2: dang nhap bang U_AD va chay cac cau lenh sau:

--------------------AUDIT column KETLUAN trong bang HSBA--------------------
-- xoa policy
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'U_AD',
  object_name        => 'HSBA',
  policy_name        => 'CHECK_KETLUAN_ON_HSBA');
END;
/
-- tao policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'U_AD',
   object_name        => 'HSBA',
   policy_name        => 'CHECK_KETLUAN_ON_HSBA',
   enable             =>  TRUE,
   statement_types    => 'INSERT, UPDATE, SELECT, DELETE',
   audit_column       => 'KETLUAN',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

--------------------AUDIT column KETQUA trong bang HSBA_DV--------------------
-- xoa policy
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'U_AD',
  object_name        => 'HSBA_DV',
  policy_name        => 'CHECK_KETQUA_ON_HSBA_DV');
END;
/
-- tao policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'U_AD',
   object_name        => 'HSBA_DV',
   policy_name        => 'CHECK_KETQUA_ON_HSBA_DV',
   enable             =>  TRUE,
   statement_types    => 'INSERT, UPDATE, SELECT, DELETE',
   audit_column       => 'KETQUA',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

--------------------AUDIT audit column CMND trong bang NHANVIEN--------------------
-- xoa policy
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'U_AD',
  object_name        => 'NHANVIEN',
  policy_name        => 'CHECK_CMND_ON_NHANVIEN');
END;
/
-- tao policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'U_AD',
   object_name        => 'NHANVIEN',
   policy_name        => 'CHECK_CMND_ON_NHANVIEN',
   enable             =>  TRUE,
   statement_types    => 'INSERT, UPDATE, SELECT, DELETE',
   audit_column       => 'CMND',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

--------------------AUDIT TESTING--------------------
--B1: dang nhap bang user (khac U_AD) va chay cau lenh sau:
SELECT CMND FROM U_AD.NHANVIEN;
SELECT KETLUAN FROM U_AD.HSBA;
SELECT KETQUA FROM U_AD.HSBA_DV;

-- B2: Dang nhap bang U_AD va chay cau lenh sau:
SELECT DBUID, LSQLTEXT, NTIMESTAMP# FROM SYS.FGA_LOG$;