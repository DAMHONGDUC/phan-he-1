alter session set "_ORACLE_SCRIPT"=true; 
CREATE USER U_AD IDENTIFIED BY 0;

GRANT ALL PRIVILEGES TO U_AD with ADMIN OPTION;

-- cấp quyền này để U_AD có thể xem các quyền trên bảng của 1 user
GRANT SELECT ON DBA_TAB_PRIVS TO U_AD WITH GRANT OPTION;
GRANT SELECT ON ROLE_TAB_PRIVS TO U_AD WITH GRANT OPTION;

-- cấp quyền này để lấy tất cả các bảng trong 1 DB
grant select on dba_tables to U_AD WITH GRANT OPTION;

-- cấp quyền này để lấy tất cả các user trong 1 DB
grant select on dba_users to U_AD WITH GRANT OPTION;

-- cấp những quyền này để lấy tất cả role
grant select on USER_ROLE_PRIVS to U_AD WITH GRANT OPTION;
grant select on DBA_ROLES to U_AD WITH GRANT OPTION;
