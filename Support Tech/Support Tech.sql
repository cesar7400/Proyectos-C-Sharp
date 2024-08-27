create database tickets

use tickets

create table personal(
id int identity (1,1) primary key not null,
nombre varchar(50) not null,
apellidos varchar(50) not null,
especialidad varchar(50) not null,
fechaIngreso date not null,
horario varchar(50) not null,
documento varchar(20) not null,
mail  varchar(100) not null,
whatsapp  varchar(20) not null,
estado int not null
)

create table usuarios(
id int identity (1,1) primary key not null,
login varchar (100) not null,
pass varchar(max) not null,
nivel varchar(50) not null,
estado varchar(10) not null,
idPersonal int not null,
foreign key (idPersonal) REFERENCES personal(id)
)

create table areas(
id int identity (1,1) primary key not null,
descripcion varchar(100) not null
)

create table ticket(
id int identity (1,1) primary key not null,
idArea int not null,
departamento varchar(100) not null,
asunto varchar(50) null,
descripcion varchar(max) not null,
prioridad varchar(50) not null,
puesto varchar(50) null,
nivel varchar(30) not null,
whastapp varchar(20) not null,
fecha datetime  not null,
comentarios varchar(max) null,
sucursal varchar(50) null,
idUsuario int  not null,
foreign key (idUsuario) REFERENCES usuarios(id),
foreign key (idArea) REFERENCES areas(id)
)

create table seguimientos(
id int identity (1,1) primary key not null,
idTicket int not null,
idPersonal int not null,
seguimiento varchar(max) not null,
estado varchar(30) not null,
foreign key (idTicket) REFERENCES ticket(id),
foreign key (idPersonal) REFERENCES personal(id),
)


insert into personal (nombre, apellidos, especialidad, fechaIngreso, horario, documento, mail, whatsapp, estado) values('andres','gomez lopez','docente','1995-11-20','8 am - 5 pm','323510255','admin@mail.com','+573216549870','1');
insert into usuarios (login, pass, nivel, estado, idPersonal) values ('admin','0U+8VOAro70=','Administrador','1','1');
insert into areas(descripcion) values('administración'),('nomina');

/*
login: admin
contraseña:123456
*/