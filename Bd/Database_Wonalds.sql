CREATE DATABASE IF NOT EXISTS Wonalds; 
USE Wonalds;

alter table pedido CHANGE dataPedido dataPedido VARCHAR (50);

select * from cardapio;
select * from pedido;

CREATE TABLE cardapio (
  idCombo VARCHAR (10) NOT NULL,
  nomeCombo VARCHAR(45) NOT NULL,
  valorCombo FLOAT (10,2) NOT NULL,
  PRIMARY KEY (idCombo));

CREATE TABLE IF NOT EXISTS pedido(
  idPedido varchar (50) NOT NULL,  
  combo1 INT (4),
  combo2 INT (4),
  combo3 INT (4),
  combo4 INT (4),
  combo5 INT (4),
  valorTotal FLOAT (10,2) NOT NULL,
  dataPedido VARCHAR (50) NOT NULL
);

insert into cardapio values ('1',"Combo Fake Picanha", 33.90);
insert into cardapio values ('2',"Combo Big Wac", 31.90);
insert into cardapio values ('3',"Combo Cheese Wac", 30.90);
insert into cardapio values ('4',"Combo Big Big Wac", 35.90);
insert into cardapio values ('5',"Combo Wac Felicidade", 20.90);