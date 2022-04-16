-- CAC PROC PHAN QUYEN TREN BANG
-- Nguyen Anh Tuan - 19120416

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