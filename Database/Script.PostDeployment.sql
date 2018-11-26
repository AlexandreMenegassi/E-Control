/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if(not exists(select 1 from Administrador where nome = 'admin'))
begin
	insert into Administrador (Nome)
	values('admin')
end
go

if(not exists(select 1 from Usuario where NivelDeAcesso = 3))
begin
	insert into Administrador (Login, Password, NivelDeAcesso)
	values('admin','123456',3)
end
go

