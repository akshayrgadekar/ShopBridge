CREATE TABLE supplier
  (
     supplierid                INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     suppliername              VARCHAR(75) NOT NULL,
     onboardingdate            DATE NOT NULL,
     supplierestablishmentdate DATE NULL,
     supplierprimarycontact    CHAR(20) NOT NULL,
     suppliersecondarycontact  CHAR(20) NULL,
     supplieremail             VARCHAR(50) NULL,
     supplieraddress           VARCHAR(500) NOT NULL,
     suppliercity              VARCHAR(75) NOT NULL,
     supplierstate             VARCHAR(75) NOT NULL,
     suppliercountry           VARCHAR(75) NOT NULL,
     supplierzipcode           VARCHAR(75) NOT NULL,
     createtimestamp           DATETIME NOT NULL,
     createui                  VARCHAR(50) NOT NULL,
     lastupdatetimestamp       DATETIME NOT NULL,
     lastupdateui              VARCHAR(50) NOT NULL
  )
  GO
