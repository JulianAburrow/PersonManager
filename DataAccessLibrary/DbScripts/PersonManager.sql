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

	