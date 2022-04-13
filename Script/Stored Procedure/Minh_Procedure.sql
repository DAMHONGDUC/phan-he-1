-- Minh dep trai vippro123
-- Procedure them mot user
-- drop procedure sp_addUser;
create or replace procedure sp_addUser
(username in varchar2, pass in varchar2)
as
    grant_statement varchar2(1000);
begin
    grant_statement := 'CREATE USER' || username || ' IDENTIFIED BY '|| pass;
    execute immediate grant_statement;
end;
/

-- Procedure DELETE mot user
-- drop procedure sp_DeleteUser;
create or replace procedure sp_DeleteUser
(username in varchar2, opt in num)
as
    grant_statement varchar2(1000);
begin
    if(opt = 0)
    then
        grant_statement := 'DROP USER ' || username;
        execute immediate grant_statement;
    else
        grant_statement := 'DROP USER' || username || ' CASCADE ';
        execute immediate grant_statement;
    end if;
end;
/


-- Procedure EDIT mot user
-- drop procedure sp_EditUser;
create or replace procedure sp_EditUser
(username in varchar2, pass in varchar2, opt in number)
as
    grant_statement varchar2(1000);
begin
    if(opt = 0)
    then
        grant_statement := 'ALTER USER ' || username || ' IDENTIFIED BY ' || pass || 'ACCOUNT UNLOCK';
        execute immediate grant_statement;
    else
        grant_statement := 'ALTER USER ' || username || ' IDENTIFIED BY ' || pass || 'ACCOUNT LOCK';
        execute immediate grant_statement;
    end if;
end;
/




-- Procedure them mot ROLE
-- drop procedure sp_addRole;
create or replace procedure sp_addRole
(rolename in varchar2)
as
    grant_statement varchar2(1000);
begin
    grant_statement := 'CREATE ROLE' || rolename;
    execute immediate grant_statement;
end;
/

-- Procedure DELETE mot user
-- drop procedure sp_DeleteUser;
create or replace procedure sp_DeleteRole
(rolename in varchar2)
as
    grant_statement varchar2(1000);
begin
    grant_statement := 'DROP ROLE ' || rolename;
    execute immediate grant_statement;
end;
/

