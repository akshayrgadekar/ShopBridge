CREATE TABLE payment_status
  (
     paymentstatusid     INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     paymentstatusname   VARCHAR(50) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
GO
