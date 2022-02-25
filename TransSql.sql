
CREATE DATABASE TransportesCanas;
USE TransportesCanas;

CREATE TABLE DriverStatus 
(
	Id INT IDENTITY NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO DriverStatus(Description) VALUES ('Disponible');
INSERT INTO DriverStatus(Description) VALUES('De baja');

CREATE TABLE Driver
(
	Id INT IDENTITY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Dui VARCHAR(10) UNIQUE NOT NULL,
	License VARCHAR(17) UNIQUE NOT NULL,
	Passport VARCHAR(9) NOT NULL,
	Telephone VARCHAR(15) DEFAULT NULL,
	IdDriverStatus INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdDriverStatus) REFERENCES DriverStatus(Id) 
);

CREATE TABLE Client
(
	Id INT IDENTITY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	Address TEXT NOT NULL,
	Telephone VARCHAR(15) NOT NULL,
	Email VARCHAR(50) UNIQUE NOT NULL,
	PRIMARY KEY(Id)
);

CREATE TABLE DestinationPlace
(
	Id INT IDENTITY NOT NULL,
	Country VARCHAR(50) NOT NULL,
	State VARCHAR(50) NOT NULL,
	City VARCHAR(50) NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id),
);

CREATE TABLE OriginPlace
(
	Id INT IDENTITY NOT NULL,
	Country VARCHAR(50) NOT NULL,
	State VARCHAR(50) NOT NULL,
	City VARCHAR(50) NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id),
);

CREATE TABLE WorkTrip
(
	Id INT IDENTITY NOT NULL,
	IdClient INT NOT NULL,
	IdDestination INT NOT NULL,
	IdOrigin INT NOT NULL,
	Price DECIMAL(10, 2) NOT NULL,
	MotoristPayment DECIMAL(10, 2) NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdClient) REFERENCES Client(Id),
	FOREIGN KEY (IdDestination) REFERENCES DestinationPlace(Id),
	FOREIGN KEY (IdOrigin) REFERENCES OriginPlace(Id)
);

CREATE TABLE VehicleType 
(
	Id INT IDENTITY NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO VehicleType(Description) VALUES('Furgón');
INSERT INTO VehicleType(Description) VALUES('Rastra');

CREATE TABLE VehicleStatus 
(
	Id INT IDENTITY NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO VehicleStatus(Description) VALUES ('Disponible');
INSERT INTO VehicleStatus(Description) VALUES('De baja');

CREATE TABLE Truck 
(
	Id INT IDENTITY NOT NULL,
	VehicleLicense VARCHAR(10) UNIQUE NOT NULL,
	Brand VARCHAR(50) NOT NULL,
	Model VARCHAR(50) NOT NULL,
	Year INT NOT NULL,
	IdVehiceStatus INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdVehiceStatus) REFERENCES VehicleStatus(Id),
);

CREATE TABLE TruckBox 
(
	Id INT IDENTITY NOT NULL,
	VehicleLicense VARCHAR(10) UNIQUE NOT NULL,
	Brand VARCHAR(50) NOT NULL,
	Model VARCHAR(50) NOT NULL,
	Year INT NOT NULL,
	IdVehicleType INT NOT NULL,
	IdVehiceStatus INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdVehiceStatus) REFERENCES VehicleStatus(Id),
	FOREIGN KEY (IdVehicleType) REFERENCES VehicleType(Id),
);

CREATE TABLE AssignmentStatus 
(
	Id INT IDENTITY NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO AssignmentStatus(Description) VALUES ('En camino');
INSERT INTO AssignmentStatus(Description) VALUES('Entregado');
INSERT INTO AssignmentStatus(Description) VALUES('Pagado');

CREATE TABLE Assignment 
(
	Id INT IDENTITY NOT NULL,
	IdWorkTrip INT  NOT NULL,
	IdDriver INT NOT NULL,
	IdAssignmentStatus INT NOT NULL,
	TicketNumber VARCHAR(25) NULL,
	IdTruck INT NOT NULL,
	IdTruckBox INT NOT NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdWorkTrip) REFERENCES WorkTrip(Id),
	FOREIGN KEY (IdDriver) REFERENCES Driver(Id),
	FOREIGN KEY (IdAssignmentStatus) REFERENCES AssignmentStatus(Id),
	FOREIGN KEY (IdTruck) REFERENCES Truck(Id),
	FOREIGN KEY (IdTruckBox) REFERENCES TruckBox(Id),
);
