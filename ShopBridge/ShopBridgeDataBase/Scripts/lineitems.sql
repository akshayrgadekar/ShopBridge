CREATE TABLE lineitems
  (
     lineitemid          INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     orderid             INT FOREIGN KEY REFERENCES tblorder(orderid) NOT NULL,
     productid           INT FOREIGN KEY REFERENCES product(productid) NOT NULL,
     quantity            INT NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
 GO