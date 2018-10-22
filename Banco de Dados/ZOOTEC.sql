--criando e conectando o banco de dados
create database ZOOTEC
use ZOOTEC

----------------------Criando as tabelas de Localizacao do funcionário-------------------------
  
create table Estado
(
CodigoEstado int primary key identity (1,1),
NomeEstado NVARCHAR (50),
SiglaEstado NVARCHAR (2)
)

create table Cidade
(
CodigoCidade int primary key identity (1,1),
NomeCidade NVARCHAR (50),
CodigoEstado int foreign key
references Estado(CodigoEstado)
)



create table Logradouro
(
CodigoLogradouro int not null primary key identity (1,1),
CEP NVARCHAR (25),
CodigoCidade int foreign key
references Cidade (CodigoCidade)
)

create table Especies
(
CodigoEspecies int not null primary key identity (1,1),
Descricao NVARCHAR (25)
)

select * from Estado 
select * from Cidade 
select * from Logradouro 

----------------------Criando as tabelas funcionario e etc-------------------------

create table Funcao
(
CodigoFuncao int primary key identity (1,1),
NomeFuncao NVARCHAR (50)
)

--Insert dos tipos de funcionario
Insert into Funcao(NomeFuncao)
values ('Administrador')
Insert into Funcao(NomeFuncao)
values ('Veterinário')
Insert into Funcao(NomeFuncao)
values ('Funcionário')

Select * from Funcao

create table Funcionario
(
CodigoFuncionario int not null primary key identity (1,1),
NomeFuncionario NVARCHAR (50),
RG NVARCHAR (25),
CPF NVARCHAR (25),
Endereco NVARCHAR (50),
Bairro NVARCHAR (50),
CodigoFuncao int foreign key
references Funcao (CodigoFuncao),
Salario NVARCHAR(50) ,
CodigoLogradouro int foreign key
references Logradouro(CodigoLogradouro), 
Usuario NVARCHAR (50),
Senha NVARCHAR (50),
)

select * from Funcao  

create table Recado
(
CodigoRecado int not null primary key identity (1,1),
CodigoFuncionario int foreign key
references Funcionario (CodigoFuncionario),
Mensagem NVARCHAR (250),
Destinatario NVARCHAR (50)
)

create table EmailFuncionario
(
CodigoEmailFuncionario int not null primary key identity (1,1),
Email NVARCHAR (50),
CodigoFuncionario int foreign key
references Funcionario (CodigoFuncionario)
)
  
create table TelefoneFuncionario
(
CodigoTelefoneFuncionario int not null primary key identity (1,1),
Telefone NVARCHAR (50),
CodigoFuncionario int foreign key
references Funcionario (CodigoFuncionario)
) 

Select * from EmailFuncionario 
Select * from TelefoneFuncionario 

  ----------------------Criando a  tabela Medicamento-------------------------      
    
 Create Table Medicamento
 (
 CodigoMedicamento int not null primary key identity (1,1),
 NomeMedicamento NVARCHAR (50),
 Quantidade NVARCHAR (50),
 EstoqueMinimo NVARCHAR(50),
 EstoqueMaximo NVARCHAR(50),
 Categoria VARCHAR (50)
 )  

    ----------------------Criando a  tabela Alimento-------------------------        
 Create Table Alimento
 (
 CodigoAlimento int not null primary key identity (1,1),
 NomeAlimentos NVARCHAR (50),
 Quantidade NVARCHAR (50),
 EstoqueMinimo NVARCHAR(50),
 EstoqueMaximo NVARCHAR(50),
 Categoria VARCHAR (50)
 )
 
 
 ----------------------Criando a  tabela Animal-------------------------        
 Create Table Animal
 (
 CodigoCadastroAnimal int not null primary key identity (1,1),
 NomeAnimal NVARCHAR (50),
 DescricaoAnimal NVARCHAR (50),
 DataDeNascimentoAnimal NVARCHAR (200),
 PesoAnimal NVARCHAR (50),
 AlturaAnimal NVARCHAR (500),
 GeneroAnimal NVARCHAR (50),
 PorteAnimal NVARCHAR (50),
 CodigoEspecies int foreign key references Especies (CodigoEspecies)
 ) 


