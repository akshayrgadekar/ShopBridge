CREATE TABLE product
  (
     productid           INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     producttypeid       INT FOREIGN KEY REFERENCES product_type(producttypeid)
     NOT NULL,
     productname         VARCHAR(50) NOT NULL,
     productdescription  VARCHAR(500) NOT NULL,
     price               NUMERIC(8, 2) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
go
