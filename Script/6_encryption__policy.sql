-- TAO FUNCTION GIAI MA CMND
create or replace function decrypt_CMND (p_data in varchar2)  
    return varchar2  
as  
    output_string VARCHAR2 (200);
    decrypted_raw RAW (2000); -- stores decrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
begin  
    decrypted_raw := DBMS_CRYPTO.Decrypt
        (
            src => HEXTORAW(p_data),
            typ => encryption_type,
            key => v_key
        );
    output_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
    return output_string;  
end; 
/
-- VIEW XEM CMND BENHNHAN
create or replace view  view_decrypt_BENHNHAN_CMND as 
    select n.MABN, CAST (decrypt_CMND(n.CMND) AS varchar2 (255)) CMND
    from BENHNHAN n;
/
-- VIEW XEM CMND NHANVIEN
create or replace view  view_decrypt_NHANVIEN_CMND as 
    select n.MANV, CAST (decrypt_CMND(n.CMND) AS varchar2 (255)) CMND
    from NHANVIEN n;

/

-- TAO FUNCTION GIAI MA KETQUA/KETLUAN
create or replace function decrypt_KETQUA (p_data in nvarchar2)  
    return varchar2  
as
	input_string VARCHAR2(200);
    output_string NVARCHAR2 (200);
    decrypted_raw RAW (2000); -- stores decrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMCQ-05', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
begin
	input_string := TO_CHAR(p_data);  
    decrypted_raw := DBMS_CRYPTO.Decrypt
        (
            src => HEXTORAW(input_string),
            typ => encryption_type,
            key => v_key
        );
    input_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
	output_string := TO_NCHAR(input_string);
    return output_string; 
end; 
/
-- VIEW XEM KETLUAN HSBA
create or replace view  view_decrypt_HSBA_KETLUAN as 
    select n.MAHSBA, CAST (decrypt_KETQUA(n.KETLUAN) AS nvarchar2 (255)) KETLUAN
    from HSBA n;
/
-- VIEW XEM CMND NHANVIEN
create or replace view  view_decrypt_HSBADV_KETQUA as 
    select n.MA_HSBA, CAST (decrypt_KETQUA(n.KETQUA) AS nvarchar2 (255)) KETQUA
    from HSBA_DV n;