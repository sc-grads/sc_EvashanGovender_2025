GRANT CONTROL ON SCHEMA::Sales TO Auto_User

EXECUTE AS USER = 'Auto_User'
Select * FROM fn_my_permissions ('Sales','SCHEMA')
REVERT
GO