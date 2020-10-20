create table Empresas (
codigo int primary key identity(1, 1),
cnpj varchar(20) not null,
empresa varchar(30) not null,
increstadual varchar(30) not null,
endereco varchar(20) not null,
numero varchar(5) not null,
bairro varchar(20) not null,
cep varchar(12) not null,
telefone1 varchar(15) not null,
telefone2 varchar(15) not null,
email varchar(50) not null
)

create table Usuarios(
	codigo int primary key identity (1,1),
	nomecompleto varchar(20) not null, 
	nomeacesso varchar(15) not null,
	senha varchar(13) not null,
	nivel varchar(10) not null,
	empresa varchar(30) not null,
	departamento varchar(30) not null
);


select UPPER(u.nomeacesso) testupper, LEN(u.nomeacesso) qtyletra, u.* from Usuarios u