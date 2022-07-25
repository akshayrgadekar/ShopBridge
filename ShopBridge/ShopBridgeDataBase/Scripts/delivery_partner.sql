CREATE TABLE delivery_partner
  (
     deliverypartnerid               INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     deliverypartnername             VARCHAR(75) NOT NULL,
     deliverypartneronboardingdate   DATE NOT NULL,
     deliverypartnerestdate          DATE NULL,
     deliverypartnerprimarycontact   CHAR(20) NOT NULL,
     deliverypartnersecondarycontact CHAR(20) NULL,
     deliverypartneremail            VARCHAR(50) NOT NULL,
     deliverypartneraddress          VARCHAR(500) NOT NULL,
     deliverypartnercity             VARCHAR(75) NOT NULL,
     deliverypartnerstate            VARCHAR(75) NOT NULL,
     deliverypartnercountry          VARCHAR(75) NOT NULL,
     deliverypartnerzipcode          VARCHAR(75) NOT NULL,
     createtimestamp                 DATETIME NOT NULL,
     createui                        VARCHAR(50) NOT NULL,
     lastupdatetimestamp             DATETIME NOT NULL,
     lastupdateui                    VARCHAR(50) NOT NULL
  )
GO