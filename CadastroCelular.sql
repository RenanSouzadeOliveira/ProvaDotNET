use master;

drop database CadastroCelular;

create database CadastroCelular;
use CadastroCelular

create table Cliente(
idCliente int primary key identity(1,1),
nomeCliente nvarchar (40),
cpfCliente  nvarchar (15),
rgCliente   nvarchar (12),
celCliente	nvarchar (11),
telCliente	nvarchar (12),
enderecoCliente nvarchar (60)
);

select * from Cliente;

create table Celular(
idCelular int primary key identity(1,1),
cpfCliente	nvarchar(15),
macACelular	nvarchar (17),
marca		nvarchar (20),
modelo		nvarchar (25)
);

select * from Celular;

select c.idCliente as IdCliente,
       c.nomeCliente as nomeCliente,
       c.cpfCliente as cpfClientetbCliente,
       v.cpfCliente as cpfClientetbCelular,
       v.idCelular as idCelular,
       v.marca as marcaCelular,
       v.modelo as modeloCelular
       from
       Cliente c
       left join Celular v on c.cpfCliente = v.cpfCliente


/*SELECT Cliente.idCliente,Cliente.nomeCliente,Celular.idCelular, Celular.macACelular, Celular.marca, Celular.modelo
FROM Cliente
INNER JOIN Celular ON Cliente.idCliente = Celular.idCelular;*/
