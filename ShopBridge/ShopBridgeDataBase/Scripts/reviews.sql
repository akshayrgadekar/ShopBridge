CREATE TABLE reviews
  (
     reviewid            INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     custid              INT FOREIGN KEY REFERENCES customer(custid) NOT NULL,
     lineitemid          INT FOREIGN KEY REFERENCES lineitems(lineitemid) NOT
     NULL,
     ratingid            INT FOREIGN KEY REFERENCES ratings(ratingid) NOT NULL,
     reviewtext          VARCHAR(500) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
  GO