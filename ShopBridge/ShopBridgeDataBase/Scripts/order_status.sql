CREATE TABLE order_status
  (
     orderstatusid       INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     orderstatusname     VARCHAR(50) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
GO