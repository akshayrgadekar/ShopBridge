CREATE TABLE price_history
  (
     pricehistoryid      INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     productid           INT FOREIGN KEY REFERENCES product(productid) NOT NULL,
     price               NUMERIC(8, 2) NOT NULL,
     pricingtimestamp    DATETIME NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
GO