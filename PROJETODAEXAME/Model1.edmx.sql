
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/08/2022 08:03:39
-- Generated from EDMX file: C:\Users\leomi\OneDrive\Ambiente de Trabalho\PROJETODAEXAME\PROJETODAEXAME\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RestGest2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PedidoCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_PedidoCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_TrabalhadorRestaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Trabalhador] DROP CONSTRAINT [FK_TrabalhadorRestaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoTrabalhador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_PedidoTrabalhador];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuRestaurante_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuRestaurante] DROP CONSTRAINT [FK_ItemMenuRestaurante_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuRestaurante_Restaurante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuRestaurante] DROP CONSTRAINT [FK_ItemMenuRestaurante_Restaurante];
GO
IF OBJECT_ID(N'[dbo].[FK_ItemMenuCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemMenuSet] DROP CONSTRAINT [FK_ItemMenuCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoItemMenu_Pedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoItemMenu] DROP CONSTRAINT [FK_PedidoItemMenu_Pedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoItemMenu_ItemMenu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoItemMenu] DROP CONSTRAINT [FK_PedidoItemMenu_ItemMenu];
GO
IF OBJECT_ID(N'[dbo].[FK_PedidoEstado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidoSet] DROP CONSTRAINT [FK_PedidoEstado];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoPedido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagamentoSet] DROP CONSTRAINT [FK_PagamentoPedido];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoMetodoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagamentoSet] DROP CONSTRAINT [FK_PagamentoMetodoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_RestauranteMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RestauranteSet] DROP CONSTRAINT [FK_RestauranteMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet] DROP CONSTRAINT [FK_PessoaMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_CodigoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PagamentoSet] DROP CONSTRAINT [FK_CodigoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RestauranteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RestauranteSet];
GO
IF OBJECT_ID(N'[dbo].[PedidoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidoSet];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuSet];
GO
IF OBJECT_ID(N'[dbo].[CategoriaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoriaSet];
GO
IF OBJECT_ID(N'[dbo].[EstadoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoSet];
GO
IF OBJECT_ID(N'[dbo].[PagamentoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PagamentoSet];
GO
IF OBJECT_ID(N'[dbo].[MoradaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MoradaSet];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet];
GO
IF OBJECT_ID(N'[dbo].[MetodoPagamentoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MetodoPagamentoSet];
GO
IF OBJECT_ID(N'[dbo].[CodigoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CodigoSet];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Cliente];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Trabalhador];
GO
IF OBJECT_ID(N'[dbo].[ItemMenuRestaurante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemMenuRestaurante];
GO
IF OBJECT_ID(N'[dbo].[PedidoItemMenu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidoItemMenu];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RestauranteSet'
CREATE TABLE [dbo].[RestauranteSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'PedidoSet'
CREATE TABLE [dbo].[PedidoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ValorTotal] decimal(18,0)  NOT NULL,
    [Cliente_Id] int  NOT NULL,
    [Trabalhador_Id] int  NOT NULL,
    [Estado_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuSet'
CREATE TABLE [dbo].[ItemMenuSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] smallint  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL,
    [Preço] float  NOT NULL,
    [Categoria_Id] int  NOT NULL
);
GO

-- Creating table 'CategoriaSet'
CREATE TABLE [dbo].[CategoriaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'EstadoSet'
CREATE TABLE [dbo].[EstadoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TipoEstado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PagamentoSet'
CREATE TABLE [dbo].[PagamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [CodigoId] int  NULL,
    [Pedido_Id] int  NOT NULL,
    [MetodoPagamento_Id] int  NOT NULL
);
GO

-- Creating table 'MoradaSet'
CREATE TABLE [dbo].[MoradaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PessoaSet'
CREATE TABLE [dbo].[PessoaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telemovel] int  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'MetodoPagamentoSet'
CREATE TABLE [dbo].[MetodoPagamentoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TipoPagamento] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'CodigoSet'
CREATE TABLE [dbo].[CodigoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [Descrição] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PessoaSet_Cliente'
CREATE TABLE [dbo].[PessoaSet_Cliente] (
    [TotalGasto] decimal(18,0)  NOT NULL,
    [NumContribuinte] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Trabalhador'
CREATE TABLE [dbo].[PessoaSet_Trabalhador] (
    [Salario] decimal(18,0)  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL,
    [Restaurante_Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuRestaurante'
CREATE TABLE [dbo].[ItemMenuRestaurante] (
    [ItemMenu_Id] int  NOT NULL,
    [Restaurante_Id] int  NOT NULL
);
GO

-- Creating table 'PedidoItemMenu'
CREATE TABLE [dbo].[PedidoItemMenu] (
    [Pedido_Id] int  NOT NULL,
    [ItemMenu_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'RestauranteSet'
ALTER TABLE [dbo].[RestauranteSet]
ADD CONSTRAINT [PK_RestauranteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [PK_PedidoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenuSet'
ALTER TABLE [dbo].[ItemMenuSet]
ADD CONSTRAINT [PK_ItemMenuSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriaSet'
ALTER TABLE [dbo].[CategoriaSet]
ADD CONSTRAINT [PK_CategoriaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EstadoSet'
ALTER TABLE [dbo].[EstadoSet]
ADD CONSTRAINT [PK_EstadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [PK_PagamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MoradaSet'
ALTER TABLE [dbo].[MoradaSet]
ADD CONSTRAINT [PK_MoradaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [PK_PessoaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetodoPagamentoSet'
ALTER TABLE [dbo].[MetodoPagamentoSet]
ADD CONSTRAINT [PK_MetodoPagamentoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CodigoSet'
ALTER TABLE [dbo].[CodigoSet]
ADD CONSTRAINT [PK_CodigoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [PK_PessoaSet_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PessoaSet_Trabalhador'
ALTER TABLE [dbo].[PessoaSet_Trabalhador]
ADD CONSTRAINT [PK_PessoaSet_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ItemMenu_Id], [Restaurante_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [PK_ItemMenuRestaurante]
    PRIMARY KEY CLUSTERED ([ItemMenu_Id], [Restaurante_Id] ASC);
GO

-- Creating primary key on [Pedido_Id], [ItemMenu_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [PK_PedidoItemMenu]
    PRIMARY KEY CLUSTERED ([Pedido_Id], [ItemMenu_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cliente_Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_PedidoCliente]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoCliente'
CREATE INDEX [IX_FK_PedidoCliente]
ON [dbo].[PedidoSet]
    ([Cliente_Id]);
GO

-- Creating foreign key on [Restaurante_Id] in table 'PessoaSet_Trabalhador'
ALTER TABLE [dbo].[PessoaSet_Trabalhador]
ADD CONSTRAINT [FK_TrabalhadorRestaurante]
    FOREIGN KEY ([Restaurante_Id])
    REFERENCES [dbo].[RestauranteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorRestaurante'
CREATE INDEX [IX_FK_TrabalhadorRestaurante]
ON [dbo].[PessoaSet_Trabalhador]
    ([Restaurante_Id]);
GO

-- Creating foreign key on [Trabalhador_Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_PedidoTrabalhador]
    FOREIGN KEY ([Trabalhador_Id])
    REFERENCES [dbo].[PessoaSet_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoTrabalhador'
CREATE INDEX [IX_FK_PedidoTrabalhador]
ON [dbo].[PedidoSet]
    ([Trabalhador_Id]);
GO

-- Creating foreign key on [ItemMenu_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [FK_ItemMenuRestaurante_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItemMenuSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Restaurante_Id] in table 'ItemMenuRestaurante'
ALTER TABLE [dbo].[ItemMenuRestaurante]
ADD CONSTRAINT [FK_ItemMenuRestaurante_Restaurante]
    FOREIGN KEY ([Restaurante_Id])
    REFERENCES [dbo].[RestauranteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuRestaurante_Restaurante'
CREATE INDEX [IX_FK_ItemMenuRestaurante_Restaurante]
ON [dbo].[ItemMenuRestaurante]
    ([Restaurante_Id]);
GO

-- Creating foreign key on [Categoria_Id] in table 'ItemMenuSet'
ALTER TABLE [dbo].[ItemMenuSet]
ADD CONSTRAINT [FK_ItemMenuCategoria]
    FOREIGN KEY ([Categoria_Id])
    REFERENCES [dbo].[CategoriaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuCategoria'
CREATE INDEX [IX_FK_ItemMenuCategoria]
ON [dbo].[ItemMenuSet]
    ([Categoria_Id]);
GO

-- Creating foreign key on [Pedido_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_Pedido]
    FOREIGN KEY ([Pedido_Id])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenu_Id] in table 'PedidoItemMenu'
ALTER TABLE [dbo].[PedidoItemMenu]
ADD CONSTRAINT [FK_PedidoItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItemMenuSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoItemMenu_ItemMenu'
CREATE INDEX [IX_FK_PedidoItemMenu_ItemMenu]
ON [dbo].[PedidoItemMenu]
    ([ItemMenu_Id]);
GO

-- Creating foreign key on [Estado_Id] in table 'PedidoSet'
ALTER TABLE [dbo].[PedidoSet]
ADD CONSTRAINT [FK_PedidoEstado]
    FOREIGN KEY ([Estado_Id])
    REFERENCES [dbo].[EstadoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoEstado'
CREATE INDEX [IX_FK_PedidoEstado]
ON [dbo].[PedidoSet]
    ([Estado_Id]);
GO

-- Creating foreign key on [Pedido_Id] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [FK_PagamentoPedido]
    FOREIGN KEY ([Pedido_Id])
    REFERENCES [dbo].[PedidoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoPedido'
CREATE INDEX [IX_FK_PagamentoPedido]
ON [dbo].[PagamentoSet]
    ([Pedido_Id]);
GO

-- Creating foreign key on [MetodoPagamento_Id] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [FK_PagamentoMetodoPagamento]
    FOREIGN KEY ([MetodoPagamento_Id])
    REFERENCES [dbo].[MetodoPagamentoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoMetodoPagamento'
CREATE INDEX [IX_FK_PagamentoMetodoPagamento]
ON [dbo].[PagamentoSet]
    ([MetodoPagamento_Id]);
GO

-- Creating foreign key on [Morada_Id] in table 'RestauranteSet'
ALTER TABLE [dbo].[RestauranteSet]
ADD CONSTRAINT [FK_RestauranteMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[MoradaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteMorada'
CREATE INDEX [IX_FK_RestauranteMorada]
ON [dbo].[RestauranteSet]
    ([Morada_Id]);
GO

-- Creating foreign key on [Morada_Id] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [FK_PessoaMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[MoradaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaMorada'
CREATE INDEX [IX_FK_PessoaMorada]
ON [dbo].[PessoaSet]
    ([Morada_Id]);
GO

-- Creating foreign key on [CodigoId] in table 'PagamentoSet'
ALTER TABLE [dbo].[PagamentoSet]
ADD CONSTRAINT [FK_CodigoPagamento]
    FOREIGN KEY ([CodigoId])
    REFERENCES [dbo].[CodigoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CodigoPagamento'
CREATE INDEX [IX_FK_CodigoPagamento]
ON [dbo].[PagamentoSet]
    ([CodigoId]);
GO

-- Creating foreign key on [Id] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'PessoaSet_Trabalhador'
ALTER TABLE [dbo].[PessoaSet_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[PessoaSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------