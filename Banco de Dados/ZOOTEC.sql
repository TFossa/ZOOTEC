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
CodigoEstado int foreign key
references Estado (CodigoEstado),
CodigoCidade int foreign key
references Cidade (CodigoCidade)
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
Salario DECIMAL (9,2),
CEP NVARCHAR (15),
CodigoLogradouro int foreign key
references Logradouro(CodigoLogradouro), 
Usuario NVARCHAR (50),
Senha NVARCHAR (50),
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
 CodigoAnimal int not null primary key identity (1,1),
 Apelido NVARCHAR (50),
 NumeroDeAnilha NVARCHAR (50),
 Descricao NVARCHAR (200),
 idade NVARCHAR (50),
 RelatorioClinico NVARCHAR (500),
 Classificacao NVARCHAR (50),
 Medicamentos int foreign key
 references Medicamento (CodigoMedicamento),
 Alimentos int foreign key
 references Alimento (CodigoAlimento)
 )  
 
 -------------------Criando a tabela Recado(em construção)-----------------------------
    create table Recado
  (
  CodigoRecado int not null primary key identity (1,1),
  Tipo NVARCHAR (50),
  CodigoFuncionario int foreign key
  references Funcionario (CodigoFuncionario),
  CodigoFuncao int foreign key
  references Funcao (CodigoFuncao),
  Data date,
  Mensagem NVARCHAR (250),
  Destinatario NVARCHAR (50)
  )