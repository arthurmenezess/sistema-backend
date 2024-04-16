--1- CRIAR BANCO DE DADOS
CREATE DATABASE programacao_do_zero;

-- USAR O BANCO DE DADOS
USE programacao_do_zero;

-- CRIAR TABELA USUARIO
CREATE TABLE usuario (
		id INT NOT NULL AUTO_INCREMENT,
		nome VARCHAR(50) NOT NULL,
		sobrenome VARCHAR(150) NOT NULL,
		cpf VARCHAR(14) NOT NULL,
		telefone VARCHAR(15) NOT NULL,
		genero VARCHAR(20) NOT NULL,
		email VARCHAR(50) NOT NULL,
		senha VARCHAR(30) NOT NULL,
		PRIMARY KEY (id)
);

--3 CRIAR TABELA ENDEREÇO
CREATE TABLE endereco (
id INT NOT NULL AUTO_INCREMENT,
rua VARCHAR(250) NOT NULL,
numero VARCHAR(30) NOT NULL,
bairro VARCHAR(150) NOT NULL,
cidade VARCHAR(250) NOT NULL,
complemento VARCHAR(150) NULL,
cep VARCHAR(9) NOT NULL,
estado VARCHAR(2) NOT NULL,
PRIMARY KEY (ID)
);

-- ALTERAR TABELA ENDEREÇO 
ALTER TABLE endereco ADD usuario_id INT NOT NULL;

-- ADICIONAR CHAVE ESTRANGEIRA
ALTER TABLE endereco
ADD CONSTRAINT FK_usuario FOREIGN KEY (usuario_id) REFERENCES usuario(id);

-- INSERIR USUARIO
INSERT INTO usuario 
(nome, sobrenome, cpf, telefone, genero, email, senha)
 VALUES ('Arthur',
 'Rodrigues',
 '01988325676',
 '31995880349',
 'Masculino',
 'arthur.mnz@hotmail.com',
 '123') 

 -- SELECIONAR USUARIO
 SELECT * FROM usuario;

 -- SELECIONAR UM USUARIO ESPECIFICO
 SELECT * FROM usuario WHERE id = 2;

 -- ALTERAR USUARIO
 UPDATE usuario SET nome = 'lucas' WHERE id = 2;

 --EXCLUIR USUARIO
 DELETE FROM usuario WHERE id = 2; -- especifico 
 DELETE FROM usuario WHERE id IN (2,3,4); -- selecionados
 DELETE FROM usuario WHERE id > 2; -- todos ids maiores que 2