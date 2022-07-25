CREATE TABLE shipment
  (
     shipmentid          INT IDENTITY(1, 1) NOT NULL,
     lineitemid          INT FOREIGN KEY REFERENCES lineitems(lineitemid) NOT
     NULL,
     deliverypartnerid   INT FOREIGN KEY REFERENCES delivery_partner(
     deliverypartnerid)
     NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL,
     PRIMARY KEY (shipmentid, lineitemid)
  )
GO