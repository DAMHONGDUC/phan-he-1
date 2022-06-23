--DROP USERS
DROP USER U_JohnSena;

--DROP CAC ROLE
DROP ROLE R_Readers;
DROP ROLE R_Librarians;
DROP ROLE R_Managers;

--TAO CAC USERS
CREATE USER U_JohnSena IDENTIFIED BY 1;

--CAP QUYEN CONNECT
GRANT CONNECT, RESOURCE TO U_JohnSena;
GRANT SELECT ON DBA_TAB_PRIVS TO U_JohnSena;
grant select on dba_tables TO U_JohnSena;
grant select on dba_users to U_JohnSena;

--TAO CAC ROLE
CREATE ROLE R_Readers;
CREATE ROLE R_Librarians;
CREATE ROLE R_Managers;

--CAP QUYEN
GRANT R_Readers TO U_JohnSena;

GRANT SELECT ON U_AD.DOCGIA TO R_Readers;
GRANT SELECT ON U_AD.QUANLY TO R_Readers;




  