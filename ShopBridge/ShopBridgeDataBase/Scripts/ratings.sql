CREATE TABLE ratings
  (
     ratingid            INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
     ratingname          INT NOT NULL,
     ratingdescription   VARCHAR(500) NOT NULL,
     createtimestamp     DATETIME NOT NULL,
     createui            VARCHAR(50) NOT NULL,
     lastupdatetimestamp DATETIME NOT NULL,
     lastupdateui        VARCHAR(50) NOT NULL
  )
GO