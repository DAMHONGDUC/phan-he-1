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
