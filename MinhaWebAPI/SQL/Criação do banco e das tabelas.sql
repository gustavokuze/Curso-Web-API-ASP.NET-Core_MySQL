CREATE DATABASE dbcliente;
USE dbcliente;

CREATE TABLE cliente(
	id INT AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    data_cadastro DATE NOT NULL,
    cpf_cnpj VARCHAR (14) NOT NULL,
    data_nascimento DATE NOT NULL,
    tipo CHAR(1) NOT NULL,
    telefone VARCHAR(20),
    email VARCHAR(40),
    cep VARCHAR(10),
    logradouro VARCHAR(50),
    numero VARCHAR(10),
    bairro VARCHAR(40),
    complemento VARCHAR (20),
    cidade VARCHAR(40),
    uf CHAR(2),
    PRIMARY KEY(id)
);


INSERT INTO cliente (nome, data_cadastro, cpf_cnpj, data_nascimento, 
tipo, telefone, email, cep, logradouro, numero, bairro, complemento, cidade, uf) VALUES (
	"Thiago Freitas", "19990402", "033.283.909-75", "19870202", "F", 
    "(11)94452-6969", "thiaguinhofreitas@mail.com", "95170-003", "Rua das Piranhas", "74", "Centro",
    "Perto do mercadinho do seu zé", "Novo Hamburgo", "RS"
);



