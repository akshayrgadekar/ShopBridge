CREATE TABLE product_type
  (
     producttypeid          INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     producttypename        VARCHAR(50) NOT NULL,
     producttypedescription VARCHAR(500) NOT NULL,
     createtimestamp        DATETIME NOT NULL,
     createui               VARCHAR(50) NOT NULL,
     lastupdatetimestamp    DATETIME NOT NULL,
     lastupdateui           VARCHAR(50) NOT NULL
  )
go
