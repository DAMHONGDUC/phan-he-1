-- TC6
-- Tru DBA va role THANHTRA
-- Chi co the xem va sua thong tin cua chinh minh
--- Quyen SELECT

-- Xoa func 
drop function YBacSi_Select_HSBA;
-- Xoa policy Update
begin DBMS_RLS.drop_policy
(object_schema => 'U_AD',
object_name => 'HSBA',
policy_name => 'HSBA_Control_Select'
);
end;

-- Tao function de ap dung 
create or replace function YBacSi_Select_HSBA(
p_schema in varchar2,
p_object in varchar2)
return varchar2
as
    login_user varchar2(255);
    manv number;
begin
    login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    SELECT MANV  INTO manv 
    FROM NHANVIEN
    WHERE USERNAME = login_user;
    RETURN 'MABS   = '''||manv||'''';
end;
/
-- Dang ky function vao chinh sach bao mat
begin DBMS_RLS.add_policy
(object_schema => 'U_AD',
object_name => 'HSBA',
policy_name => 'HSBA_Control_Select',
policy_function => 'YBacSi_Select_HSBA',
statement_types => 'SELECT');
end;


-- DOI VOI NHAN VIEN
-- select
-- Xoa func 
drop function Select_NhanVien;
-- Xoa policy Update
begin DBMS_RLS.drop_policy
(object_schema => 'U_AD',
object_name => 'NHANVIEN',
policy_name => 'NHANVIEN_Control_Select'
);
end;

-- Tao function de ap dung 
create or replace function Select_NhanVien(
p_schema in varchar2,
p_object in varchar2)
return varchar2
as
    login_user varchar2(255);
begin
    login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    if login_user = 'U_AD'  then
        return '1=1';
    elsif login_user like 'THANHTRA%' then
        return '1=1';
    else
        return  'USERNAME   = '''||login_user||'''';
    end if;
end;
/
-- Dang ky function vao chinh sach bao mat
begin DBMS_RLS.add_policy
(object_schema => 'U_AD',
object_name => 'NHANVIEN',
policy_name => 'NHANVIEN_Control_Select',
policy_function => 'Select_NhanVien',
statement_types => 'SELECT');
end;


--- Quyen UPDATE doi voi nhan vien

-- Xoa func 
drop function Update_NhanVien;
-- Xoa policy Update
begin DBMS_RLS.drop_policy
(object_schema => 'U_AD',
object_name => 'NHANVIEN',
policy_name => 'NhanVien_Control_Update'
);
end;

-- Tao function de ap dung 
create or replace function Update_NhanVien(
p_schema in varchar2,
p_object in varchar2)
return varchar2
as
    login_user varchar2(255);
begin
     login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    if login_user = 'U_AD'  then
        return '1=1';
    elsif login_user like 'THANHTRA%' then
        return '1=1';
    else
        return  'USERNAME   = '''||login_user||'''';
    end if;
end;
/
-- Dang ky function vao chinh sach bao mat
begin DBMS_RLS.add_policy
(object_schema => 'U_AD',
object_name => 'NHANVIEN',
policy_name => 'NhanVien_Control_Update',
policy_function => 'Update_NhanVien',
statement_types => 'UPDATE',
update_check => TRUE);
end;



-- DOI VOI BENH NHAN

drop function Select_BenhNhan;
-- Xoa policy Update
begin DBMS_RLS.drop_policy
(object_schema => 'U_AD',
object_name => 'BENHNHAN',
policy_name => 'BENHNHAN_Control_Select'
);
end;

-- Tao function de ap dung 
create or replace function Select_BenhNhan(
p_schema in varchar2,
p_object in varchar2)
return varchar2
as
    login_user varchar2(255);
begin
    login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
    return  'USERNAME   = '''||login_user||'''';
end;
/
-- Dang ky function vao chinh sach bao mat
begin DBMS_RLS.add_policy
(object_schema => 'U_AD',
object_name => 'BENHNHAN',
policy_name => 'BENHNHAN_Control_Select',
policy_function => 'Select_BenhNhan',
statement_types => 'SELECT');
end;


--- Quyen UPDATE doi voi nhan vien

-- Xoa func 
drop function Update_BenhNhan;
-- Xoa policy Update
begin DBMS_RLS.drop_policy
(object_schema => 'U_AD',
object_name => 'BENHNHAN',
policy_name => 'BenhNhan_Control_Update'
);
end;

-- Tao function de ap dung 
create or replace function Update_BENHNHAN(
p_schema in varchar2,
p_object in varchar2)
return varchar2
as
    login_user varchar2(255);
begin
     login_user := SYS_CONTEXT('userenv', 'SESSION_USER');
     return  'USERNAME   = '''||login_user||'''';
end;
/
-- Dang ky function vao chinh sach bao mat
begin DBMS_RLS.add_policy
(object_schema => 'U_AD',
object_name => 'BENHNHAN',
policy_name => 'BenhNhan_Control_Update',
policy_function => 'Update_BENHNHAN',
statement_types => 'UPDATE',
update_check => TRUE);
end;
