create database ReWorld;
-- Usando a database
use ReWorld;

-- Criando as tabelas
Create table Usuario(
Id int auto_increment primary key,
Nome varchar(200) not null,
Email varchar(200) not null,
Senha varchar(200) not null
);
create  table Produto(
Id int primary  key auto_increment not null,
Nome varchar(200) not null,
Descricao varchar(200) not null,
Preco decimal(10,2) not null,
Quantidade int not null
);

insert into Usuario(Nome, Email, Senha)
			values('Admin','admin@admin','1234');
            
select*from Usuario;            
            