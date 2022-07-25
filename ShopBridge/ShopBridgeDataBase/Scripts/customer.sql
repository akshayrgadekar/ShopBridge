CREATE TABLE customer
  (
     custid              INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     custfname           VARCHAR(75) NOT NULL,
     custlname           VARCHAR(75) NOT NULL,
     custdob             DATE NOT NULL,
     customeremail       VARCHAR(75) NOT NULL,
     customerphonenumber CHAR(20) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL,
     custaddress         VARCHAR(500) NOT NULL,
     custcity            VARCHAR(75) NOT NULL,
     custstate           VARCHAR(75) NOT NULL,
     custcountry         VARCHAR(75) NOT NULL,
     custzipcode         VARCHAR(75) NOT NULL
  )
GO