DROP TABLE [VENDAS]
DROP TABLE [PRODUTOS]
DROP TABLE [CLIENTES]
CREATE TABLE [PRODUTOS] (
[CODIGO] [int] IDENTITY (1, 1) NOT NULL ,
[NOME] [varchar] (100) ,
[PRECO] decimal(10,2) ,
[ESTOQUE] [int] ,
CONSTRAINT [PK_PRODUTOS] PRIMARY KEY CLUSTERED
(
[CODIGO]
) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [CLIENTES] (
[CODIGO] [int] IDENTITY (1, 1) NOT NULL ,
[NOME] [varchar] (100) ,
[EMAIL] [varchar] (100) ,
[TELEFONE] [varchar] (80) ,
CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED
(
[CODIGO]
) ON [PRIMARY]
) ON [PRIMARY]
GO
insert into clientes(nome,email,telefone)
values ('Carlos Camacho','c_olavo@hotmail.com','(11) 9999-5555')
select * from CLIENTES
insert into produtos (nome, preco, estoque)
values ('Computador Pentium Dual Core','1500.00','15')
insert into produtos (nome, preco, estoque)
values ('Impressora Deskjet HP','599.90','150')
select * from PRODUTOS
CREATE TABLE [VENDAS] (
[CODIGO] [int] IDENTITY (1, 1) NOT NULL ,
[DATA] [datetime],
[QUANTIDADE] [int],
[FATURADO] bit,
[CODIGOCLIENTE] [int],
[CODIGOPRODUTO] [int],
CONSTRAINT [PK_VENDAS] PRIMARY KEY CLUSTERED
(
[CODIGO]
) ON [PRIMARY],
CONSTRAINT [FK_Codigo_Cliente] FOREIGN KEY
(
[CODIGOCLIENTE]
) REFERENCES [Clientes] (
[Codigo]
),
CONSTRAINT [FK_Codigo_Produto] FOREIGN KEY
(
[CODIGOPRODUTO]
) REFERENCES [Produtos] (
[Codigo]
)
) ON [PRIMARY]
GO
