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
