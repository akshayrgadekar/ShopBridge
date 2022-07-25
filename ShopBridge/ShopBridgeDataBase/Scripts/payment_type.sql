CREATE TABLE payment_type
  (
     paymenttypeid       INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     paymenttypename     VARCHAR(50) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
GO