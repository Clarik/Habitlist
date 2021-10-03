SELECT SERVERPROPERTY('COLLATION')

ALTER Table [User] 
ALTER Column [Name] varchar (100) COLLATE SQL_Latin1_General_CP1_CS_AS

ALTER Table [User]
ALTER Column [Password] varchar (100) COLLATE SQL_Latin1_General_CP1_CS_AS