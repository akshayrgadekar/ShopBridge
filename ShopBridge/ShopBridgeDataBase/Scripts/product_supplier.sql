CREATE TABLE product_supplier
  (
     productsupplierid   INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     productid           INT FOREIGN KEY REFERENCES product(productid) NOT NULL,
     supplierid          INT FOREIGN KEY REFERENCES supplier(supplierid) NOT
     NULL,
     productquantity     INT NOT NULL,
     orderplaceddate     DATE NULL,
     orderdelivereddate  DATE NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
  go