use master 

Create DataBase CooperativaSystem

Use CooperativaSystem;

Create Schema Sch_CooperativaSystem;

--Relacion TipoPretamo
Create Table TipoPrestamo
(
	IdTipoPrestamo int primary key Identity,
	TipoPrestamo nvarchar(40) not null unique,
)

--Relacion Nacionalidad
Create Table Nacionalidad
(
	IdNacionalidad int primary key Identity,
	Nacionalidad nvarchar(40) not null unique,
)

--Relacion Profesion
Create Table Profesion
(
	IdProfesion int primary key Identity,
	Profesion nvarchar(40) not null unique,
)

--Relacion TipoCuenta
Create Table TipoCuenta
(
	IdTipoCuenta int primary key Identity,
	TipoCuenta nvarchar(30) not null unique,
	DescripcionCuenta nvarchar(200) not null,
)

--Relacion Estado
Create Table Estado
(
	IdEstado int primary key Identity ,
	Estado nvarchar(20) not null unique,
)
--Relacion EstadoCivil
Create Table EstadoCivil
(
	IdEstadoCivil int primary key Identity ,
	EstadoCivil nvarchar(20) not null unique,
)
--Relacion Sexo
Create Table Sexo
(
	IdSexo int primary key Identity ,
	Sexo nvarchar (12)  not null unique,
)

--Relacion Oficial
Create Table Oficial
(
	CodOficial nvarchar(15) primary key ,
	NombreOficial nvarchar (50) not null,
	ApellidoOficial nvarchar(50) not null,
	Direccion  nvarchar(300) not null,
	Telefono varchar(9) not  null,
	Idsexo int  not null,
	constraint Fk_Oficial_Sexo foreign key(IdSexo) 
	references Sexo(IdSexo),
)
	
--Relacion TipoUsuario
Create Table TipoUsuario
(
	IdTipoUsuario int primary key Identity ,
	Usuario nvarchar(30) not null,
)

--Relacion Socio
create table Socio
(
	CodSocio nvarchar(15) primary key,
	RTnSocio nvarchar(16) not null,
	NombreSocio nvarchar(30) not null,
	ApellidoSocio nvarchar(30) not null,
	Direccion nvarchar(300) not null,
	Nacionalidad nvarchar(40) not null,
	TelefonoCasa nvarchar(10) not null,
	TelefonoTrabajo nvarchar(10) not null,
	LugarTrabajo nvarchar(100) not null,
	Correo nvarchar(60) null,
	IdSexo int,
	constraint Fk_Socio_Sexo foreign key(IdSexo) 
	references Sexo(IdSexo),
	IdEstadoCivil int not null ,
	constraint Fk_Socio_EstadoCivil foreign key(IdEstadoCivil) 
	references EstadoCivil(IdEstadoCivil),
	IdNacionalidad int not null ,
	constraint Fk_Socio_Nacionalidad foreign key(IdNacionalidad) 
	references Nacionalidad(IdNacionalidad),
	IdProfesion int not null ,
	constraint Fk_Socio_Profesion foreign key(IdProfesion) 
	references Profesion(IdProfesion),
)

--Relacion Usuario
Create Table Usuario
(
	IdUsuario int primary key Identity ,
	UserName nvarchar(50) not null unique,
	Contraseña nvarchar(30) not null,
	IdEstado int ,
	constraint Fk_Usuario_Estado foreign key(IdEstado) 
	references Estado(IdEstado),
	CodOficial nvarchar(15) not null,
	constraint Fk_Usuario_Oficial foreign key(CodOficial) 
	references Oficial(CodOficial),
	IdTipoUsuario int ,
	constraint Fk_Usuario_TipoUsuario foreign key(IdTipoUsuario) 
	references TipoUsuario(IdTipoUsuario),
)

--Relacion CunetaBancaria
Create Table CuentaBancaria
(
	NumCuenta nvarchar(11) primary key ,
	SaldoActual numeric(10,2) not null,
	IdTipoCuenta int ,
	constraint Fk_CuentaBancaria_TipoCuenta foreign key(IdTipoCuenta) references TipoCuenta(IdTipoCuenta),
	CodSocio nvarchar(15)  not null,
	constraint Fk_CuentaBancaria_Socio foreign key(CodSocio) 
	references Socio(CodSocio),
	IdUsuario int  not null,
	constraint Fk_CuentaBancaria_Usuario foreign key(IdUsuario) 
	references Usuario(IdUsuario),
)



--Relacion AuditoriaLog
Create Table AuditoriaLog
(
	IdLog int primary key Identity,
	Actividad nvarchar(200) not null,
	Fecha date not null,
	IdUsuario int,
	constraint Fk_AuditoriaLog_Usuario foreign key(IdUsuario) references Usuario(IdUsuario),
)


--Relacion SolicitudPrestamo
Create table SolicitudPrestamo
(
	NumSolicitudPrestamo Nvarchar(11)  primary key,
	FechaSolicitud date not null,
	PlazoPago Numeric(10) not null,
	FechaExpiracion date null,
	SumaSolicitada numeric(10,2) not null,
	SumaEntregada numeric(10,2) not null,
	TasaInteres numeric(10,2) not null,
	FinalidadPrestamo nvarchar(300) not null,
	Estado nvarchar(30) not null,
	CodSocio nvarchar(15) not null,
	constraint Fk_SolicitudPrestamo_Socio foreign key(CodSocio) 
	references Socio(CodSocio),
	IdTipoPrestamo int not null,
	constraint Fk_SolicitudPrestamo_TipoPrestamo foreign key(IdTipoPrestamo) 
	references TipoPrestamo(IdTipoPrestamo),
	IdUsuario int  not null,
	constraint Fk_SolicitudPrestamo_Usuario foreign key(IdUsuario) 
	references Usuario(IdUsuario),
	
)

--Relacion SolicitudPrestamoAval
create table SolicitudPrestamoAval
(
	CodSocio nvarchar(15),
	constraint Fk_SolicitudPrestamoAval_Socio foreign key(CodSocio) 
	references Socio(CodSocio),
	NumSolicitudPrestamo nvarchar(11),
	constraint Fk_SolicitudPrestamoAval_SolicitudPrestamo foreign key(NumSolicitudPrestamo) 
	references SolicitudPrestamo(NumSolicitudPrestamo),
	Constraint Pk_Aval primary key(CodSocio,NumSolicitudPrestamo),	
)

--Relacion EstadoPrestamo
Create table EstadoPrestamo
(
	NumSolicitudPrestamo nvarchar(11),
	Estado nvarchar(30) not null,
	constraint Fk_EstadoPrestamo_SolicitudPrestamo foreign key(NumSolicitudPrestamo) 
	references SolicitudPrestamo(NumSolicitudPrestamo),
)





--Procedimientos almacenados de tipoprestamo
create procedure Sp_MostrarTipoPrestamo1
as 
	begin 
		set nocount on
		select * from TipoPrestamo
end 

create Procedure Sp_InsertarTipoPrestamo1
@TipoPrestamo nvarchar(40)
as 
	begin
		set nocount on
		insert into TipoPrestamo values(@TipoPrestamo)
end 

create procedure Sp_ActualizarTipoPrestamo1
@IdTipoPrestamo int , @TipoPrestamo nvarchar(40)
as 
	begin 
	set nocount on
	update TipoPrestamo set TipoPrestamo=@TipoPrestamo where IdTipoPrestamo=@IdTipoPrestamo
end 

create procedure Sp_EliminarTipoPrestamo
@IdTipoPrestamo int
as 
	begin 
	set nocount on
	delete from Tipoprestamo where idtipoprestamo=@IdTipoPrestamo
end 

create Procedure Sp_MostrarTipoPrestamoIdentity
as
	begin 
	set nocount on
		select max(IdTipoPrestamo) +1 AS Id from TipoPrestamo
End

create  procedure Sp_ExisteTipoPrestamo
@TipoPrestamo nvarchar(40)
as
	Begin 
		set nocount on
		select count(*) from TipoPrestamo where TipoPrestamo=@TipoPrestamo
End


--Procedimientos almacenados de Nacionalidad

create procedure Sp_MostrarNacionalidad
as 
	begin 
		set nocount on
		select * from Nacionalidad
end 

create Procedure Sp_InsertarNacionalidad
@Nacionalidad nvarchar(40)
as 
	begin
		set nocount on
		insert into Nacionalidad values(@Nacionalidad)
end 

create procedure Sp_ActualizarNacionalidad
@IdNacionalidad int , @Nacionalidad nvarchar(40)
as 
	begin 
	set nocount on
	update Nacionalidad set Nacionalidad=@Nacionalidad where IdNacionalidad=@IdNacionalidad
end 

create procedure Sp_EliminarNacionalidad
@IdNacionalidad int
as 
	begin 
	set nocount on
	delete from Nacionalidad where idNacionalidad=@IdNacionalidad
end 

create Procedure Sp_MostrarNacionalidadIdentity
as
	begin 
	set nocount on
		select max(IdNacionalidad) +1 AS Id from Nacionalidad
End

create  procedure Sp_ExisteNacionalidad
@Nacionalidad nvarchar(40)
as
	Begin 
		set nocount on
		select count(*) from Nacionalidad where Nacionalidad=@Nacionalidad
End

select * from Nacionalidad


--Procedimientos almacenados de TipoCuenta
create procedure Sp_MostrarTipoCuenta
as 
	begin 
		set nocount on
		select * from TipoCuenta
end 

create Procedure Sp_InsertarTipoCuenta
@TipoCuenta nvarchar(30),@DescripcionCuenta nvarchar(200)
as 
	begin
		set nocount on
		insert into TipoCuenta values(@TipoCuenta,@DescripcionCuenta)
end 

create procedure Sp_ActualizarTipoCuenta
@IdTipoCuenta int , @TipoCuenta nvarchar(30),@DescripcionCuenta nvarchar(200)
as 
	begin 
	set nocount on
	update TipoCuenta set TipoCuenta=@TipoCuenta,DescripcionCuenta=@DescripcionCuenta where IdTipoCuenta=@IdTipoCuenta
end 

create procedure Sp_EliminarTipoCuenta
@IdTipoCuenta int
as 
	begin 
	set nocount on
	delete from TipoCuenta where idTipoCuenta=@IdTipoCuenta
end 

create Procedure Sp_MostrarTipoCuentaIdentity
as
	begin 
	set nocount on
		select max(IdTipoCuenta) +1 AS Id from TipoCuenta
End

create  procedure Sp_ExisteTipoCuenta
@TipoCuenta nvarchar(30)
as
	Begin 
		set nocount on
		select count(*) from TipoCuenta where TipoCuenta=@TipoCuenta
End


--Procedimientos almacenados de Profesion
create procedure Sp_MostrarProfesion
as 
	begin 
		set nocount on
		select * from Profesion
end 

create Procedure Sp_InsertarProfesion
@Profesion nvarchar(40)
as 
	begin
		set nocount on
		insert into Profesion values(@Profesion)
end 

create procedure Sp_ActualizarProfesion2
@IdProfesion int , @Profesion nvarchar(40)
as 
	begin 
	set nocount on
	update Profesion set Profesion=@Profesion where IdProfesion=@IdProfesion
end 

create procedure Sp_EliminarProfesion
@IdProfesion int
as 
	begin 
	set nocount on
	delete from Profesion where idProfesion=@IdProfesion
end 

create Procedure Sp_MostrarProfesionIdentity
as
	begin 
	set nocount on
		select max(IdProfesion) +1 AS Id from Profesion
End

create  procedure Sp_ExisteProfesion
@Profesion nvarchar(40)
as
	Begin 
		set nocount on
		select count(*) from Profesion where Profesion=@Profesion
End


--Procedimientos almacenados de la relacion de cuentabancaria

alter procedure Sp_LLenarComboTipoCuenta
as
	Begin
	Set nocount on 
		select *
		from TipoCuenta
		order by IdTipoCuenta Asc
End

create procedure Sp_LLenarComboSocio
as
	Begin
	Set nocount on 
		select CodSocio
		from Socio
		order by CodSocio Asc
End


Alter procedure Sp_MostrarCuentaBancaria
as 
	begin 
		set nocount on
		select a.NumCuenta,a.SaldoActual,b.TipoCuenta,c.CodSocio,c.Nombresocio
		from CuentaBancaria a inner join TipoCuenta b on a.IdTipoCuenta=b.IdTipoCuenta
							  inner join Socio c on a.codsocio=c.codsocio
end 

alter Procedure Sp_InsertarCuentaBancaria
@NumCuenta nvarchar(11) , @SaldoActual numeric(10,2) , @IdTipoCuenta int  , @CodSocio nvarchar(15), @IdUsuario int
as 
	begin
		set nocount on
		insert into CuentaBancaria values(@NumCuenta , @SaldoActual, @IdTipoCuenta , @CodSocio,@IdUsuario)
end 



alter procedure Sp_ActualizarCuentaBancaria
@NumCuenta nvarchar(11) , @SaldoActual numeric(10,2) , @IdTipoCuenta int  , @CodSocio nvarchar(15), @IdUsuario int
as 
	begin 
	set nocount on
	update CuentaBancaria set SaldoActual=@SaldoActual,IdTipoCuenta=@IdTipoCuenta,CodSocio=@CodSocio,IdUsuario=@IdUsuario  where NumCuenta=@NumCuenta
end 

alter procedure Sp_EliminarCuentaBancaria
@NumCuenta nvarchar(11)
as 
	begin 
	set nocount on
	delete from CuentaBancaria where NumCuenta=@NumCuenta
end 


-- Insercion Sexo
Insert into Sexo(Sexo)
values ('Masculino'),
	   ('Femenino')

-- Insercion Estado
Insert into Estado(Estado)
values ('Activo'),
	   ('Desactivo')

-- Insercion TipoUsuario
Insert into TipoUsuario(Usuario)
values ('SuperUsuario'),
	   ('Usuario'),
	   ('Usuario Normal'),
	   ('Usuario Administrador')

select * from sexo
select * from oficial
select * from Usuario
select * from estado

insert into oficial values ('1709-1997-01153','walter','cruz','b° la cruz',87876247,1)
select * from Usuario
insert into Usuario values('WalterCruz','Walter100',1,'1709-1997-01153',1)

alter  procedure Sp_ExisteCuentaBancaria
@NumCuenta nvarchar(11)
as
	Begin 
		set nocount on
		select count(*) from CuentaBancaria where NumCuenta=@NumCuenta
End

-- Insercion EstadoCivil
Insert into EstadoCivil(EstadoCivil)
values ('Casado(a)'),
	   ('Soltero(a)'),
	   ('Union libre'),
	   ('viudo(a)')
select * from CuentaBancaria
select * from sexo
select * from estadocivil
select * from nacionalidad
select * from profesion
select * from socio
select * from usuario
insert into socio values ('1709-1997-01153','1709-1997-011531','ricardo','cruz','b° la cruz','99898989','99895566','san lorenzo','walteraca972',1,1,5,2)

create Procedure Sp_BuscarSocioXNombre
@NombreSocio nvarchar(30)
As
	Begin
	Set nocount on
	Select a.numcuenta,a.saldoactual,c.tipocuenta,b.codsocio,b.nombresocio,b.apellidoSocio
	From Cuentabancaria a inner join socio b on a.codsocio =b.codsocio 
	                      inner join tipocuenta c on a.idtipocuenta=c.idtipocuenta
	Where NombreSocio= @NombreSocio
End
create Procedure Sp_MostrarCuentaBusqueda
As
	Begin
	Set nocount on
	Select a.numcuenta,a.saldoactual,c.tipocuenta,b.codsocio,b.nombresocio,b.apellidoSocio
	From Cuentabancaria a inner join socio b on a.codsocio =b.codsocio 
	                      inner join tipocuenta c on a.idtipocuenta=c.idtipocuenta
End
Create Procedure Sp_BuscarCuentaBancariaXId
@NumCuenta nvarchar(11)
As
	Begin
	Set nocount on
	Select a.numcuenta,a.saldoactual,c.tipocuenta,b.codsocio,b.nombresocio,b.apellidoSocio
	From Cuentabancaria a inner join socio b on a.codsocio =b.codsocio 
	                      inner join tipocuenta c on a.idtipocuenta=c.idtipocuenta
	Where NumCuenta= @NumCuenta
End

-- procedimientos almacenados de la relacion de solicitud prestamo aval
alter procedure  Sp_LLenarComboSocioA
as
	Begin
	Set nocount on 
		select CodSocio
		from Socio
		order by CodSocio Asc
End
select * from solicitudPrestamoaval
select * from socio
select * from tipoprestamo
select * from usuario
insert into solicitudprestamo values (1234567822,'11-11-1999',10,'11-12-2000',12000,10000,0.15,'no hay pisto','1709-1997-01153',9,1)

create  procedure  Sp_LLenarComboSolicitudPrestamo
as
	Begin
	Set nocount on 
		select NumSolicitudPrestamo
		from SolicitudPrestamo
		order by NumSolicitudPrestamo Asc
End

create procedure Sp_MostrarTodoSolicitudAval
as
	Begin 
	set nocount on
		Select a.CodSocio,a.NombreSocio,B.NumSolicitudPrestamo
		from socio a inner join SolicitudPrestamoAval b on a.Codsocio=b.Codsocio
End

create procedure Sp_InsertarSolicitudAval
@CodSocio nvarchar(15), @NumSolicitudPrestamo nvarchar(11)
as
	Begin 
		Set nocount on 
		Insert into SolicitudPrestamoAval
		values(@CodSocio, @NumSolicitudPrestamo)
End

alter procedure Sp_ActualizarSolicitudAval
@CodSocio nvarchar(15), @NumSolicitudPrestamo nvarchar(11)
as	
	Begin 
		Set nocount on 
		Update SolicitudPrestamoAval
		set CodSocio=@CodSocio, NumSolicitudPrestamo=@NumSolicitudPrestamo
		where NumSolicitudPrestamo=@NumSolicitudPrestamo
End

create procedure Sp_EliminarSolicitudAval
@NumSolicitudPrestamo nvarchar(11)
As
	Begin 
		Set nocount on
		Delete from SolicitudPrestamoAval  where NumSolicitudPrestamo=@NumSolicitudPrestamo
End

Create  Procedure SP_ExisteSolicitudAval
@CodSocio nvarchar(15),
@NumPrestamo nvarchar(11)
as
	begin 
		set nocount on
		select count(*) from SolicitudPrestamoAval
		where CodSocio  = @CodSocio and NumSolicitudPrestamo=@NumPrestamo
End

--Porcedimientos almacenado de la busqueda de solicitud prestamo aval

alter procedure Sp_MostrarxCodSocio
@CodSocio nvarchar(15)
as 
	Begin
		Set nocount on 
		Select a.CodSocio,a.NombreSocio,a.ApellidoSocio,B.NumSolicitudPrestamo
		from socio a inner join SolicitudPrestamoAval b on a.Codsocio=b.Codsocio
		Where a.CodSocio=@CodSocio
End

alter procedure Sp_MostrarxNumSolicitudPrestamo
@NumSolicitudPrestamo nvarchar(11)
as 
	Begin
		Set nocount on 
		Select a.CodSocio,a.NombreSocio,a.ApellidoSocio,B.NumSolicitudPrestamo
		from socio a inner join SolicitudPrestamoAval b on a.Codsocio=b.Codsocio
		Where b.NumSolicitudPrestamo=@NumSolicitudPrestamo
End


create procedure Sp_ExisteSolicitudNumSolicitudPA
@NumSolicitudPrestamo nvarchar(11)
as
	Begin
		Set nocount on 
		Select count(*) from SolicitudPrestamoAval where NumSolicitudPrestamo=@NumSolicitudPrestamo
End

Create  procedure  Sp_ExisteSolicitudCodSocio
@CodSocio nvarchar(15)
as
	Begin 
		set nocount on
		select count(*) from SolicitudPrestamo where CodSocio  =@CodSocio 
End

create Procedure Sp_MostrarSolicitudAvalBusqueda
As
	Begin
	Set nocount on
	Select a.CodSocio,a.NombreSocio,a.ApellidoSocio,B.NumSolicitudPrestamo
	from socio a inner join SolicitudPrestamoAval b on a.Codsocio=b.Codsocio
End

--Procedimientos almacenados de la relacion Socio

 Create Procedure Sp_MostrarSocio
 as
 begin
	Set nocount on 
		select S.CodSocio,S.RTnSocio,S.NombreSocio,S.ApellidoSocio,S.Direccion,S.TelefonoCasa,S.TelefonoTrabajo,S.LugarTrabajo,S.Correo,SE.Sexo,E.Estado,N.Nacionalidad,P.Profesion
		from Socio S INNER JOIN Sexo Se on S.IdSexo=se.IdSexo INNER JOIN Estado E ON S.IdEstadoCivil=E.IdEstado INNER JOIN Nacionalidad N
		ON S.IdNacionalidad = N.IdNacionalidad INNER JOIN Profesion P ON S.IdProfesion=P.IdProfesion
 End

Create Procedure Sp_BuscarSocio
@Socio nvarchar(30)
 as
 begin
 Set nocount on 
 select S.CodSocio,S.RTnSocio,S.NombreSocio,S.ApellidoSocio,S.Direccion,S.TelefonoCasa,S.TelefonoTrabajo,S.LugarTrabajo,S.Correo,SE.Sexo,E.Estado,N.Nacionalidad,P.Profesion
 from Socio S INNER JOIN Sexo Se on S.IdSexo=se.IdSexo INNER JOIN Estado E ON S.IdEstadoCivil=E.IdEstado INNER JOIN Nacionalidad N
 ON S.IdNacionalidad = N.IdNacionalidad INNER JOIN Profesion P ON S.IdProfesion=P.IdProfesion
 where S.NombreSocio + ' ' + S.ApellidoSocio  Like @Socio + '%' or S.CodSocio Like @Socio + '%' or S.RTnSocio Like @Socio +'%'
 End

 insert into Socio values('0234-34567-12h3','0601-1998-01841','Nixon','Sanches','Col Colinas','8763-3456','2782-1311','Mall','Nixon@gmail.com',1,1,5,2)
 select*from Socio


Create Procedure Sp_InsertarSocio 
@CodSocio nvarchar(15),@RTnSocio nvarchar(16),@NombreSocio nvarchar(30),@ApellidoSocio nvarchar(30),@Direccion nvarchar(300),@TelefonoCasa nvarchar(10),
@TelefonoTrabajo nvarchar(10),@LugarTrabajo nvarchar(100),@Correo nvarchar(60),@IdSexo int ,@IdEstado int , @IdNacionalidad int , @IdProfecional int
 as
 begin
 Set nocount on 
  insert into Socio values(@CodSocio,@RTnSocio,@NombreSocio,@ApellidoSocio,@Direccion,@TelefonoCasa,@TelefonoTrabajo,@LugarTrabajo,@Correo,@IdSexo,@IdEstado,@IdNacionalidad,@IdProfecional)
 End

 exec Sp_InsertarSocio '1234-34567-12h3','0404-1998-01841','David','Sanches','Col Colinas','8763-3456','2782-1311','Mall','Dixon@gmail.com',1,1,8,2


 Create Procedure Sp_LLenarComboSexo
as
	Begin
	Set nocount on 
		select IdSexo, Sexo
		from Sexo
		order by Sexo Asc
End


 Create Procedure Sp_LLenarComboEstado
as
	Begin
	Set nocount on 
		select IdEstado, Estado
		from Estado
		order by Estado Asc
End

 Create Procedure Sp_LLenarComboNacionalidad
as
	Begin
	Set nocount on 
		select IdNacionalidad, Nacionalidad
		from Nacionalidad
		order by Nacionalidad Asc
End


 Create Procedure Sp_LLenarComboProfesion
as
	Begin
	Set nocount on 
		select IdProfesion, Profesion
		from Profesion
		order by Profesion Asc
End





Create Procedure Sp_EliminarSocio
@CodSocio nvarchar(15)
as
	Begin
	Set nocount on 
	delete Socio where CodSocio=@CodSocio
End
drop procedure Sp_ActualizarSocio
Create Procedure Sp_ActualizarSocio
@CodSocio nvarchar(15),@RTnSocio nvarchar(16),@NombreSocio nvarchar(30),@ApellidoSocio nvarchar(30),@Direccion nvarchar(300),@TelefonoCasa nvarchar(10),
@TelefonoTrabajo nvarchar(10),@LugarTrabajo nvarchar(100),@Correo nvarchar(60),@IdSexo int ,@IdEstado int , @IdNacionalidad int , @IdProfecional int
 as
 begin
 Set nocount on 
  update Socio set RTnSocio=@RTnSocio, NombreSocio= @NombreSocio, ApellidoSocio= @ApellidoSocio,Direccion= @Direccion,
  TelefonoCasa= @TelefonoCasa,  TelefonoTrabajo= @TelefonoTrabajo,LugarTrabajo=@LugarTrabajo,Correo=@Correo,IdSexo= @IdSexo,IdEstadoCivil=@IdEstado,
  IdNacionalidad= @IdNacionalidad,IdProfesion= @IdProfecional where CodSocio=@CodSocio
 End

 --Solicitud Prestamo

create procedure Sp_LlenarComboTipoPrestamo
as
	Begin
	Set nocount on 
		select IdTipoPrestamo, TipoPrestamo
		from TipoPrestamo
		order by TipoPrestamo Asc
End
Select * From SolicitudPrestamo
Select * From CuentaBancaria

Create Procedure Sp_MostrarCuentas
@CodSocio nvarchar(15)
As 
	Begin
	Set nocount on
	Select C.NumCuenta, TC.TipoCuenta, TC.DescripcionCuenta, C.SaldoActual
	From CuentaBancaria C inner join TipoCuenta TC on C.IdTipoCuenta=TC.IdTipoCuenta
	Where C.CodSocio = @CodSocio
End

create Procedure Sp_InsertarPrestamo
@NumPrestamo nvarchar(11),
@FechaSolicitud date,
@PlazoPago numeric(10,0),
@FechaExpiracion date,
@SumaSolicitada numeric(10,2),
@SumaEntregada numeric(10,2),
@TasaInteres numeric(10,2),
@FinalidadPrestamo nvarchar(300),
@CodSocio nvarchar(15),
@IdTipoPrestamo int,
@IdUsuario int
As
	Begin
	Set nocount on
	Insert into SolicitudPrestamo values(@NumPrestamo,@FechaSolicitud,@PlazoPago,@FechaExpiracion,@SumaSolicitada,@SumaEntregada,@TasaInteres,@FinalidadPrestamo,@CodSocio,@IdTipoPrestamo,@IdUsuario)
End

create Procedure Sp_ActualizarPrestamo
@NumPrestamo nvarchar(11),
@FechaSolicitud date,
@PlazoPago numeric(10,0),
@FechaExpiracion date,
@SumaSolicitada numeric(10,2),
@SumaEntregada numeric(10,2),
@TasaInteres numeric(10,2),
@FinalidadPrestamo nvarchar(300),
@CodSocio nvarchar(15),
@IdTipoPrestamo int,
@IdUsuario int
As
	Begin
	Set nocount on
	Update SolicitudPrestamo Set FechaSolicitud=@FechaSolicitud, PlazoPago=@PlazoPago, FechaExpiracion=@FechaExpiracion, SumaSolicitada=@SumaSolicitada, SumaEntregada=@SumaEntregada, TasaInteres=@TasaInteres, FinalidadPrestamo=@FinalidadPrestamo, CodSocio=@CodSocio, IdTipoPrestamo=@IdTipoPrestamo, IdUsuario=IdUsuario
	Where NumSolicitudPrestamo=@NumPrestamo
End

Create Procedure Sp_MostrarPrestamo
As
	Begin
	Set nocount on
	Select SP.NumSolicitudPrestamo, SP.FechaSolicitud, TP.TipoPrestamo, SP.CodSocio, S.NombreSocio, S.RTnSocio, N.Nacionalidad, EC.EstadoCivil, S.Direccion, SP.SumaSolicitada, SP.SumaEntregada, SP.PlazoPago, SP.TasaInteres, SP.FinalidadPrestamo, SP.FechaExpiracion
	From SolicitudPrestamo SP inner join TipoPrestamo TP on SP.IdTipoPrestamo= TP.IdTipoPrestamo
							  inner join Socio S on SP.CodSocio = S.CodSocio
							  inner join EstadoCivil EC on S.IdEstadoCivil= EC.IdEstadoCivil
							  inner join Nacionalidad N on S.IdNacionalidad = N.IdNacionalidad
End
--Relacion EstadoPrestamo

Create Procedure Sp_InsertEstadoPrestamo
@NumSolicitudPrestamo nvarchar(11),
@Estado nvarchar(30)
As
	Begin
	Set nocount on
	Insert into EstadoPrestamo Values(@NumSolicitudPrestamo,@Estado)
End

Create Procedure Sp_ActualizarEstadoPrestamo
@NumPrestamo nvarchar(11),
@Estado nvarchar(30)
As
	Begin
	Update EstadoPrestamo Set Estado=@Estado Where NumSolicitudPrestamo=@NumPrestamo
End

Create procedure Sp_ContarAvales
@NumeroPrestamo nvarchar(11)
as
	begin
	Select count(CodSocio) as 'Cantidad de Avales'
	From SolicitudPrestamoAval
	Where NumSolicitudPrestamo = @NumeroPrestamo
end


