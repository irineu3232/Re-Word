create database Re_World;

-- Usando a database
use Re_World;


-- Criando as tabelas

Create table Usuarios(
Id int auto_increment primary key,
Nome varchar(200) not null,
Email varchar(200) not null,
Senha varchar(200) not null
);

create  table Produtos(
Id int primary  key auto_increment not null,
Nome varchar(200) not null,
Descricao varchar(200) not null,
Preco decimal(10,2) not null,
Quantidade int not null
);

insert into Usuarios(Nome, Email, Senha)
			values('Admin','admin@admin','12345678');