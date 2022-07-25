CREATE TABLE payment
  (
     paymentid           INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     orderid             INT FOREIGN KEY REFERENCES tblorder(orderid) NOT NULL,
     paymenttypeid       INT FOREIGN KEY REFERENCES payment_type(paymenttypeid)
     NOT NULL,
     paymentamount       NUMERIC(8, 2) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
GO