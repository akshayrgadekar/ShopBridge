CREATE TABLE tblorder
  (
     orderid             INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     custid              INT FOREIGN KEY REFERENCES customer(custid) NOT NULL,
     orderdate           DATETIME NOT NULL,
     ordertotal          NUMERIC(8, 2) NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
  GO