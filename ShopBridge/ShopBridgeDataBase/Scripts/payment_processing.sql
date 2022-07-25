CREATE TABLE payment_processing
  (
     paymentprocessingid INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     paymentid           INT FOREIGN KEY REFERENCES payment(paymentid) NOT NULL,
     paymentstatusid     INT FOREIGN KEY REFERENCES payment_status(
     paymentstatusid) NOT
     NULL,
     iscurrentstate      VARCHAR(50) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
GO