-----------------------TC2------------------------
-- co 5 nhan vien thuoc so y te voi vai tro "thanh tra"
-- cac nhan vien giu vai tro thanh tra co the đoc du lieu tren tat ca cac bang
-- nhung khong co quyen them xoa sua cac bang nay

-- B1: drop user
DROP USER THANHTRA_1 CASCADE ;
DROP USER THANHTRA_2 CASCADE ;
DROP USER THANHTRA_3 CASCADE ;
DROP USER THANHTRA_4 CASCADE ;
DROP USER THANHTRA_5 CASCADE ;

-- B2: tạo 5 user thanh tra
alter session set "_ORACLE_SCRIPT"=true; 
CREATE USER THANHTRA_1 IDENTIFIED BY 1;
CREATE USER THANHTRA_2 IDENTIFIED BY 2;
CREATE USER THANHTRA_3 IDENTIFIED BY 3;
CREATE USER THANHTRA_4 IDENTIFIED BY 4;
CREATE USER THANHTRA_5 IDENTIFIED BY 5;

GRANT CREATE SESSION TO THANHTRA_1;
GRANT CREATE SESSION TO THANHTRA_2;
GRANT CREATE SESSION TO THANHTRA_3;
GRANT CREATE SESSION TO THANHTRA_4;
GRANT CREATE SESSION TO THANHTRA_5;

-- B3: xoa role
DROP ROLE ROLE_THANHTRA;

-- B4: tao role
CREATE ROLE ROLE_THANHTRA;

-- B5: gan role cho user
GRANT ROLE_THANHTRA TO THANHTRA_1;
GRANT ROLE_THANHTRA TO THANHTRA_2;
GRANT ROLE_THANHTRA TO THANHTRA_3;
GRANT ROLE_THANHTRA TO THANHTRA_4;
GRANT ROLE_THANHTRA TO THANHTRA_5;

-- B6: gan quyen cho role
GRANT SELECT ON HSBA_DV TO ROLE_THANHTRA;
GRANT SELECT ON NHANVIEN TO ROLE_THANHTRA;
GRANT SELECT ON BENHNHAN TO ROLE_THANHTRA;
GRANT SELECT ON KHOA TO ROLE_THANHTRA;
GRANT SELECT ON CSYT TO ROLE_THANHTRA;
GRANT SELECT ON HSBA TO ROLE_THANHTRA;


