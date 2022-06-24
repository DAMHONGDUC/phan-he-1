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

-- Procedure tao user BENHNHAN hoac NHANVIEN (co them vai tro)
create or replace procedure createUser
(user_name in varchar2, pwd in varchar2, ty in int , vaitro in NVARCHAR2)
as
    lv_stmt   VARCHAR2 (1000);
begin
    --TAO USER
    lv_stmt := 'CREATE USER ' || user_name || ' IDENTIFIED BY ' || pwd;
    EXECUTE IMMEDIATE ( lv_stmt ); 
    lv_stmt := 'GRANT CREATE SESSION TO ' || user_name || '';
    EXECUTE IMMEDIATE ( lv_stmt ); 
    
    --NHAN VIEN 
    IF ty = 0
    THEN
        lv_stmt:= 'INSERT INTO NHANVIEN(USERNAME, VAITRO) VALUES(''' || user_name || ''', ''' || vaitro || ''')';
        EXECUTE IMMEDIATE ( lv_stmt ); 
    --BENH NHAN
    ELSIF ty = 1
    THEN
        lv_stmt:= 'INSERT INTO BENHNHAN(USERNAME) VALUES(''' || user_name || ''')';
        EXECUTE IMMEDIATE ( lv_stmt ); 
    END IF;
end;