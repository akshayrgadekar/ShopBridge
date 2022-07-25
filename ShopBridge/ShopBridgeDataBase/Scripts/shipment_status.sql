CREATE TABLE shipment_status
  (
     shipmentstatusid    INT IDENTITY(1, 1) NOT NULL,
     shipmentid          INT NOT NULL,
     lineitemid          INT NOT NULL,
     orderstatusid       INT FOREIGN KEY REFERENCES order_status(orderstatusid)
     NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL,
     FOREIGN KEY (shipmentid, lineitemid) REFERENCES shipment,
     PRIMARY KEY (shipmentstatusid, shipmentid, lineitemid)
  ) 
  GO