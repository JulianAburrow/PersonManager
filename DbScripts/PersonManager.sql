USE Master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'PersonManager')
	ALTER DATABASE [PersonManager] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
IF EXISTS (SELECT * FROM sys.databases WHERE NAME = 'PersonManager')
	DROP DATABASE PersonManager
GO

CREATE DATABASE PersonManager
GO

USE PersonManager
GO

CREATE TABLE Countries (
	CountryId INT NOT NULL IDENTITY (1, 1),
	CountryName NVARCHAR(50) NOT NULL,
	CONSTRAINT pk_Countries PRIMARY KEY (CountryId)
)
GO

INSERT INTO Countries
	( CountryName )
VALUES
	( 'Belgium' ),
	( 'France' ),
	( 'Germany' ),
	( 'Netherlands' ),
	( 'Austria' )
GO

CREATE TABLE Statuses (
	StatusId INT NOT NULL IDENTITY (1, 1),
	StatusName NVARCHAR(50) NOT NULL
	CONSTRAINT pk_Statuses PRIMARY KEY (StatusId)
)

GO

INSERT INTO Statuses
	( StatusName )
VALUES
	( 'Active' ),
	( 'Deleted' )
GO

CREATE TABLE Colours (
	ColourId INT NOT NULL IDENTITY (1, 1),
	ColourName NVARCHAR(20) NOT NULL,
	CONSTRAINT pk_Colour PRIMARY KEY (ColourId)
)

CREATE TABLE People (
	PersonId INT NOT NULL IDENTITY (1, 1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	DateOfBirth DATETIME2(7) NULL,
	EmailAddress NVARCHAR(100) NOT NULL,
	CountryId INT NOT NULL,
	StatusId INT NOT NULL,
	FavouriteColourId INT NULL,
	CONSTRAINT pk_Person PRIMARY KEY (PersonId),
	CONSTRAINT fk_Countries_People FOREIGN KEY (CountryId)
		REFERENCES Countries (CountryId),
	CONSTRAINT fk_Statuses_People FOREIGN KEY (StatusId)
		REFERENCES Statuses (StatusId),
	CONSTRAINT fk_Colours_People FOREIGN KEY (FavouriteColourId)
		REFERENCES Colours (ColourId)
)
GO

CREATE TABLE AddressTypes (
	AddressTypeId INT NOT NULL IDENTITY (1, 1),
	AddressTypeName NVARCHAR(50) NOT NULL,
	CONSTRAINT pk_AddressTypes PRIMARY KEY (AddressTypeId)
)
GO

INSERT INTO AddressTypes
	( AddressTypeName )
VALUES
	( 'Home' ),
	( 'Work' ),
	( 'Other')
GO

CREATE TABLE Addresses (
	AddressId INT NOT NULL IDENTITY (1, 1),
	AddressLine1 NVARCHAR(50) NOT NULL,
	AddressLine2 NVARCHAR(50) NULL,
	Town NVARCHAR(50) NOT NULL,
	Postcode NVARCHAR(15) NOT NULL,
	AddressTypeId INT NOT NULL,
	PersonId INT NOT NULL,
	CONSTRAINT pk_Addresses PRIMARY KEY (AddressId),
	CONSTRAINT fk_Addresses_AddressTypes FOREIGN KEY(AddressTypeId)
		REFERENCES AddressTypes (AddressTypeId),
	CONSTRAINT fk_Addresses_People FOREIGN KEY (PersonId)
		REFERENCES People (PersonId)
	)
GO

ALTER TABLE People ADD AddressId INT NULL FOREIGN KEY (AddressId) REFERENCES Addresses (AddressId)
GO

ALTER TABLE People ADD Skillset NVARCHAR(1000) NULL
GO

ALTER TABLE People Add Picture VARBINARY(MAX) NULL
GO

CREATE TABLE SavedUrls (
	UrlId INT NOT NULL IDENTITY (1, 1),
	Title NVARCHAR(100) NULL,
	Url NVARCHAR(100) NOT NULL,
	Notes NVARCHAR(250) NULL,
	IsExternal BIT NOT NULL,
	CONSTRAINT pk_SavedUrls PRIMARY KEY (UrlId)
)
GO

CREATE TABLE Reminders (
	ReminderId INT NOT NULL IDENTITY (1, 1),
	Title NVARCHAR(50) NOT NULL,
	ReminderDate DATETIME NOT NULL,
	Notes NVARCHAR(500) NOT NULL,
	IsCurrent BIT NOT NULL,
	CONSTRAINT pk_Reminders PRIMARY KEY (ReminderId)
)
GO