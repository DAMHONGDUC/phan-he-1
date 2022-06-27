-- TC 7
--===== CHAY DUOI QUYEN SYSDBA ======
SELECT STATUS FROM DBA_OLS_STATUS WHERE NAME = 'OLS_CONFIGURE_STATUS';

EXEC LBACSYS.CONFIGURE_OLS;  -- This procedure registers Oracle Label Security.
/
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS; -- This procedure enables it.
/
ALTER USER LBACSYS ACCOUNT UNLOCK IDENTIFIED BY 0;
/

-- ===== CHAY DUOI QUYEN LBACSYS =======
-- Xoa policy
--exec sa_sysdba.drop_policy('THONGBAO_OLS',TRUE);

-- Tao policy
exec sa_sysdba.create_policy(policy_name => 'THONGBAO_OLS',column_name => 'row_label');
/
-- Gan quyen cho Quan tri vien
grant THONGBAO_OLS_DBA to U_AD;

grant execute on SA_COMPONENTS to U_AD;
grant execute on SA_LABEL_ADMIN to U_AD;
grant execute on SA_POLICY_ADMIN to U_AD;
grant execute on SA_USER_ADMIN to U_AD;
grant execute on CHAR_TO_LABEL to U_AD;


-- ===== CHAY DUOI QUYEN U_AD =====
-- Tao level
BEGIN
sa_components.create_level(
    policy_name => 'THONGBAO_OLS',
    long_name => 'Giam doc so',
    short_name => 'GDS',
    level_num => 1000);

sa_components.create_level(
    policy_name => 'THONGBAO_OLS',
    long_name => 'Giam doc co so',
    short_name => 'GDCS',
    level_num => 100);

sa_components.create_level(
    policy_name => 'THONGBAO_OLS',
    long_name => 'Y bac si',
    short_name => 'YBS',
    level_num => 10);
END;
/

-- Tao compartments
exec sa_components.create_compartment('THONGBAO_OLS',1000,'TT','Trung Tam');
/
exec sa_components.create_compartment('THONGBAO_OLS',2000,'CTT','Can Trung Tam');
/
exec sa_components.create_compartment('THONGBAO_OLS',3000,'NT','Ngoai Thanh');
/

-- Tao groups
exec sa_components.create_group('THONGBAO_OLS',1,'CSAU','Dieu tri chuyen sau',NULL);
/
exec sa_components.create_group('THONGBAO_OLS',2,'NTRU','Dieu tri noi tru','CSAU');
/
exec sa_components.create_group('THONGBAO_OLS',3,'NGTRU','Dieu tri ngoai tru','NTRU');
/

-- Tao label
execute sa_label_admin.create_label('THONGBAO_OLS',2230,'GDS:TT,CTT,NT:CSAU');
/
execute sa_label_admin.create_label('THONGBAO_OLS',1250,'GDCS:TT,CTT,NT:CSAU');
/
execute sa_label_admin.create_label('THONGBAO_OLS',2210,'YBS:TT:NTRU');
/
execute sa_label_admin.create_label('THONGBAO_OLS',2320,'YBS:TT,CTT,NT:CSAU');
/


-- Xoa bang
drop table THONGBAO purge;
-- Tao bang du lieu
create table THONGBAO(
    NOIDUNG varchar2(255),
    NGAYGIO Date,
    DIADIEM varchar2(255),
    CAPBACTHAMGIA number, -- 3:Giam doc so, Thanh tra; 2:Giam doc CSYT; 1:Y/Bac si (CO PHAN BIET THU TU)
    VUNGLV number, -- 3:Trung tam; 2:Can trung tam; 1:Ngoai thanh; 0:Tat ca cac vung
    CHUYENMON number -- 3:Chuyen sau; 2:Noi tru; 1:Ngoai tru (CO PHAN BIET THU TU)
);

-- Them du lieu vao bang THONGBAO
insert into THONGBAO values ('Gap mat GIAM DOC CSYT',TO_DATE('2022/12/16 ', 'yyyy/mm/dd '),'TP.HCM',2,0,3);
insert into THONGBAO values ('Gap mat Y BAC SI NOI TRU  tro len o TRUNG TAM',TO_DATE('2022/10/16 ', 'yyyy/mm/dd '),'TP.HCM',1,3,2);
insert into THONGBAO values ('Gap mat Y BAC SI CHUYEN SAU',TO_DATE('2022/02/05 ', 'yyyy/mm/dd '),'TP.HCM',1,0,3);
insert into THONGBAO values ('Gap mat GIAM DOC SO va THANH TRA SO',TO_DATE('2022/12/10 ', 'yyyy/mm/dd '),'TP.HCM',3,0,3);


-- gan chinh sach ban dau cho bang de gan label cho du lieu
begin
sa_policy_admin.apply_table_policy
(policy_name => 'THONGBAO_OLS',
schema_name => 'U_AD',
table_name => 'THONGBAO',
table_options => 'NO_CONTROL');
end;
/
-- gan chinh sach cho cac du lieu
update THONGBAO 
set row_label = char_to_label('THONGBAO_OLS', 'GDCS:TT,CTT,NT:CSAU')
where CAPBACTHAMGIA >= 2 and VUNGLV = 0 and CHUYENMON = 3;

update THONGBAO 
set row_label = char_to_label('THONGBAO_OLS', 'YBS:TT:NTRU')
where CAPBACTHAMGIA >= 1 and VUNGLV = 3 and CHUYENMON >= 2;

update THONGBAO 
set row_label = char_to_label('THONGBAO_OLS', 'YBS:TT,CTT,NT:CSAU')
where CAPBACTHAMGIA >= 1 and VUNGLV = 0 and CHUYENMON = 3;

update THONGBAO 
set row_label = char_to_label('THONGBAO_OLS', 'GDS:TT,CTT,NT:CSAU')
where CAPBACTHAMGIA = 3 and VUNGLV = 0 and CHUYENMON = 3;

-- Xoa ap dung policy
BEGIN
  sa_policy_admin.remove_table_policy(
  policy_name  => 'THONGBAO_OLS',
  schema_name  => 'U_AD',
  table_name  => 'THONGBAO');
end;
/
-- Ap dung policy OLS
begin
  sa_policy_admin.apply_table_policy(
  policy_name  => 'THONGBAO_OLS',
  schema_name  => 'U_AD',
  table_name  => 'THONGBAO',
  table_options  => 'READ_CONTROL');
end;
/

-- Tao cac loai nguoi dung
alter session set "_ORACLE_SCRIPT"=true;
/
-- Xoa nguoi dung
--drop user GIAM_DOC_SO cascade;
--drop user THANH_TRA cascade;
--drop user GIAM_DOC_CSYT cascade;
--drop user Y_BACSI_NOITRU_TRUNGTAM cascade;
--drop user Y_BACSI_CHUYENSAU cascade;

-- Tao nguoi dung
create user GIAM_DOC_SO identified by 0;
grant create session to GIAM_DOC_SO;

create user THANH_TRA identified by 0;
grant create session to THANH_TRA;

create user GIAM_DOC_CSYT identified by 0;
grant create session to GIAM_DOC_CSYT;

create user Y_BACSI_NOITRU_TRUNGTAM identified by 0;
grant create session to Y_BACSI_NOITRU_TRUNGTAM;

create user Y_BACSI_CHUYENSAU identified by 0;
grant create session to Y_BACSI_CHUYENSAU;

grant select on THONGBAO to GIAM_DOC_SO;
grant select on THONGBAO to THANH_TRA;
grant select on THONGBAO to GIAM_DOC_CSYT;
grant select on THONGBAO to Y_BACSI_NOITRU_TRUNGTAM;
grant select on THONGBAO to Y_BACSI_CHUYENSAU;

--gan quyen nguoi dung theo cac yeu cau cua label
begin
sa_user_admin.set_user_labels
  (policy_name => 'THONGBAO_OLS',
  user_name => 'GIAM_DOC_SO',
  max_read_label => 'GDS:TT,CTT,NT:CSAU');
end;
/
begin
  sa_user_admin.set_user_labels
  (policy_name => 'THONGBAO_OLS',
  user_name => 'THANH_TRA',
  max_read_label => 'GDS:TT,CTT,NT:CSAU');
end;
/
begin
  sa_user_admin.set_user_labels
  (policy_name => 'THONGBAO_OLS',
  user_name => 'GIAM_DOC_CSYT',
  max_read_label => 'GDCS:TT,CTT,NT:CSAU');
end;
/
begin
  sa_user_admin.set_user_labels
  (policy_name => 'THONGBAO_OLS',
  user_name => 'Y_BACSI_NOITRU_TRUNGTAM',
  max_read_label => 'YBS:TT:NTRU');
end;
/
begin
  sa_user_admin.set_user_labels
  (policy_name => 'THONGBAO_OLS',vbn 
  user_name => 'Y_BACSI_CHUYENSAU',
  max_read_label => 'YBS:TT,CTT,NT:CSAU');
end;

