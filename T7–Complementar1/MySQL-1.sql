INSERT INTO COMPRADORES (NOME, ENDERECO, TELEFONE) 
VALUES ('MAURICIO', 'RUA VERGUEIRO, 123', '(11) 1111-1111');
INSERT INTO COMPRADORES (NOME, ENDERECO, TELEFONE) 
VALUES ('ADRIANO', 'AV. PAULISTA, 456', '(11) 2222-2222');

ALTER TABLE COMPRAS ADD COLUMN COMPRADOR_ID INT NOT NULL;

UPDATE COMPRAS SET COMPRADOR_ID = 1 WHERE ID < 8;
UPDATE COMPRAS SET COMPRADOR_ID = 2 WHERE ID >= 8;

SELECT * FROM COMPRAS JOIN COMPRADORES ON COMPRAS.COMPRADOR_ID = COMPRADORES.ID;

ALTER TABLE COMPRAS ADD FOREIGN KEY (COMPRADOR_ID) REFERENCES COMPRADORES(ID);

select nome, valor from compradores join compras on comprador_id = compras.COMPRADOR_ID where data < '2010-08-09';

select nome, compras.id 'cod da compra', comprador_ID 'Cod. do comprador' from compras inner join compradores on compras.COMPRADOR_ID = comprador_id where comprador_iD = '1';

SELECT COMPRAS.* FROM COMPRAS JOIN COMPRADORES ON COMPRAS.COMPRADOR_ID = COMPRADORES.ID WHERE NOME LIKE 'adriano%';

select nome, sum(valor) from compras inner join compradores on compras.COMPRADOR_ID = compradores.ID group by nome;
