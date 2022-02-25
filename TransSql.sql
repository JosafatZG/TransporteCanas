DROP DATABASE IF EXISTS TransportesCanas;
CREATE DATABASE TransportesCanas;
USE TransportesCanas;

DROP TABLE IF EXISTS DriverStatus;
CREATE TABLE DriverStatus 
(
	Id INT IDENTITY NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO DriverStatus(Description) VALUES ('Disponible');
INSERT INTO DriverStatus(Description) VALUES('De baja');

DROP TABLE IF EXISTS Driver;
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

DROP TABLE IF EXISTS Country;
CREATE TABLE Country
(
	Id INT IDENTITY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	PRIMARY KEY(Id),
);

DROP TABLE IF EXISTS State;
CREATE TABLE State
(
	Id INT IDENTITY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	IdCountry INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdCountry) REFERENCES Country(Id),
);

DROP TABLE IF EXISTS City;
CREATE TABLE City
(
	Id INT IDENTITY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	IdState INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdState) REFERENCES State(Id),
);

DROP TABLE IF EXISTS Client;
CREATE TABLE Client
(
	Id INT IDENTITY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	IdCity INT NOT NULL,
	Address TEXT NOT NULL,
	Telephone VARCHAR(15) NOT NULL,
	Email VARCHAR(50) UNIQUE NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdCity) REFERENCES City(Id),
);

DROP TABLE IF EXISTS DestinationPlace;
CREATE TABLE DestinationPlace
(
	Id INT IDENTITY NOT NULL,
	IdCity INT NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdCity) REFERENCES City(Id),
);

DROP TABLE IF EXISTS OriginPlace;
CREATE TABLE OriginPlace
(
	Id INT IDENTITY NOT NULL,
	IdCity INT NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdCity) REFERENCES City(Id),
);

DROP TABLE IF EXISTS WorkTrip;
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

DROP TABLE IF EXISTS VehicleType;
CREATE TABLE VehicleType 
(
	Id INT IDENTITY NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO VehicleType(Description) VALUES('Furgón');
INSERT INTO VehicleType(Description) VALUES('Rastra');

DROP TABLE IF EXISTS VehicleStatus;
CREATE TABLE VehicleStatus 
(
	Id INT IDENTITY NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO VehicleStatus(Description) VALUES ('Disponible');
INSERT INTO VehicleStatus(Description) VALUES('De baja');

DROP TABLE IF EXISTS VehicleBrand;
CREATE TABLE VehicleBrand 
(
	Id INT IDENTITY NOT NULL,
	Name TEXT NOT NULL,
	PRIMARY KEY(Id)
);

DROP TABLE IF EXISTS VehicleModel;
CREATE TABLE VehicleModel 
(
	Id INT IDENTITY NOT NULL,
	Name TEXT NOT NULL,
	IdVehicleBrand INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdVehicleBrand) REFERENCES VehicleBrand(Id),
);

DROP TABLE IF EXISTS Truck;
CREATE TABLE Truck 
(
	Id INT IDENTITY NOT NULL,
	VehicleLicense VARCHAR(10) UNIQUE NOT NULL,
	Year INT NOT NULL,
	IdVehiceStatus INT NOT NULL,
	IdVehicleModel INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdVehiceStatus) REFERENCES VehicleStatus(Id),
	FOREIGN KEY (IdVehicleModel) REFERENCES VehicleModel(Id)
);

DROP TABLE IF EXISTS TruckBox;
CREATE TABLE TruckBox 
(
	Id INT IDENTITY NOT NULL,
	VehicleLicense VARCHAR(10) UNIQUE NOT NULL,
	Year INT NOT NULL,
	IdVehicleType INT NOT NULL,
	IdVehiceStatus INT NOT NULL,
	IdVehicleModel INT NOT NULL,
	PRIMARY KEY(Id),
	FOREIGN KEY (IdVehiceStatus) REFERENCES VehicleStatus(Id),
	FOREIGN KEY (IdVehicleType) REFERENCES VehicleType(Id),
	FOREIGN KEY (IdVehicleModel) REFERENCES VehicleModel(Id)
);

DROP TABLE IF EXISTS AssignmentStatus;
CREATE TABLE AssignmentStatus 
(
	Id INT IDENTITY NOT NULL,
	Description TEXT NOT NULL,
	PRIMARY KEY(Id)
);

INSERT INTO AssignmentStatus(Description) VALUES ('En camino');
INSERT INTO AssignmentStatus(Description) VALUES('Entregado');
INSERT INTO AssignmentStatus(Description) VALUES('Pagado');

DROP TABLE IF EXISTS Assignment;
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


begin -- Insert Country, State and City

begin -- El Salvador, Id Country: 1
INSERT INTO Country(Name) VALUES('El Salvador');

begin -- Ahuachapán, Id State: 1
INSERT INTO State(IdCountry, Name) VALUES('1','Ahuachapán'); 

INSERT INTO City(IdState, Name) VALUES('1','Ahuachapán');
INSERT INTO City(IdState, Name) VALUES('1','Apaneca');
INSERT INTO City(IdState, Name) VALUES('1','Atiquizaya');
INSERT INTO City(IdState, Name) VALUES('1','Concepción de Ataco');
INSERT INTO City(IdState, Name) VALUES('1','El Refugio');
INSERT INTO City(IdState, Name) VALUES('1','Guaymango');
INSERT INTO City(IdState, Name) VALUES('1','Jujutla');
INSERT INTO City(IdState, Name) VALUES('1','San Francisco Menéndez');
INSERT INTO City(IdState, Name) VALUES('1','San Lorenzo');
INSERT INTO City(IdState, Name) VALUES('1','San Pedro Puxtla');
INSERT INTO City(IdState, Name) VALUES('1','Tacuba');
INSERT INTO City(IdState, Name) VALUES('1','Turín');
end

begin -- Cabañas, Id State: 2
INSERT INTO State(IdCountry, Name) VALUES('1','Cabañas');

INSERT INTO City(IdState, Name) VALUES('2','Sensuntepeque');
INSERT INTO City(IdState, Name) VALUES('2','Cinquera');
INSERT INTO City(IdState, Name) VALUES('2','Dolores');
INSERT INTO City(IdState, Name) VALUES('2','Guacotecti');
INSERT INTO City(IdState, Name) VALUES('2','Ilobasco');
INSERT INTO City(IdState, Name) VALUES('2','Jutiapa');
INSERT INTO City(IdState, Name) VALUES('2','San Isidro');
INSERT INTO City(IdState, Name) VALUES('2','Tejutepeque');
INSERT INTO City(IdState, Name) VALUES('2','Victoria');
end

begin -- Chalatenango, Id State: 3
INSERT INTO State(IdCountry, Name) VALUES('1','Chalatenango');

INSERT INTO City(IdState, Name) VALUES('3','Chalatenango');
INSERT INTO City(IdState, Name) VALUES('3','Agua Caliente');
INSERT INTO City(IdState, Name) VALUES('3','Arcatao');
INSERT INTO City(IdState, Name) VALUES('3','Azacualpa');
INSERT INTO City(IdState, Name) VALUES('3','Cancasque');
INSERT INTO City(IdState, Name) VALUES('3','Citalá');
INSERT INTO City(IdState, Name) VALUES('3','Comalapa');
INSERT INTO City(IdState, Name) VALUES('3','Concepción de Quezaltepeque');
INSERT INTO City(IdState, Name) VALUES('3','Dulce nombre de María');
INSERT INTO City(IdState, Name) VALUES('3','El Carrizal');
INSERT INTO City(IdState, Name) VALUES('3','El Paraíso');
INSERT INTO City(IdState, Name) VALUES('3','La Laguna');
INSERT INTO City(IdState, Name) VALUES('3','La Palma');
INSERT INTO City(IdState, Name) VALUES('3','La Reina');
INSERT INTO City(IdState, Name) VALUES('3','Las Flores');
INSERT INTO City(IdState, Name) VALUES('3','Las Vueltas');
INSERT INTO City(IdState, Name) VALUES('3','Nombre de Jesús');
INSERT INTO City(IdState, Name) VALUES('3','Nueva Concepción');
INSERT INTO City(IdState, Name) VALUES('3','Nueva Trinidad');
INSERT INTO City(IdState, Name) VALUES('3','Ojos de Agua');
INSERT INTO City(IdState, Name) VALUES('3','Potonico');
INSERT INTO City(IdState, Name) VALUES('3','San Antonio de la Cruz');
INSERT INTO City(IdState, Name) VALUES('3','San Antonio Los Ranchos');
INSERT INTO City(IdState, Name) VALUES('3','San Fernando');
INSERT INTO City(IdState, Name) VALUES('3','San Francisco Lempa');
INSERT INTO City(IdState, Name) VALUES('3','San Francisco Morazán');
INSERT INTO City(IdState, Name) VALUES('3','San Ignacio');
INSERT INTO City(IdState, Name) VALUES('3','San Isidro Labrador');
INSERT INTO City(IdState, Name) VALUES('3','San Luis del Carmen');
INSERT INTO City(IdState, Name) VALUES('3','San Miguel de Mercedes');
INSERT INTO City(IdState, Name) VALUES('3','San Rafael');
INSERT INTO City(IdState, Name) VALUES('3','Santa Rita');
INSERT INTO City(IdState, Name) VALUES('3','Tejutla');
end

begin -- Cuscatlán, Id State: 4
INSERT INTO State(IdCountry, Name) VALUES('1','Cuscatlán');

INSERT INTO City(IdState, Name) VALUES('4','Cojutepeque');
INSERT INTO City(IdState, Name) VALUES('4','Candelaria');
INSERT INTO City(IdState, Name) VALUES('4','El Carmen');
INSERT INTO City(IdState, Name) VALUES('4','El Rosario');
INSERT INTO City(IdState, Name) VALUES('4','Monte San Juan');
INSERT INTO City(IdState, Name) VALUES('4','Oratorio de Concepción');
INSERT INTO City(IdState, Name) VALUES('4','San Bartolomé Perulapía');
INSERT INTO City(IdState, Name) VALUES('4','San Cristóbal');
INSERT INTO City(IdState, Name) VALUES('4','San Jose Guayabal');
INSERT INTO City(IdState, Name) VALUES('4','San Pedro Perulapán');
INSERT INTO City(IdState, Name) VALUES('4','San Rafael Cedros');
INSERT INTO City(IdState, Name) VALUES('4','San Ramón');
INSERT INTO City(IdState, Name) VALUES('4','Santa Cruz Analquito');
INSERT INTO City(IdState, Name) VALUES('4','Santa Cruz Michapa');
INSERT INTO City(IdState, Name) VALUES('4','Suchitoto');
INSERT INTO City(IdState, Name) VALUES('4','Tenancingo');
end

begin -- La Libertad, Id State: 5
INSERT INTO State(IdCountry, Name) VALUES('1','La Libertad');

INSERT INTO City(IdState, Name) VALUES('5','Santa Tecla');
INSERT INTO City(IdState, Name) VALUES('5','Antiguo Cuscatlán');
INSERT INTO City(IdState, Name) VALUES('5','Chiltiupán');
INSERT INTO City(IdState, Name) VALUES('5','Ciudad Arce');
INSERT INTO City(IdState, Name) VALUES('5','Colón');
INSERT INTO City(IdState, Name) VALUES('5','Comasagua');
INSERT INTO City(IdState, Name) VALUES('5','Huizúcar');
INSERT INTO City(IdState, Name) VALUES('5','Jayaque');
INSERT INTO City(IdState, Name) VALUES('5','Jicalapa');
INSERT INTO City(IdState, Name) VALUES('5','La Libertad');
INSERT INTO City(IdState, Name) VALUES('5','Nuevo Cuscatlán');
INSERT INTO City(IdState, Name) VALUES('5','Quezaltepeque');
INSERT INTO City(IdState, Name) VALUES('5','San Juan Opico');
INSERT INTO City(IdState, Name) VALUES('5','Sacacoyo');
INSERT INTO City(IdState, Name) VALUES('5','San José Villanueva');
INSERT INTO City(IdState, Name) VALUES('5','San Matías');
INSERT INTO City(IdState, Name) VALUES('5','San Pablo Tacachico');
INSERT INTO City(IdState, Name) VALUES('5','Talnique');
INSERT INTO City(IdState, Name) VALUES('5','Tamanique');
INSERT INTO City(IdState, Name) VALUES('5','Teotepeque');
INSERT INTO City(IdState, Name) VALUES('5','Tepecoyo');
INSERT INTO City(IdState, Name) VALUES('5','Zaragoza');
end

begin -- La Paz, Id State: 6
INSERT INTO State(IdCountry, Name) VALUES('1','La Paz');

INSERT INTO City(IdState, Name) VALUES('6','Zacatecoluca');
INSERT INTO City(IdState, Name) VALUES('6','Cuyultitán');
INSERT INTO City(IdState, Name) VALUES('6','El Rosario');
INSERT INTO City(IdState, Name) VALUES('6','Jerusalén');
INSERT INTO City(IdState, Name) VALUES('6','Mercedes La Ceiba');
INSERT INTO City(IdState, Name) VALUES('6','Olocuilta');
INSERT INTO City(IdState, Name) VALUES('6','Paraíso de Osorio');
INSERT INTO City(IdState, Name) VALUES('6','San Antonio Masahuat');
INSERT INTO City(IdState, Name) VALUES('6','San Emigdio');
INSERT INTO City(IdState, Name) VALUES('6','San Francisco Chinameca');
INSERT INTO City(IdState, Name) VALUES('6','San Pedro Masahuat');
INSERT INTO City(IdState, Name) VALUES('6','San Juan Nonualco');
INSERT INTO City(IdState, Name) VALUES('6','San Juan Talpa');
INSERT INTO City(IdState, Name) VALUES('6','San Juan Tepezontes');
INSERT INTO City(IdState, Name) VALUES('6','San Luis La Herradura');
INSERT INTO City(IdState, Name) VALUES('6','San Luis Talpa');
INSERT INTO City(IdState, Name) VALUES('6','San Miguel Tepezontes');
INSERT INTO City(IdState, Name) VALUES('6','San Pedro Nonualco');
INSERT INTO City(IdState, Name) VALUES('6','San Rafael Obrajuelo');
INSERT INTO City(IdState, Name) VALUES('6','Santa Maía Ostuma');
INSERT INTO City(IdState, Name) VALUES('6','Santiago Nonualco');
INSERT INTO City(IdState, Name) VALUES('6','Tapalhuaca');
end

begin -- La Unión, Id State: 7
INSERT INTO State(IdCountry, Name) VALUES('1','La Unión');

INSERT INTO City(IdState, Name) VALUES('7','La Unión');
INSERT INTO City(IdState, Name) VALUES('7','Anamorós');
INSERT INTO City(IdState, Name) VALUES('7','Bolívar');
INSERT INTO City(IdState, Name) VALUES('7','Concepción de Oriente');
INSERT INTO City(IdState, Name) VALUES('7','Conchagua');
INSERT INTO City(IdState, Name) VALUES('7','El Carmen');
INSERT INTO City(IdState, Name) VALUES('7','El Sauce');
INSERT INTO City(IdState, Name) VALUES('7','Intipucá');
INSERT INTO City(IdState, Name) VALUES('7','Lislique');
INSERT INTO City(IdState, Name) VALUES('7','Meanguera del Golfo');
INSERT INTO City(IdState, Name) VALUES('7','Nueva Esparta');
INSERT INTO City(IdState, Name) VALUES('7','Pasaquina');
INSERT INTO City(IdState, Name) VALUES('7','Polorós');
INSERT INTO City(IdState, Name) VALUES('7','San Alejo');
INSERT INTO City(IdState, Name) VALUES('7','San José');
INSERT INTO City(IdState, Name) VALUES('7','Santa Rosa de Lima');
INSERT INTO City(IdState, Name) VALUES('7','Yayantique');
INSERT INTO City(IdState, Name) VALUES('7','Yucuaiquín');
end

begin -- Morazán, Id State: 8
INSERT INTO State(IdCountry, Name) VALUES('1','Morazán');

INSERT INTO City(IdState, Name) VALUES('8','San Francisco Gotera');
INSERT INTO City(IdState, Name) VALUES('8','Arambala');
INSERT INTO City(IdState, Name) VALUES('8','Cacaopera');
INSERT INTO City(IdState, Name) VALUES('8','Chilanga');
INSERT INTO City(IdState, Name) VALUES('8','Corinto');
INSERT INTO City(IdState, Name) VALUES('8','Delicias de Concepción');
INSERT INTO City(IdState, Name) VALUES('8','El Divisadero');
INSERT INTO City(IdState, Name) VALUES('8','El Rosario');
INSERT INTO City(IdState, Name) VALUES('8','Gualococti');
INSERT INTO City(IdState, Name) VALUES('8','Guatajiagua');
INSERT INTO City(IdState, Name) VALUES('8','Joateca');
INSERT INTO City(IdState, Name) VALUES('8','Jocoatique');
INSERT INTO City(IdState, Name) VALUES('8','Jocoro');
INSERT INTO City(IdState, Name) VALUES('8','Lolotiquillo');
INSERT INTO City(IdState, Name) VALUES('8','Meanguera');
INSERT INTO City(IdState, Name) VALUES('8','Osicala');
INSERT INTO City(IdState, Name) VALUES('8','Perquín');
INSERT INTO City(IdState, Name) VALUES('8','San Carlos');
INSERT INTO City(IdState, Name) VALUES('8','San Fernando');
INSERT INTO City(IdState, Name) VALUES('8','San Isidro');
INSERT INTO City(IdState, Name) VALUES('8','San Simón');
INSERT INTO City(IdState, Name) VALUES('8','Sensembra');
INSERT INTO City(IdState, Name) VALUES('8','Sociedad');
INSERT INTO City(IdState, Name) VALUES('8','Torola');
INSERT INTO City(IdState, Name) VALUES('8','Yamabal');
INSERT INTO City(IdState, Name) VALUES('8','Yoloaiquiín');
end

begin -- San Miguel, Id State: 9
INSERT INTO State(IdCountry, Name) VALUES('1','San Miguel');

INSERT INTO City(IdState, Name) VALUES('9','Ciudad de San Miguel');
INSERT INTO City(IdState, Name) VALUES('9','Carolina');
INSERT INTO City(IdState, Name) VALUES('9','Chapeltique');
INSERT INTO City(IdState, Name) VALUES('9','Chinameca');
INSERT INTO City(IdState, Name) VALUES('9','Chirilagua');
INSERT INTO City(IdState, Name) VALUES('9','Ciudad Barrios');
INSERT INTO City(IdState, Name) VALUES('9','Comacarán');
INSERT INTO City(IdState, Name) VALUES('9','El Tránsito');
INSERT INTO City(IdState, Name) VALUES('9','Lolotique');
INSERT INTO City(IdState, Name) VALUES('9','Moncagua');
INSERT INTO City(IdState, Name) VALUES('9','Nueva Guadalupe');
INSERT INTO City(IdState, Name) VALUES('9','Nuevo Edén de San Juan');
INSERT INTO City(IdState, Name) VALUES('9','Quelepa');
INSERT INTO City(IdState, Name) VALUES('9','San Antonio');
INSERT INTO City(IdState, Name) VALUES('9','San Gerardo');
INSERT INTO City(IdState, Name) VALUES('9','San Jorge');
INSERT INTO City(IdState, Name) VALUES('9','San Luis de la Reina');
INSERT INTO City(IdState, Name) VALUES('9','San Rafael Oriente');
INSERT INTO City(IdState, Name) VALUES('9','Sesori');
INSERT INTO City(IdState, Name) VALUES('9','Uluazapa');
end

begin -- San Salvador, Id State: 10
INSERT INTO State(IdCountry, Name) VALUES('1','San Salvador');

INSERT INTO City(IdState, Name) VALUES('10','San Salvador');
INSERT INTO City(IdState, Name) VALUES('10','Aguilares');
INSERT INTO City(IdState, Name) VALUES('10','Apopa');
INSERT INTO City(IdState, Name) VALUES('10','Ayutuxtepeque');
INSERT INTO City(IdState, Name) VALUES('10','Cuscatancingo');
INSERT INTO City(IdState, Name) VALUES('10','Delgado');
INSERT INTO City(IdState, Name) VALUES('10','El Paisnal');
INSERT INTO City(IdState, Name) VALUES('10','Guazapa');
INSERT INTO City(IdState, Name) VALUES('10','Ilopango');
INSERT INTO City(IdState, Name) VALUES('10','Mejicanos');
INSERT INTO City(IdState, Name) VALUES('10','Nejapa');
INSERT INTO City(IdState, Name) VALUES('10','Panchimalco');
INSERT INTO City(IdState, Name) VALUES('10','Rosario de Mora');
INSERT INTO City(IdState, Name) VALUES('10','San Marcos');
INSERT INTO City(IdState, Name) VALUES('10','San Martín');
INSERT INTO City(IdState, Name) VALUES('10','Santiago Texancuangos');
INSERT INTO City(IdState, Name) VALUES('10','Santo Tomás');
INSERT INTO City(IdState, Name) VALUES('10','Soyapango');
INSERT INTO City(IdState, Name) VALUES('10','Tonacatepeque');
end

begin -- San Vicente, Id State: 11
INSERT INTO State(IdCountry, Name) VALUES('1','San Vicente');

INSERT INTO City(IdState, Name) VALUES('11','San Vicente');
INSERT INTO City(IdState, Name) VALUES('11','Apastepeque');
INSERT INTO City(IdState, Name) VALUES('11','Guadalupe');
INSERT INTO City(IdState, Name) VALUES('11','San Cayetano Istepeque');
INSERT INTO City(IdState, Name) VALUES('11','San Esteban Catarina');
INSERT INTO City(IdState, Name) VALUES('11','San Ildefonso');
INSERT INTO City(IdState, Name) VALUES('11','San Lorenzo');
INSERT INTO City(IdState, Name) VALUES('11','San Sebastián');
INSERT INTO City(IdState, Name) VALUES('11','Santa Clara');
INSERT INTO City(IdState, Name) VALUES('11','Santo Domingo');
INSERT INTO City(IdState, Name) VALUES('11','Tecoluca');
INSERT INTO City(IdState, Name) VALUES('11','Tepetitán');
INSERT INTO City(IdState, Name) VALUES('11','Verapaz');
end

begin -- Santa Ana, Id State: 12
INSERT INTO State(IdCountry, Name) VALUES('1','Santa Ana');

INSERT INTO City(IdState, Name) VALUES('12','Santa Ana');
INSERT INTO City(IdState, Name) VALUES('12','Candelaria de la Frontera');
INSERT INTO City(IdState, Name) VALUES('12','Chalchuapa');
INSERT INTO City(IdState, Name) VALUES('12','Coatepeque');
INSERT INTO City(IdState, Name) VALUES('12','El Congo');
INSERT INTO City(IdState, Name) VALUES('12','El Porvenir');
INSERT INTO City(IdState, Name) VALUES('12','Masahuat');
INSERT INTO City(IdState, Name) VALUES('12','Metapán');
INSERT INTO City(IdState, Name) VALUES('12','San Antonio Pajonal');
INSERT INTO City(IdState, Name) VALUES('12','San Sebastián Salitrillo');
INSERT INTO City(IdState, Name) VALUES('12','Santa Rosa Guachipilín');
INSERT INTO City(IdState, Name) VALUES('12','Santiago de la Frontera');
INSERT INTO City(IdState, Name) VALUES('12','Texistepeque');
end

begin -- Sonsonate, Id State: 13
INSERT INTO State(IdCountry, Name) VALUES('1','Sonsonate');

INSERT INTO City(IdState, Name) VALUES('13','Sonsonate');
INSERT INTO City(IdState, Name) VALUES('13','Acajutla');
INSERT INTO City(IdState, Name) VALUES('13','Armenia');
INSERT INTO City(IdState, Name) VALUES('13','Caluco');
INSERT INTO City(IdState, Name) VALUES('13','Cuisnahuat');
INSERT INTO City(IdState, Name) VALUES('13','Izalco');
INSERT INTO City(IdState, Name) VALUES('13','Juayúa');
INSERT INTO City(IdState, Name) VALUES('13','Nahuizalco');
INSERT INTO City(IdState, Name) VALUES('13','Nahulingo');
INSERT INTO City(IdState, Name) VALUES('13','Salcoatitán');
INSERT INTO City(IdState, Name) VALUES('13','San Antonio del Monte');
INSERT INTO City(IdState, Name) VALUES('13','San Julián');
INSERT INTO City(IdState, Name) VALUES('13','Santa Catarina Masahuat');
INSERT INTO City(IdState, Name) VALUES('13','Santa Isabel Ishuatán');
INSERT INTO City(IdState, Name) VALUES('13','Santo Domingo de Guzmán');
INSERT INTO City(IdState, Name) VALUES('13','Sonzacate');
end

begin -- Usulután, Id State: 14
INSERT INTO State(IdCountry, Name) VALUES('1','Usulután');

INSERT INTO City(IdState, Name) VALUES('14','Usulután');
INSERT INTO City(IdState, Name) VALUES('14','Alegría');
INSERT INTO City(IdState, Name) VALUES('14','Berlín');
INSERT INTO City(IdState, Name) VALUES('14','California');
INSERT INTO City(IdState, Name) VALUES('14','Concepción Batres');
INSERT INTO City(IdState, Name) VALUES('14','El Triunfo');
INSERT INTO City(IdState, Name) VALUES('14','Ereguayquín');
INSERT INTO City(IdState, Name) VALUES('14','Estanzuelas');
INSERT INTO City(IdState, Name) VALUES('14','Jiquilisco');
INSERT INTO City(IdState, Name) VALUES('14','Jucuapa');
INSERT INTO City(IdState, Name) VALUES('14','Jucuarán');
INSERT INTO City(IdState, Name) VALUES('14','Mercedes Umaña');
INSERT INTO City(IdState, Name) VALUES('14','Nueva Granada');
INSERT INTO City(IdState, Name) VALUES('14','Ozatlán');
INSERT INTO City(IdState, Name) VALUES('14','Puerto El Triunfo');
INSERT INTO City(IdState, Name) VALUES('14','San Agustín');
INSERT INTO City(IdState, Name) VALUES('14','San Buenaventura');
INSERT INTO City(IdState, Name) VALUES('14','San Dionisio');
INSERT INTO City(IdState, Name) VALUES('14','San Francisco Javier');
INSERT INTO City(IdState, Name) VALUES('14','Santa Elena');
INSERT INTO City(IdState, Name) VALUES('14','Santa María');
INSERT INTO City(IdState, Name) VALUES('14','Santiago de María');
INSERT INTO City(IdState, Name) VALUES('14','Tecapán');
end

end

begin -- Guatemala, Id Country: 2
INSERT INTO Country(Name) VALUES('Guatemala');

begin -- Alta Verapaz, Id State: 15
INSERT INTO State(IdCountry, Name) VALUES('2','Alta Verapaz');

INSERT INTO City(IdState, Name) VALUES('15','Cobán');
INSERT INTO City(IdState, Name) VALUES('15','Santa Cruz Verapaz');
INSERT INTO City(IdState, Name) VALUES('15','San Cristóbal Verapaz');
INSERT INTO City(IdState, Name) VALUES('15','Tactic');
INSERT INTO City(IdState, Name) VALUES('15','Tamahú');
INSERT INTO City(IdState, Name) VALUES('15','San Miguel Tucurú');
INSERT INTO City(IdState, Name) VALUES('15','Panzóz');
INSERT INTO City(IdState, Name) VALUES('15','Senahú');
INSERT INTO City(IdState, Name) VALUES('15','San pedro Carchá');
INSERT INTO City(IdState, Name) VALUES('15','San Juan Chamelco');
INSERT INTO City(IdState, Name) VALUES('15','San Agustín Lanquín');
INSERT INTO City(IdState, Name) VALUES('15','Santa María Cahabón');
INSERT INTO City(IdState, Name) VALUES('15','Chisec');
INSERT INTO City(IdState, Name) VALUES('15','Chahal');
INSERT INTO City(IdState, Name) VALUES('15','Fray Bartolomé de las Casas');
INSERT INTO City(IdState, Name) VALUES('15','Santa Catalina La Tinta');
INSERT INTO City(IdState, Name) VALUES('15','Raxruhá');
end

begin -- Baja Verapaz, Id State: 16
INSERT INTO State(IdCountry, Name) VALUES('2','Baja Verapaz');

INSERT INTO City(IdState, Name) VALUES('16','Salamá');
INSERT INTO City(IdState, Name) VALUES('16','San Miguel Chicaj');
INSERT INTO City(IdState, Name) VALUES('16','Rabinal');
INSERT INTO City(IdState, Name) VALUES('16','Cubulco');
INSERT INTO City(IdState, Name) VALUES('16','Granados');
INSERT INTO City(IdState, Name) VALUES('16','Santa Cruz el Chol');
INSERT INTO City(IdState, Name) VALUES('16','San Jerónimo');
INSERT INTO City(IdState, Name) VALUES('16','Purulhá');
end

begin -- Chimaltenango, Id State: 17
INSERT INTO State(IdCountry, Name) VALUES('2','Chimaltenango');

INSERT INTO City(IdState, Name) VALUES('17','Chimaltenango');
INSERT INTO City(IdState, Name) VALUES('17','San José Poaquil');
INSERT INTO City(IdState, Name) VALUES('17','San Martín Jilotepeque');
INSERT INTO City(IdState, Name) VALUES('17','San Juan Comalapa');
INSERT INTO City(IdState, Name) VALUES('17','Santa Apolonia');
INSERT INTO City(IdState, Name) VALUES('17','Tecpán');
INSERT INTO City(IdState, Name) VALUES('17','Patzún');
INSERT INTO City(IdState, Name) VALUES('17','San Miguel Pochuta');
INSERT INTO City(IdState, Name) VALUES('17','Patzicia');
INSERT INTO City(IdState, Name) VALUES('17','Santa Cruz Balanyá');
INSERT INTO City(IdState, Name) VALUES('17','Acatenango');
INSERT INTO City(IdState, Name) VALUES('17','San Pedro Yepocapa');
INSERT INTO City(IdState, Name) VALUES('17','San Andrés Itzapa');
INSERT INTO City(IdState, Name) VALUES('17','Parramos');
INSERT INTO City(IdState, Name) VALUES('17','Zaragoza');
INSERT INTO City(IdState, Name) VALUES('17','El Tejar');
end

begin -- Chiquimula, Id State: 18
INSERT INTO State(IdCountry, Name) VALUES('2','Chiquimula');

INSERT INTO City(IdState, Name) VALUES('18','Chiquimula');
INSERT INTO City(IdState, Name) VALUES('18','Jocotán');
INSERT INTO City(IdState, Name) VALUES('18','Esquipulas');
INSERT INTO City(IdState, Name) VALUES('18','Camotán');
INSERT INTO City(IdState, Name) VALUES('18','Quezaltepeque');
INSERT INTO City(IdState, Name) VALUES('18','Olopa');
INSERT INTO City(IdState, Name) VALUES('18','Ipala');
INSERT INTO City(IdState, Name) VALUES('18','San Juan Hermita');
INSERT INTO City(IdState, Name) VALUES('18','Concepción Las Minas');
INSERT INTO City(IdState, Name) VALUES('18','San Jacinto');
INSERT INTO City(IdState, Name) VALUES('18','San José La Arada');
end

begin -- Petén, Id State: 19
INSERT INTO State(IdCountry, Name) VALUES('2','Petén');

INSERT INTO City(IdState, Name) VALUES('19','Flores');
INSERT INTO City(IdState, Name) VALUES('19','San José');
INSERT INTO City(IdState, Name) VALUES('19','San Benito');
INSERT INTO City(IdState, Name) VALUES('19','San Andrés');
INSERT INTO City(IdState, Name) VALUES('19','La Libertad');
INSERT INTO City(IdState, Name) VALUES('19','San Francisco');
INSERT INTO City(IdState, Name) VALUES('19','Santa Ana');
INSERT INTO City(IdState, Name) VALUES('19','Dolores');
INSERT INTO City(IdState, Name) VALUES('19','San Luis');
INSERT INTO City(IdState, Name) VALUES('19','Sayaxché');
INSERT INTO City(IdState, Name) VALUES('19','Melchor de Mencos');
INSERT INTO City(IdState, Name) VALUES('19','Poptún');
INSERT INTO City(IdState, Name) VALUES('19','El Chal');
INSERT INTO City(IdState, Name) VALUES('19','Isla de Flores, Santa Elena de la Cruz');
end

begin -- EL Progreso, Id State: 20
INSERT INTO State(IdCountry, Name) VALUES('2','El Progreso');

INSERT INTO City(IdState, Name) VALUES('20','El Jícaro');
INSERT INTO City(IdState, Name) VALUES('20','Morazán');
INSERT INTO City(IdState, Name) VALUES('20','San Agustín Acasaguastlán');
INSERT INTO City(IdState, Name) VALUES('20','San Antonio La Paz');
INSERT INTO City(IdState, Name) VALUES('20','San Cristóbal Acasaguastlán');
INSERT INTO City(IdState, Name) VALUES('20','Sanarate');
INSERT INTO City(IdState, Name) VALUES('20','Guastatoya');
INSERT INTO City(IdState, Name) VALUES('20','Sansare');
end

begin -- Quiché, Id State: 21
INSERT INTO State(IdCountry, Name) VALUES('2','Quiché');

INSERT INTO City(IdState, Name) VALUES('21','Santa Cruz del Quiché');
INSERT INTO City(IdState, Name) VALUES('21','Quiché');
INSERT INTO City(IdState, Name) VALUES('21','Chinique');
INSERT INTO City(IdState, Name) VALUES('21','Zacualpa');
INSERT INTO City(IdState, Name) VALUES('21','Chajul');
INSERT INTO City(IdState, Name) VALUES('21','Santo Tomás Chichicastenango');
INSERT INTO City(IdState, Name) VALUES('21','Patzité');
INSERT INTO City(IdState, Name) VALUES('21','San Antonio Ilotenango');
INSERT INTO City(IdState, Name) VALUES('21','San pedro Jocopilas');
INSERT INTO City(IdState, Name) VALUES('21','Cunén');
INSERT INTO City(IdState, Name) VALUES('21','San Juan Cotzal');
INSERT INTO City(IdState, Name) VALUES('21','Santa María Joyabaj');
INSERT INTO City(IdState, Name) VALUES('21','Santa María Nebaj');
INSERT INTO City(IdState, Name) VALUES('21','San Andrés Sajcabajá');
INSERT INTO City(IdState, Name) VALUES('21','Uspantán');
INSERT INTO City(IdState, Name) VALUES('21','Sacapulas');
INSERT INTO City(IdState, Name) VALUES('21','San Bartolomé Jocotenango');
INSERT INTO City(IdState, Name) VALUES('21','Canillá');
INSERT INTO City(IdState, Name) VALUES('21','Chicamán');
INSERT INTO City(IdState, Name) VALUES('21','Ixcán');
INSERT INTO City(IdState, Name) VALUES('21','Pachalum');
end

begin -- Escuintla, Id State: 22
INSERT INTO State(IdCountry, Name) VALUES('2','Escuintla');

INSERT INTO City(IdState, Name) VALUES('22','Escuintla');
INSERT INTO City(IdState, Name) VALUES('22','Santa Lucía Cotzumalguapa');
INSERT INTO City(IdState, Name) VALUES('22','La Democracia');
INSERT INTO City(IdState, Name) VALUES('22','Siquinalá');
INSERT INTO City(IdState, Name) VALUES('22','Masagua');
INSERT INTO City(IdState, Name) VALUES('22','Tiquisate');
INSERT INTO City(IdState, Name) VALUES('22','La Gomera');
INSERT INTO City(IdState, Name) VALUES('22','Guaganazapa');
INSERT INTO City(IdState, Name) VALUES('22','San José');
INSERT INTO City(IdState, Name) VALUES('22','Itzapa');
INSERT INTO City(IdState, Name) VALUES('22','Palín');
INSERT INTO City(IdState, Name) VALUES('22','San Vicente Pacaya');
INSERT INTO City(IdState, Name) VALUES('22','Nueva Concepción');
INSERT INTO City(IdState, Name) VALUES('22','Sipacate');
end

begin -- Guatemala, Id State: 23
INSERT INTO State(IdCountry, Name) VALUES('2','Guatemala');

INSERT INTO City(IdState, Name) VALUES('23','Santa Catarina Pinula');
INSERT INTO City(IdState, Name) VALUES('23','San José Pinula');
INSERT INTO City(IdState, Name) VALUES('23','Guatemala');
INSERT INTO City(IdState, Name) VALUES('23','San José del Golfo');
INSERT INTO City(IdState, Name) VALUES('23','Palencia');
INSERT INTO City(IdState, Name) VALUES('23','Chinautla');
INSERT INTO City(IdState, Name) VALUES('23','San Pedro Ayampuc');
INSERT INTO City(IdState, Name) VALUES('23','Mixco');
INSERT INTO City(IdState, Name) VALUES('23','San Pedro Sacatepéquez');
INSERT INTO City(IdState, Name) VALUES('23','San Juan Sacatepéquez');
INSERT INTO City(IdState, Name) VALUES('23','Chuarrancho');
INSERT INTO City(IdState, Name) VALUES('23','San Raymundo');
INSERT INTO City(IdState, Name) VALUES('23','Fraijanes');
INSERT INTO City(IdState, Name) VALUES('23','Amatitlán');
INSERT INTO City(IdState, Name) VALUES('23','Villa Nueva');
INSERT INTO City(IdState, Name) VALUES('23','Villa Canales');
INSERT INTO City(IdState, Name) VALUES('23','San Miguel Petapa');
end

begin -- Huehuetenango, Id State: 24
INSERT INTO State(IdCountry, Name) VALUES('2','Huehuetenango');

INSERT INTO City(IdState, Name) VALUES('24','Huehuetenango');
INSERT INTO City(IdState, Name) VALUES('24','Chiantla');
INSERT INTO City(IdState, Name) VALUES('24','Malacatancito');
INSERT INTO City(IdState, Name) VALUES('24','Cuilco');
INSERT INTO City(IdState, Name) VALUES('24','Nentón');
INSERT INTO City(IdState, Name) VALUES('24','San Pedro Necta');
INSERT INTO City(IdState, Name) VALUES('24','Jacaltenango');
INSERT INTO City(IdState, Name) VALUES('24','Soloma');
INSERT INTO City(IdState, Name) VALUES('24','Ixtahuacán');
INSERT INTO City(IdState, Name) VALUES('24','Santa Bárbara');
INSERT INTO City(IdState, Name) VALUES('24','La Libertad');
INSERT INTO City(IdState, Name) VALUES('24','La Democracia');
INSERT INTO City(IdState, Name) VALUES('24','San Miguel Acatán');
INSERT INTO City(IdState, Name) VALUES('24','San Rafael La Independencia');
INSERT INTO City(IdState, Name) VALUES('24','Todos Santos Cuchumatán');
INSERT INTO City(IdState, Name) VALUES('24','San Juan Atitlán');
INSERT INTO City(IdState, Name) VALUES('24','Santa Eulalia');
INSERT INTO City(IdState, Name) VALUES('24','San Mateo Ixtatán');
INSERT INTO City(IdState, Name) VALUES('24','Colotenango');
INSERT INTO City(IdState, Name) VALUES('24','San Sebastián Huehuetenango');
INSERT INTO City(IdState, Name) VALUES('24','Tectitán');
INSERT INTO City(IdState, Name) VALUES('24','Concepción Huista');
INSERT INTO City(IdState, Name) VALUES('24','San Juan Ixcoy');
INSERT INTO City(IdState, Name) VALUES('24','San Antonio Huista');
INSERT INTO City(IdState, Name) VALUES('24','Santa Cruz Barillas');
INSERT INTO City(IdState, Name) VALUES('24','San Sebastián Coatán');
INSERT INTO City(IdState, Name) VALUES('24','Aguacatán');
INSERT INTO City(IdState, Name) VALUES('24','San Rafael Petzal');
INSERT INTO City(IdState, Name) VALUES('24','San Gaspar Ixchil');
INSERT INTO City(IdState, Name) VALUES('24','Santiago Chimaltenango');
INSERT INTO City(IdState, Name) VALUES('24','Santa Ana Huista');
INSERT INTO City(IdState, Name) VALUES('24','Petatán');
INSERT INTO City(IdState, Name) VALUES('24','San Ildefonso Ixtahuacán');
end

begin -- Izabal, Id State: 25
INSERT INTO State(IdCountry, Name) VALUES('2','Izabal');

INSERT INTO City(IdState, Name) VALUES('25','Morales');
INSERT INTO City(IdState, Name) VALUES('25','Los Amates');
INSERT INTO City(IdState, Name) VALUES('25','Livingston');
INSERT INTO City(IdState, Name) VALUES('25','El Estor');
INSERT INTO City(IdState, Name) VALUES('25','Puerto Barrios');
end

begin -- Jalapa, Id State: 26
INSERT INTO State(IdCountry, Name) VALUES('2','Jalapa');

INSERT INTO City(IdState, Name) VALUES('26','Jalapa');
INSERT INTO City(IdState, Name) VALUES('26','San Pedro Pinula');
INSERT INTO City(IdState, Name) VALUES('26','San Luis Jilotepeque');
INSERT INTO City(IdState, Name) VALUES('26','San Manuel Chaparrón');
INSERT INTO City(IdState, Name) VALUES('26','San Carlos Alzatate');
INSERT INTO City(IdState, Name) VALUES('26','Monjas');
INSERT INTO City(IdState, Name) VALUES('26','Mataquescuintla');
end

begin -- Jutiapa, Id State: 27
INSERT INTO State(IdCountry, Name) VALUES('2','Jutiapa');

INSERT INTO City(IdState, Name) VALUES('27','Jutiapa');
INSERT INTO City(IdState, Name) VALUES('27','El Progreso');
INSERT INTO City(IdState, Name) VALUES('27','Santa Catarina Mita');
INSERT INTO City(IdState, Name) VALUES('27','Agua Blanca');
INSERT INTO City(IdState, Name) VALUES('27','Asunción Mita');
INSERT INTO City(IdState, Name) VALUES('27','Yupiltepeque');
INSERT INTO City(IdState, Name) VALUES('27','Atescatempa');
INSERT INTO City(IdState, Name) VALUES('27','Jerez');
INSERT INTO City(IdState, Name) VALUES('27','El Adelanto');
INSERT INTO City(IdState, Name) VALUES('27','Zapotitlán');
INSERT INTO City(IdState, Name) VALUES('27','Comapa');
INSERT INTO City(IdState, Name) VALUES('27','Jalpatagua');
INSERT INTO City(IdState, Name) VALUES('27','Conguaco');
INSERT INTO City(IdState, Name) VALUES('27','Moyuta');
INSERT INTO City(IdState, Name) VALUES('27','Pasaco');
INSERT INTO City(IdState, Name) VALUES('27','Quesada');
INSERT INTO City(IdState, Name) VALUES('27','San José Acatempa');
end

begin -- Quetzaltenango
INSERT INTO State(IdCountry, Name) VALUES('2','Quetzaltenango');

INSERT INTO City(IdState, Name) VALUES('28','Quetzaltenango');
INSERT INTO City(IdState, Name) VALUES('28','Salcajá');
INSERT INTO City(IdState, Name) VALUES('28','Olintepeque');
INSERT INTO City(IdState, Name) VALUES('28','San Carlos Sija');
INSERT INTO City(IdState, Name) VALUES('28','Sibilia');
INSERT INTO City(IdState, Name) VALUES('28','Cabricán');
INSERT INTO City(IdState, Name) VALUES('28','Cajolá');
INSERT INTO City(IdState, Name) VALUES('28','San Miguel Sigüilá');
INSERT INTO City(IdState, Name) VALUES('28','San Juan Ostuncalco');
INSERT INTO City(IdState, Name) VALUES('28','San Mateo');
INSERT INTO City(IdState, Name) VALUES('28','Concepción Chiquirichapa');
INSERT INTO City(IdState, Name) VALUES('28','San Martín Sacatepéquez');
INSERT INTO City(IdState, Name) VALUES('28','Almolonga');
INSERT INTO City(IdState, Name) VALUES('28','Cantel');
INSERT INTO City(IdState, Name) VALUES('28','Huitán');
INSERT INTO City(IdState, Name) VALUES('28','Zunil');
INSERT INTO City(IdState, Name) VALUES('28','Colomba');
INSERT INTO City(IdState, Name) VALUES('28','San Francisco La Unión');
INSERT INTO City(IdState, Name) VALUES('28','El Palmar');
INSERT INTO City(IdState, Name) VALUES('28','Coatepeque');
INSERT INTO City(IdState, Name) VALUES('28','Génova');
INSERT INTO City(IdState, Name) VALUES('28','Flores Costa Cuca');
INSERT INTO City(IdState, Name) VALUES('28','La Esperanza');
INSERT INTO City(IdState, Name) VALUES('28','Palestina de Los Altos');
end

begin -- Retalhuleu, Id State: 29
INSERT INTO State(IdCountry, Name) VALUES('2','Retalhuleu');

INSERT INTO City(IdState, Name) VALUES('29','Retalhuleu');
INSERT INTO City(IdState, Name) VALUES('29','San Sebastián');
INSERT INTO City(IdState, Name) VALUES('29','Santa Cruz Muluá');
INSERT INTO City(IdState, Name) VALUES('29','San Martín Zapotitlán');
INSERT INTO City(IdState, Name) VALUES('29','San Felipe');
INSERT INTO City(IdState, Name) VALUES('29','San Andrés Villa Seca');
INSERT INTO City(IdState, Name) VALUES('29','Champerico');
INSERT INTO City(IdState, Name) VALUES('29','Nuevo San Carlos');
INSERT INTO City(IdState, Name) VALUES('29','El Asintal');
end

begin -- Sacatepéque, Id State: 30
INSERT INTO State(IdCountry, Name) VALUES('2','Sacatepéquez');

INSERT INTO City(IdState, Name) VALUES('30','Alotenango');
INSERT INTO City(IdState, Name) VALUES('30','Antigua Guatemala');
INSERT INTO City(IdState, Name) VALUES('30','Ciudad Vieja');
INSERT INTO City(IdState, Name) VALUES('30','Jocotenango');
INSERT INTO City(IdState, Name) VALUES('30','Magdalena Milpas Altas');
INSERT INTO City(IdState, Name) VALUES('30','Pastores');
INSERT INTO City(IdState, Name) VALUES('30','San Antonio Aguas Calientes');
INSERT INTO City(IdState, Name) VALUES('30','San Bartolomé Milpas Altas');
INSERT INTO City(IdState, Name) VALUES('30','San Lucas Sacatepéquez');
INSERT INTO City(IdState, Name) VALUES('30','San Miguel Dueñas');
INSERT INTO City(IdState, Name) VALUES('30','Santa Catarina Barahona');
INSERT INTO City(IdState, Name) VALUES('30','Santa Lucía Milpas Altas');
INSERT INTO City(IdState, Name) VALUES('30','Santa María de Jesús');
INSERT INTO City(IdState, Name) VALUES('30','Santiago Sacatepéquez');
INSERT INTO City(IdState, Name) VALUES('30','Santa Domingo Xenacoj');
INSERT INTO City(IdState, Name) VALUES('30','Sumpango');
end

begin -- San Marcos, Id State: 31
INSERT INTO State(IdCountry, Name) VALUES('2','San Marcos');

INSERT INTO City(IdState, Name) VALUES('31','San Marcos');
INSERT INTO City(IdState, Name) VALUES('31','Ayutla');
INSERT INTO City(IdState, Name) VALUES('31','Catarina');
INSERT INTO City(IdState, Name) VALUES('31','Comitancillo');
INSERT INTO City(IdState, Name) VALUES('31','Concepción Tutuapa');
INSERT INTO City(IdState, Name) VALUES('31','El Quetzal');
INSERT INTO City(IdState, Name) VALUES('31','El Rodeo');
INSERT INTO City(IdState, Name) VALUES('31','El Tumblador');
INSERT INTO City(IdState, Name) VALUES('31','Ixchiguán');
INSERT INTO City(IdState, Name) VALUES('31','La Reforma');
INSERT INTO City(IdState, Name) VALUES('31','Malacatán');
INSERT INTO City(IdState, Name) VALUES('31','Nuevo Progreso');
INSERT INTO City(IdState, Name) VALUES('31','Ocós');
INSERT INTO City(IdState, Name) VALUES('31','Pajapita');
INSERT INTO City(IdState, Name) VALUES('31','Esquipulas Palo Gordo');
INSERT INTO City(IdState, Name) VALUES('31','San Antonio Sacatepéquez');
INSERT INTO City(IdState, Name) VALUES('31','San Cristobal Cucho');
INSERT INTO City(IdState, Name) VALUES('31','San José Ojetenam');
INSERT INTO City(IdState, Name) VALUES('31','San Lorenzo');
INSERT INTO City(IdState, Name) VALUES('31','San Miguel Ixtahuacán');
INSERT INTO City(IdState, Name) VALUES('31','San Pablo');
INSERT INTO City(IdState, Name) VALUES('31','San Pedro Sacatepéquez');
INSERT INTO City(IdState, Name) VALUES('31','San Rafael Pie de la Cuesta');
INSERT INTO City(IdState, Name) VALUES('31','Sibinal');
INSERT INTO City(IdState, Name) VALUES('31','Sipacapa');
INSERT INTO City(IdState, Name) VALUES('31','Tacaná');
INSERT INTO City(IdState, Name) VALUES('31','Tajumulco');
INSERT INTO City(IdState, Name) VALUES('31','Tejutla');
INSERT INTO City(IdState, Name) VALUES('31','Río Blanco');
INSERT INTO City(IdState, Name) VALUES('31','La Blanca');
end

begin -- Santa Rosa, Id State: 32
INSERT INTO State(IdCountry, Name) VALUES('2','Santa Rosa');

INSERT INTO City(IdState, Name) VALUES('32','Cuilapa');
INSERT INTO City(IdState, Name) VALUES('32','Casillas Santa Rosa');
INSERT INTO City(IdState, Name) VALUES('32','Chiquimulilla');
INSERT INTO City(IdState, Name) VALUES('32','Guazacapán');
INSERT INTO City(IdState, Name) VALUES('32','Nueva Santa Rosa');
INSERT INTO City(IdState, Name) VALUES('32','Oratorio');
INSERT INTO City(IdState, Name) VALUES('32','Pueblo Nuevo Viñas');
INSERT INTO City(IdState, Name) VALUES('32','San Juan Tecuaco');
INSERT INTO City(IdState, Name) VALUES('32','San Rafael Las Flores');
INSERT INTO City(IdState, Name) VALUES('32','Santa Cruz Naranjo');
INSERT INTO City(IdState, Name) VALUES('32','Santa María Ixhuatán');
INSERT INTO City(IdState, Name) VALUES('32','Santa Rosa de Lima');
INSERT INTO City(IdState, Name) VALUES('32','Taxisco');
INSERT INTO City(IdState, Name) VALUES('32','Barberena');
end

begin -- Sololá, Id State: 33
INSERT INTO State(IdCountry, Name) VALUES('2','Sololá');

INSERT INTO City(IdState, Name) VALUES('33','Sololá');
INSERT INTO City(IdState, Name) VALUES('33','Concepción');
INSERT INTO City(IdState, Name) VALUES('33','Nahualá');
INSERT INTO City(IdState, Name) VALUES('33','Panajachel');
INSERT INTO City(IdState, Name) VALUES('33','San Andrés Semetabaj');
INSERT INTO City(IdState, Name) VALUES('33','San Antonio Palopó');
INSERT INTO City(IdState, Name) VALUES('33','San José Chacayá');
INSERT INTO City(IdState, Name) VALUES('33','San Juan La Laguna');
INSERT INTO City(IdState, Name) VALUES('33','San Lucas Tolimán');
INSERT INTO City(IdState, Name) VALUES('33','San Marcos La Laguna');
INSERT INTO City(IdState, Name) VALUES('33','San Pablo La Laguna');
INSERT INTO City(IdState, Name) VALUES('33','San Pedro La Laguna');
INSERT INTO City(IdState, Name) VALUES('33','Santa Catarina Ixtahuacán');
INSERT INTO City(IdState, Name) VALUES('33','Santa Catarina Palopó');
INSERT INTO City(IdState, Name) VALUES('33','Santa Clara La Laguna');
INSERT INTO City(IdState, Name) VALUES('33','Santa Cruz La Laguna');
INSERT INTO City(IdState, Name) VALUES('33','Santa Lucía Utatlán');
INSERT INTO City(IdState, Name) VALUES('33','Santa María Visitación');
INSERT INTO City(IdState, Name) VALUES('33','Santiago Atitlán');
end

begin -- Suchitepéque, Id State: 34
INSERT INTO State(IdCountry, Name) VALUES('2','Suchitepéquez');

INSERT INTO City(IdState, Name) VALUES('34','Mazatenango');
INSERT INTO City(IdState, Name) VALUES('34','Cuyotenango');
INSERT INTO City(IdState, Name) VALUES('34','San Francisco Zapotitlán');
INSERT INTO City(IdState, Name) VALUES('34','San Bernardino');
INSERT INTO City(IdState, Name) VALUES('34','San José El Ídolo');
INSERT INTO City(IdState, Name) VALUES('34','Santo Domingo Suchitepéquez');
INSERT INTO City(IdState, Name) VALUES('34','San Lorenzo');
INSERT INTO City(IdState, Name) VALUES('34','Samayac');
INSERT INTO City(IdState, Name) VALUES('34','San Pablo Jocopilas');
INSERT INTO City(IdState, Name) VALUES('34','San Antonio Suchitepéquez');
INSERT INTO City(IdState, Name) VALUES('34','San Miguel Panán');
INSERT INTO City(IdState, Name) VALUES('34','San Gabriel');
INSERT INTO City(IdState, Name) VALUES('34','Chicacao');
INSERT INTO City(IdState, Name) VALUES('34','Patulul');
INSERT INTO City(IdState, Name) VALUES('34','Santa Bárbara');
INSERT INTO City(IdState, Name) VALUES('34','San Juan Bautista');
INSERT INTO City(IdState, Name) VALUES('34','Santo Tomás La Unión');
INSERT INTO City(IdState, Name) VALUES('34','Zunilito');
INSERT INTO City(IdState, Name) VALUES('34','Pueblo Nuevo');
INSERT INTO City(IdState, Name) VALUES('34','Río Bravo');
INSERT INTO City(IdState, Name) VALUES('34','San José La Máquina');
end

begin -- Totonicapán, Id State: 35
INSERT INTO State(IdCountry, Name) VALUES('2','Totonicapán');

INSERT INTO City(IdState, Name) VALUES('35','Totonicapán');
INSERT INTO City(IdState, Name) VALUES('35','San Cristobal Totonicapán');
INSERT INTO City(IdState, Name) VALUES('35','San Francisco El Alto');
INSERT INTO City(IdState, Name) VALUES('35','San Andrés Xecul');
INSERT INTO City(IdState, Name) VALUES('35','Momostenango');
INSERT INTO City(IdState, Name) VALUES('35','Santa María Chiquimula');
INSERT INTO City(IdState, Name) VALUES('35','Santa Lucía La Reforma');
INSERT INTO City(IdState, Name) VALUES('35','San Bartolo');
end

begin -- Zacapa, Id State: 36
INSERT INTO State(IdCountry, Name) VALUES('2','Zacapa');

INSERT INTO City(IdState, Name) VALUES('36','Cabañas');
INSERT INTO City(IdState, Name) VALUES('36','Estanzuela');
INSERT INTO City(IdState, Name) VALUES('36','Gualán');
INSERT INTO City(IdState, Name) VALUES('36','Huité');
INSERT INTO City(IdState, Name) VALUES('36','La Unión');
INSERT INTO City(IdState, Name) VALUES('36','Río Hondo');
INSERT INTO City(IdState, Name) VALUES('36','San Jorge');
INSERT INTO City(IdState, Name) VALUES('36','San Diego');
INSERT INTO City(IdState, Name) VALUES('36','Teculután');
INSERT INTO City(IdState, Name) VALUES('36','Usumatlán');
INSERT INTO City(IdState, Name) VALUES('36','Zacapa');
end

end

begin -- Honduras, Id Country: 3
INSERT INTO Country(Name) VALUES('Honduras');

begin -- Atlántida, Id State: 37
INSERT INTO State(IdCountry, Name) VALUES('3','Atlántida');

INSERT INTO City(IdState, Name) VALUES('37','La Ceiba');
INSERT INTO City(IdState, Name) VALUES('37','El Porvenir');
INSERT INTO City(IdState, Name) VALUES('37','Tela');
INSERT INTO City(IdState, Name) VALUES('37','Jutiapa');
INSERT INTO City(IdState, Name) VALUES('37','La Masica');
INSERT INTO City(IdState, Name) VALUES('37','San Francisco');
INSERT INTO City(IdState, Name) VALUES('37','Arizona');
INSERT INTO City(IdState, Name) VALUES('37','Esparta');
end

begin -- Colón, Id State: 38
INSERT INTO State(IdCountry, Name) VALUES('3','Colón');

INSERT INTO City(IdState, Name) VALUES('38','Trujillo');
INSERT INTO City(IdState, Name) VALUES('38','Balfate');
INSERT INTO City(IdState, Name) VALUES('38','Iriona');
INSERT INTO City(IdState, Name) VALUES('38','Limón');
INSERT INTO City(IdState, Name) VALUES('38','Sabá');
INSERT INTO City(IdState, Name) VALUES('38','Santa Fé');
INSERT INTO City(IdState, Name) VALUES('38','Santa Rosa de Aguán');
INSERT INTO City(IdState, Name) VALUES('38','Sonaguera');
INSERT INTO City(IdState, Name) VALUES('38','Tocoa');
INSERT INTO City(IdState, Name) VALUES('38','Bonito Oriental');
end

begin -- Comayagua, Id State: 39
INSERT INTO State(IdCountry, Name) VALUES('3','Comayagua');

INSERT INTO City(IdState, Name) VALUES('39','Comayagua');
INSERT INTO City(IdState, Name) VALUES('39','Ajuterique');
INSERT INTO City(IdState, Name) VALUES('39','El Rosario');
INSERT INTO City(IdState, Name) VALUES('39','Esquías');
INSERT INTO City(IdState, Name) VALUES('39','Humuya');
INSERT INTO City(IdState, Name) VALUES('39','La Libertad');
INSERT INTO City(IdState, Name) VALUES('39','Lamaní');
INSERT INTO City(IdState, Name) VALUES('39','La Trinidad');
INSERT INTO City(IdState, Name) VALUES('39','Lejamani');
INSERT INTO City(IdState, Name) VALUES('39','Meambar');
INSERT INTO City(IdState, Name) VALUES('39','Minas de Oro');
INSERT INTO City(IdState, Name) VALUES('39','Ojos de Agua');
INSERT INTO City(IdState, Name) VALUES('39','San Jerónimo');
INSERT INTO City(IdState, Name) VALUES('39','San José de Comayagua');
INSERT INTO City(IdState, Name) VALUES('39','San José del Potrero');
INSERT INTO City(IdState, Name) VALUES('39','San Luis');
INSERT INTO City(IdState, Name) VALUES('39','San Sebastián');
INSERT INTO City(IdState, Name) VALUES('39','Siguatepeque');
INSERT INTO City(IdState, Name) VALUES('39','Villa de San Antonio');
INSERT INTO City(IdState, Name) VALUES('39','Las Lajas');
INSERT INTO City(IdState, Name) VALUES('39','Taulabé');
end

begin -- Copán, Id State: 40
INSERT INTO State(IdCountry, Name) VALUES('3','Copán');

INSERT INTO City(IdState, Name) VALUES('40','Santa Rosa de Copán');
INSERT INTO City(IdState, Name) VALUES('40','Cabañas');
INSERT INTO City(IdState, Name) VALUES('40','Concepción');
INSERT INTO City(IdState, Name) VALUES('40','Copán Ruinas');
INSERT INTO City(IdState, Name) VALUES('40','Corquín');
INSERT INTO City(IdState, Name) VALUES('40','Cucuyagua');
INSERT INTO City(IdState, Name) VALUES('40','Dolores');
INSERT INTO City(IdState, Name) VALUES('40','Dulce Nombre');
INSERT INTO City(IdState, Name) VALUES('40','El Paraíso');
INSERT INTO City(IdState, Name) VALUES('40','Florida');
INSERT INTO City(IdState, Name) VALUES('40','La Jigua');
INSERT INTO City(IdState, Name) VALUES('40','La Unión');
INSERT INTO City(IdState, Name) VALUES('40','Nueva Arcadia');
INSERT INTO City(IdState, Name) VALUES('40','San Agustín');
INSERT INTO City(IdState, Name) VALUES('40','San Antonio');
INSERT INTO City(IdState, Name) VALUES('40','San Jerónimo');
INSERT INTO City(IdState, Name) VALUES('40','San José');
INSERT INTO City(IdState, Name) VALUES('40','San Juan de Opoa');
INSERT INTO City(IdState, Name) VALUES('40','San Nicolás');
INSERT INTO City(IdState, Name) VALUES('40','San Pedro');
INSERT INTO City(IdState, Name) VALUES('40','Santa Rita');
INSERT INTO City(IdState, Name) VALUES('40','Trinidad de Copán');
INSERT INTO City(IdState, Name) VALUES('40','Veracruz');
end

begin -- Cortés, Id State: 41
INSERT INTO State(IdCountry, Name) VALUES('3','Cortés');

INSERT INTO City(IdState, Name) VALUES('41','San Pedro Sula');
INSERT INTO City(IdState, Name) VALUES('41','Choloma');
INSERT INTO City(IdState, Name) VALUES('41','Omoa');
INSERT INTO City(IdState, Name) VALUES('41','Pimienta');
INSERT INTO City(IdState, Name) VALUES('41','Potrerillos');
INSERT INTO City(IdState, Name) VALUES('41','Puerto Cortés');
INSERT INTO City(IdState, Name) VALUES('41','San Antonio de Cortés');
INSERT INTO City(IdState, Name) VALUES('41','San Francisco de Yojoa');
INSERT INTO City(IdState, Name) VALUES('41','San Manuel');
INSERT INTO City(IdState, Name) VALUES('41','Santa Cruz de Yojoa');
INSERT INTO City(IdState, Name) VALUES('41','Villanueva');
INSERT INTO City(IdState, Name) VALUES('41','La Lima');
end

begin -- Choluteca, Id State: 42
INSERT INTO State(IdCountry, Name) VALUES('3','Choluteca');

INSERT INTO City(IdState, Name) VALUES('42','Choluteca');
INSERT INTO City(IdState, Name) VALUES('42','Apacilagua');
INSERT INTO City(IdState, Name) VALUES('42','Concepción de María');
INSERT INTO City(IdState, Name) VALUES('42','Duyure');
INSERT INTO City(IdState, Name) VALUES('42','El Corpus');
INSERT INTO City(IdState, Name) VALUES('42','El Triunfo');
INSERT INTO City(IdState, Name) VALUES('42','Marcovia');
INSERT INTO City(IdState, Name) VALUES('42','Morolica');
INSERT INTO City(IdState, Name) VALUES('42','Namasigue');
INSERT INTO City(IdState, Name) VALUES('42','Orocuina');
INSERT INTO City(IdState, Name) VALUES('42','Pespire');
INSERT INTO City(IdState, Name) VALUES('42','San Antonio de Flores');
INSERT INTO City(IdState, Name) VALUES('42','San Isidro');
INSERT INTO City(IdState, Name) VALUES('42','San José');
INSERT INTO City(IdState, Name) VALUES('42','San Marcos de Colón');
INSERT INTO City(IdState, Name) VALUES('42','Santa Ana de Yusguare');
end

begin -- El Paraíso, Id State: 43
INSERT INTO State(IdCountry, Name) VALUES('3','El Paraíso');

INSERT INTO City(IdState, Name) VALUES('43','Yuscarán');
INSERT INTO City(IdState, Name) VALUES('43','Alauca');
INSERT INTO City(IdState, Name) VALUES('43','Danlí');
INSERT INTO City(IdState, Name) VALUES('43','El Paraíso');
INSERT INTO City(IdState, Name) VALUES('43','Güinope');
INSERT INTO City(IdState, Name) VALUES('43','Jacaleapa');
INSERT INTO City(IdState, Name) VALUES('43','Liure');
INSERT INTO City(IdState, Name) VALUES('43','Morocelí');
INSERT INTO City(IdState, Name) VALUES('43','Oropolí');
INSERT INTO City(IdState, Name) VALUES('43','Potrerillos');
INSERT INTO City(IdState, Name) VALUES('43','San Antonio de Flores');
INSERT INTO City(IdState, Name) VALUES('43','San Lucas');
INSERT INTO City(IdState, Name) VALUES('43','San Matías');
INSERT INTO City(IdState, Name) VALUES('43','Soledad');
INSERT INTO City(IdState, Name) VALUES('43','Teupasenti');
INSERT INTO City(IdState, Name) VALUES('43','Texiguat');
INSERT INTO City(IdState, Name) VALUES('43','Vado Ancho');
INSERT INTO City(IdState, Name) VALUES('43','Yauyupe');
INSERT INTO City(IdState, Name) VALUES('43','Trojes');
end

begin -- Francisco Morazán, Id State: 44
INSERT INTO State(IdCountry, Name) VALUES('3','Francisco Morazán');

INSERT INTO City(IdState, Name) VALUES('44','Distrito Central (Tegucigalpa)');
INSERT INTO City(IdState, Name) VALUES('44','Alubarén');
INSERT INTO City(IdState, Name) VALUES('44','Cedros');
INSERT INTO City(IdState, Name) VALUES('44','Curarén');
INSERT INTO City(IdState, Name) VALUES('44','El Porvenir');
INSERT INTO City(IdState, Name) VALUES('44','Guaimaca');
INSERT INTO City(IdState, Name) VALUES('44','La Libertad');
INSERT INTO City(IdState, Name) VALUES('44','La Venta');
INSERT INTO City(IdState, Name) VALUES('44','Lepaterique');
INSERT INTO City(IdState, Name) VALUES('44','Maraita');
INSERT INTO City(IdState, Name) VALUES('44','Marale');
INSERT INTO City(IdState, Name) VALUES('44','Nueva Armenia');
INSERT INTO City(IdState, Name) VALUES('44','Ojojona');
INSERT INTO City(IdState, Name) VALUES('44','Orica');
INSERT INTO City(IdState, Name) VALUES('44','Reitoca');
INSERT INTO City(IdState, Name) VALUES('44','Sabanagrande');
INSERT INTO City(IdState, Name) VALUES('44','San Antonio de Oriente');
INSERT INTO City(IdState, Name) VALUES('44','San Buenaventura');
INSERT INTO City(IdState, Name) VALUES('44','San Ignacio');
INSERT INTO City(IdState, Name) VALUES('44','San Juan de Flores');
INSERT INTO City(IdState, Name) VALUES('44','San Miguelito');
INSERT INTO City(IdState, Name) VALUES('44','Santa Ana');
INSERT INTO City(IdState, Name) VALUES('44','Santa Lucía');
INSERT INTO City(IdState, Name) VALUES('44','Talanga');
INSERT INTO City(IdState, Name) VALUES('44','Tatumbla');
INSERT INTO City(IdState, Name) VALUES('44','Valle de Ángeles');
INSERT INTO City(IdState, Name) VALUES('44','Villa de San Francisco');
INSERT INTO City(IdState, Name) VALUES('44','Vallecillo');
end

begin -- Gracias a Dios, Id State: 45
INSERT INTO State(IdCountry, Name) VALUES('3','Gracias a Dios');

INSERT INTO City(IdState, Name) VALUES('45','Puerto Lempira');
INSERT INTO City(IdState, Name) VALUES('45','Brus Laguna');
INSERT INTO City(IdState, Name) VALUES('45','Ahuas');
INSERT INTO City(IdState, Name) VALUES('45','Juan Francisco Bulnes');
INSERT INTO City(IdState, Name) VALUES('45','Ramón Villeda Morales');
INSERT INTO City(IdState, Name) VALUES('45','Wampusirpe');
end

begin -- Intibucá, Id State: 46
INSERT INTO State(IdCountry, Name) VALUES('3','Intibucá');

INSERT INTO City(IdState, Name) VALUES('46','La Esperanza');
INSERT INTO City(IdState, Name) VALUES('46','Camasca');
INSERT INTO City(IdState, Name) VALUES('46','Colomoncagua');
INSERT INTO City(IdState, Name) VALUES('46','Concepción');
INSERT INTO City(IdState, Name) VALUES('46','Dolores');
INSERT INTO City(IdState, Name) VALUES('46','Intibucá');
INSERT INTO City(IdState, Name) VALUES('46','Jesús de Otoro');
INSERT INTO City(IdState, Name) VALUES('46','Magdalena');
INSERT INTO City(IdState, Name) VALUES('46','Masaguara');
INSERT INTO City(IdState, Name) VALUES('46','San Antonio');
INSERT INTO City(IdState, Name) VALUES('46','San Isidro');
INSERT INTO City(IdState, Name) VALUES('46','San Juan');
INSERT INTO City(IdState, Name) VALUES('46','San Marcos de la Sierra');
INSERT INTO City(IdState, Name) VALUES('46','San Miguel Guancapla');
INSERT INTO City(IdState, Name) VALUES('46','Santa Lucía');
INSERT INTO City(IdState, Name) VALUES('46','Yamaranguila');
INSERT INTO City(IdState, Name) VALUES('46','San Francisco de Opalaca');
end

begin -- Islas de la Bahía, Id State: 47
INSERT INTO State(IdCountry, Name) VALUES('3','Islas de la Bahía');

INSERT INTO City(IdState, Name) VALUES('47','Roatán');
INSERT INTO City(IdState, Name) VALUES('47','Guanaja');
INSERT INTO City(IdState, Name) VALUES('47','José Santos Guardiola');
INSERT INTO City(IdState, Name) VALUES('47','Utila');
end

begin -- La Paz, Id State: 48
INSERT INTO State(IdCountry, Name) VALUES('3','La Paz');

INSERT INTO City(IdState, Name) VALUES('48','La Paz');
INSERT INTO City(IdState, Name) VALUES('48','Aguanqueterique');
INSERT INTO City(IdState, Name) VALUES('48','Cabañas');
INSERT INTO City(IdState, Name) VALUES('48','Cane');
INSERT INTO City(IdState, Name) VALUES('48','Chinacla');
INSERT INTO City(IdState, Name) VALUES('48','Guajiquiro');
INSERT INTO City(IdState, Name) VALUES('48','Lauterique');
INSERT INTO City(IdState, Name) VALUES('48','Marcala');
INSERT INTO City(IdState, Name) VALUES('48','Mercedes de Oriente');
INSERT INTO City(IdState, Name) VALUES('48','Opatorio');
INSERT INTO City(IdState, Name) VALUES('48','San Antonio del Norte');
INSERT INTO City(IdState, Name) VALUES('48','San José');
INSERT INTO City(IdState, Name) VALUES('48','San Juan');
INSERT INTO City(IdState, Name) VALUES('48','San Pedro de Tutule');
INSERT INTO City(IdState, Name) VALUES('48','Santa Ana');
INSERT INTO City(IdState, Name) VALUES('48','Santa Elena');
INSERT INTO City(IdState, Name) VALUES('48','Santa María');
INSERT INTO City(IdState, Name) VALUES('48','Santiago de Puringla');
INSERT INTO City(IdState, Name) VALUES('48','Yarula');
end

begin -- Lempira, Id State: 49
INSERT INTO State(IdCountry, Name) VALUES('3','Lempira');

INSERT INTO City(IdState, Name) VALUES('49','Gracias');
INSERT INTO City(IdState, Name) VALUES('49','Belén');
INSERT INTO City(IdState, Name) VALUES('49','Candelaria');
INSERT INTO City(IdState, Name) VALUES('49','Cololaca');
INSERT INTO City(IdState, Name) VALUES('49','Erandique');
INSERT INTO City(IdState, Name) VALUES('49','Gualcince');
INSERT INTO City(IdState, Name) VALUES('49','Guarita');
INSERT INTO City(IdState, Name) VALUES('49','La Campa');
INSERT INTO City(IdState, Name) VALUES('49','La Iguala');
INSERT INTO City(IdState, Name) VALUES('49','Las Flores');
INSERT INTO City(IdState, Name) VALUES('49','La Unión');
INSERT INTO City(IdState, Name) VALUES('49','La Virtud');
INSERT INTO City(IdState, Name) VALUES('49','Lepaera');
INSERT INTO City(IdState, Name) VALUES('49','Mapulaca');
INSERT INTO City(IdState, Name) VALUES('49','Piraera');
INSERT INTO City(IdState, Name) VALUES('49','San Andrés');
INSERT INTO City(IdState, Name) VALUES('49','San Francisco');
INSERT INTO City(IdState, Name) VALUES('49','San Juan Guarita');
INSERT INTO City(IdState, Name) VALUES('49','San Manuel Colohete');
INSERT INTO City(IdState, Name) VALUES('49','San Rafael');
INSERT INTO City(IdState, Name) VALUES('49','San Sebastián');
INSERT INTO City(IdState, Name) VALUES('49','Santa Cruz');
INSERT INTO City(IdState, Name) VALUES('49','Talgua');
INSERT INTO City(IdState, Name) VALUES('49','Tambla');
INSERT INTO City(IdState, Name) VALUES('49','Tomalá');
INSERT INTO City(IdState, Name) VALUES('49','Valladolid');
INSERT INTO City(IdState, Name) VALUES('49','Virginia');
INSERT INTO City(IdState, Name) VALUES('49','San Marcos de Caiquín');
end

begin -- Ocotepeque, Id State: 50
INSERT INTO State(IdCountry, Name) VALUES('3','Ocotepeque');

INSERT INTO City(IdState, Name) VALUES('50','Ocotepeque');
INSERT INTO City(IdState, Name) VALUES('50','Belén Gualcho');
INSERT INTO City(IdState, Name) VALUES('50','Concepción');
INSERT INTO City(IdState, Name) VALUES('50','Dolores Merendón');
INSERT INTO City(IdState, Name) VALUES('50','Fraternidad');
INSERT INTO City(IdState, Name) VALUES('50','La Encarnación');
INSERT INTO City(IdState, Name) VALUES('50','La Labor');
INSERT INTO City(IdState, Name) VALUES('50','Lucerna');
INSERT INTO City(IdState, Name) VALUES('50','Mercedes');
INSERT INTO City(IdState, Name) VALUES('50','San Fernando');
INSERT INTO City(IdState, Name) VALUES('50','San Francisco del Valle');
INSERT INTO City(IdState, Name) VALUES('50','San Jorge');
INSERT INTO City(IdState, Name) VALUES('50','San Marcos');
INSERT INTO City(IdState, Name) VALUES('50','Santa Fe');
INSERT INTO City(IdState, Name) VALUES('50','Sensenti');
INSERT INTO City(IdState, Name) VALUES('50','Sinuapa');
end

begin -- Olancho, Id State: 51
INSERT INTO State(IdCountry, Name) VALUES('3','Olancho');

INSERT INTO City(IdState, Name) VALUES('51','Juticalpa');
INSERT INTO City(IdState, Name) VALUES('51','Campamento');
INSERT INTO City(IdState, Name) VALUES('51','Catacamas');
INSERT INTO City(IdState, Name) VALUES('51','Concordia');
INSERT INTO City(IdState, Name) VALUES('51','Dulce Nombre de Culmí');
INSERT INTO City(IdState, Name) VALUES('51','El Rosario');
INSERT INTO City(IdState, Name) VALUES('51','Esquipulas del Norte');
INSERT INTO City(IdState, Name) VALUES('51','Gualaco');
INSERT INTO City(IdState, Name) VALUES('51','Guarizama');
INSERT INTO City(IdState, Name) VALUES('51','Guata');
INSERT INTO City(IdState, Name) VALUES('51','Guayape');
INSERT INTO City(IdState, Name) VALUES('51','Jano');
INSERT INTO City(IdState, Name) VALUES('51','La Unión');
INSERT INTO City(IdState, Name) VALUES('51','Mangulile');
INSERT INTO City(IdState, Name) VALUES('51','Manto');
INSERT INTO City(IdState, Name) VALUES('51','Salamá');
INSERT INTO City(IdState, Name) VALUES('51','San Esteban');
INSERT INTO City(IdState, Name) VALUES('51','San Francisco de Becerra');
INSERT INTO City(IdState, Name) VALUES('51','San Francisco de la Paz');
INSERT INTO City(IdState, Name) VALUES('51','Santa María del Real');
INSERT INTO City(IdState, Name) VALUES('51','Silca');
INSERT INTO City(IdState, Name) VALUES('51','Yocón');
INSERT INTO City(IdState, Name) VALUES('51','Patuca');
end

begin -- Santa Bárbara, Id State: 52
INSERT INTO State(IdCountry, Name) VALUES('3','Santa Bárbara');

INSERT INTO City(IdState, Name) VALUES('52','Santa Bárbara');
INSERT INTO City(IdState, Name) VALUES('52','Arada');
INSERT INTO City(IdState, Name) VALUES('52','Atima');
INSERT INTO City(IdState, Name) VALUES('52','Azacualpa');
INSERT INTO City(IdState, Name) VALUES('52','Ceguaca');
INSERT INTO City(IdState, Name) VALUES('52','Concepción del Norte');
INSERT INTO City(IdState, Name) VALUES('52','Concepción del Sur');
INSERT INTO City(IdState, Name) VALUES('52','Chinda');
INSERT INTO City(IdState, Name) VALUES('52','El Nispero');
INSERT INTO City(IdState, Name) VALUES('52','Gualala');
INSERT INTO City(IdState, Name) VALUES('52','Llama');
INSERT INTO City(IdState, Name) VALUES('52','Las Vegas');
INSERT INTO City(IdState, Name) VALUES('52','Macuelizo');
INSERT INTO City(IdState, Name) VALUES('52','Naranjito');
INSERT INTO City(IdState, Name) VALUES('52','Nuevo Celilac');
INSERT INTO City(IdState, Name) VALUES('52','Nueva Frontera');
INSERT INTO City(IdState, Name) VALUES('52','Petoa');
INSERT INTO City(IdState, Name) VALUES('52','Protección');
INSERT INTO City(IdState, Name) VALUES('52','Quimistán');
INSERT INTO City(IdState, Name) VALUES('52','San Francisco de Ojuera');
INSERT INTO City(IdState, Name) VALUES('52','San José de Colinas');
INSERT INTO City(IdState, Name) VALUES('52','San Luis');
INSERT INTO City(IdState, Name) VALUES('52','San Marcos');
INSERT INTO City(IdState, Name) VALUES('52','San Nicolás');
INSERT INTO City(IdState, Name) VALUES('52','San Pedro Zacapa');
INSERT INTO City(IdState, Name) VALUES('52','San Vicente Centenario');
INSERT INTO City(IdState, Name) VALUES('52','Santa Rita');
INSERT INTO City(IdState, Name) VALUES('52','Trinidad');
end


begin -- Valle, Id State: 53
INSERT INTO State(IdCountry, Name) VALUES('3','Valle');

INSERT INTO City(IdState, Name) VALUES('53','Nacaome');
INSERT INTO City(IdState, Name) VALUES('53','Alianza');
INSERT INTO City(IdState, Name) VALUES('53','Amapala');
INSERT INTO City(IdState, Name) VALUES('53','Aramecina');
INSERT INTO City(IdState, Name) VALUES('53','Caridad');
INSERT INTO City(IdState, Name) VALUES('53','Goascorán');
INSERT INTO City(IdState, Name) VALUES('53','Langue');
INSERT INTO City(IdState, Name) VALUES('53','San Francisco de Coray');
INSERT INTO City(IdState, Name) VALUES('53','San Lorenzo');
end

begin -- Yoro, Id State: 54
INSERT INTO State(IdCountry, Name) VALUES('3','Yoro');

INSERT INTO City(IdState, Name) VALUES('54','Yoro');
INSERT INTO City(IdState, Name) VALUES('54','Arenal');
INSERT INTO City(IdState, Name) VALUES('54','El Negrito');
INSERT INTO City(IdState, Name) VALUES('54','El Progreso');
INSERT INTO City(IdState, Name) VALUES('54','Jocón');
INSERT INTO City(IdState, Name) VALUES('54','Morazán');
INSERT INTO City(IdState, Name) VALUES('54','Olanchito');
INSERT INTO City(IdState, Name) VALUES('54','Santa Rita');
INSERT INTO City(IdState, Name) VALUES('54','Sulaco');
INSERT INTO City(IdState, Name) VALUES('54','Victoria');
INSERT INTO City(IdState, Name) VALUES('54','Yorito');
end

end

begin -- Nicaragua, Id Country: 4
INSERT INTO Country(Name) VALUES('Nicaragua');

begin -- Boaco, Id State: 55
INSERT INTO State(IdCountry, Name) VALUES('4','Boaco');

INSERT INTO City(IdState, Name) VALUES('55','Boaco');
INSERT INTO City(IdState, Name) VALUES('55','Camoapa');
INSERT INTO City(IdState, Name) VALUES('55','San José de Los Remates');
INSERT INTO City(IdState, Name) VALUES('55','San Lorenzo');
INSERT INTO City(IdState, Name) VALUES('55','Santa Lucía');
INSERT INTO City(IdState, Name) VALUES('55','Teustepe');
end

begin -- Carazo, Id State: 56
INSERT INTO State(IdCountry, Name) VALUES('4','Carazo');

INSERT INTO City(IdState, Name) VALUES('56','Diriamba');
INSERT INTO City(IdState, Name) VALUES('56','Dolores');
INSERT INTO City(IdState, Name) VALUES('56','El Rosario');
INSERT INTO City(IdState, Name) VALUES('56','Jinotepe');
INSERT INTO City(IdState, Name) VALUES('56','La Conquista');
INSERT INTO City(IdState, Name) VALUES('56','La Paz de Oriente');
INSERT INTO City(IdState, Name) VALUES('56','San Marcos');
INSERT INTO City(IdState, Name) VALUES('56','Santa Teresa');
end

begin -- Chinandega, Id State: 57
INSERT INTO State(IdCountry, Name) VALUES('4','Chinandega');

INSERT INTO City(IdState, Name) VALUES('57','Chichigalpa');
INSERT INTO City(IdState, Name) VALUES('57','Chinandega');
INSERT INTO City(IdState, Name) VALUES('57','Cinco Pinos');
INSERT INTO City(IdState, Name) VALUES('57','Corinto');
INSERT INTO City(IdState, Name) VALUES('57','El Realejo');
INSERT INTO City(IdState, Name) VALUES('57','El Viejo');
INSERT INTO City(IdState, Name) VALUES('57','Posoltega');
INSERT INTO City(IdState, Name) VALUES('57','Puerto Morazán');
INSERT INTO City(IdState, Name) VALUES('57','San Francisco del Norte');
INSERT INTO City(IdState, Name) VALUES('57','San Pedro del Norte');
INSERT INTO City(IdState, Name) VALUES('57','Santo Tomásdel Norte');
INSERT INTO City(IdState, Name) VALUES('57','Somotillo');
INSERT INTO City(IdState, Name) VALUES('57','Villanueva');
end

begin -- Chontales, Id State: 58
INSERT INTO State(IdCountry, Name) VALUES('4','Chontales');

INSERT INTO City(IdState, Name) VALUES('58','Acoyapa');
INSERT INTO City(IdState, Name) VALUES('58','Comalapa');
INSERT INTO City(IdState, Name) VALUES('58','Cuapa');
INSERT INTO City(IdState, Name) VALUES('58','El Coral');
INSERT INTO City(IdState, Name) VALUES('58','Juigalpa');
INSERT INTO City(IdState, Name) VALUES('58','La Libertad');
INSERT INTO City(IdState, Name) VALUES('58','San Pedro de Lóvago');
INSERT INTO City(IdState, Name) VALUES('58','Santo Domingo');
INSERT INTO City(IdState, Name) VALUES('58','Santo Tomás');
INSERT INTO City(IdState, Name) VALUES('58','Villa Sandino');
end

begin -- Costa Caribe Norte, Id State: 59
INSERT INTO State(IdCountry, Name) VALUES('4','Costa Caribe Norte');

INSERT INTO City(IdState, Name) VALUES('59','Bonanza');
INSERT INTO City(IdState, Name) VALUES('59','Mulukukú');
INSERT INTO City(IdState, Name) VALUES('59','Prinzapolka');
INSERT INTO City(IdState, Name) VALUES('59','Puerto Cabezas');
INSERT INTO City(IdState, Name) VALUES('59','Rosita');
INSERT INTO City(IdState, Name) VALUES('59','Siuna');
INSERT INTO City(IdState, Name) VALUES('59','Waslala');
INSERT INTO City(IdState, Name) VALUES('59','Waspán');
end

begin -- Costa Caribe Sur, Id State: 60
INSERT INTO State(IdCountry, Name) VALUES('4','Costa Caribe Sur');

INSERT INTO City(IdState, Name) VALUES('60','Bluefields');
INSERT INTO City(IdState, Name) VALUES('60','Desembocadura de Río Grande');
INSERT INTO City(IdState, Name) VALUES('60','El Ayote');
INSERT INTO City(IdState, Name) VALUES('60','El Rama');
INSERT INTO City(IdState, Name) VALUES('60','El Tortuguero');
INSERT INTO City(IdState, Name) VALUES('60','Islas del Maíz');
INSERT INTO City(IdState, Name) VALUES('60','Kukra Hill');
INSERT INTO City(IdState, Name) VALUES('60','La Cruz de Río Grande');
INSERT INTO City(IdState, Name) VALUES('60','Lagunas de Perlas');
INSERT INTO City(IdState, Name) VALUES('60','Muelle de los Bueyes');
INSERT INTO City(IdState, Name) VALUES('60','Nueva Guinea');
INSERT INTO City(IdState, Name) VALUES('60','Paiwaas');
end

begin -- Estelí, Id State: 61
INSERT INTO State(IdCountry, Name) VALUES('4','Estelí');

INSERT INTO City(IdState, Name) VALUES('61','Condega');
INSERT INTO City(IdState, Name) VALUES('61','Estelí');
INSERT INTO City(IdState, Name) VALUES('61','La Trinidad');
INSERT INTO City(IdState, Name) VALUES('61','Pueblo Nuevo');
INSERT INTO City(IdState, Name) VALUES('61','San Juan de Limay');
INSERT INTO City(IdState, Name) VALUES('61','San Nicolás');
end

begin -- Granada, Id State: 62
INSERT INTO State(IdCountry, Name) VALUES('4','Granada');

INSERT INTO City(IdState, Name) VALUES('62','Diriá');
INSERT INTO City(IdState, Name) VALUES('62','Diriomo');
INSERT INTO City(IdState, Name) VALUES('62','Granada');
INSERT INTO City(IdState, Name) VALUES('62','Nandaime');
end

begin -- Jinotega, Id State: 63
INSERT INTO State(IdCountry, Name) VALUES('4','Jinotega');

INSERT INTO City(IdState, Name) VALUES('63','El Cuá');
INSERT INTO City(IdState, Name) VALUES('63','Jinotega');
INSERT INTO City(IdState, Name) VALUES('63','La Concordia');
INSERT INTO City(IdState, Name) VALUES('63','San José de Bocay');
INSERT INTO City(IdState, Name) VALUES('63','San Rafael del Norte');
INSERT INTO City(IdState, Name) VALUES('63','San Sebastián de Yalí');
INSERT INTO City(IdState, Name) VALUES('63','Santa Maríade Pantasma');
INSERT INTO City(IdState, Name) VALUES('63','Wiwilí de Jinotega');
end

begin -- León, Id State: 64
INSERT INTO State(IdCountry, Name) VALUES('4','León');

INSERT INTO City(IdState, Name) VALUES('64','Achuapa');
INSERT INTO City(IdState, Name) VALUES('64','El Jicaral');
INSERT INTO City(IdState, Name) VALUES('64','El Sauce');
INSERT INTO City(IdState, Name) VALUES('64','La Paz Centro');
INSERT INTO City(IdState, Name) VALUES('64','Larreynaga');
INSERT INTO City(IdState, Name) VALUES('64','León');
INSERT INTO City(IdState, Name) VALUES('64','Nagarote');
INSERT INTO City(IdState, Name) VALUES('64','Quezalguaque');
INSERT INTO City(IdState, Name) VALUES('64','Santa Rosa del Peñón');
INSERT INTO City(IdState, Name) VALUES('64','Telica');
end

begin -- Madriz, Id State: 65
INSERT INTO State(IdCountry, Name) VALUES('4','Madriz');

INSERT INTO City(IdState, Name) VALUES('65','Las Sabanas');
INSERT INTO City(IdState, Name) VALUES('65','Palacagüina');
INSERT INTO City(IdState, Name) VALUES('65','San José de Cusmapa');
INSERT INTO City(IdState, Name) VALUES('65','San Juan de Río Coco');
INSERT INTO City(IdState, Name) VALUES('65','San Lucas');
INSERT INTO City(IdState, Name) VALUES('65','Somoto');
INSERT INTO City(IdState, Name) VALUES('65','Telpaneca');
INSERT INTO City(IdState, Name) VALUES('65','Totogalpa');
INSERT INTO City(IdState, Name) VALUES('65','Yalagüina');
end

begin -- Managua, Id State: 66
INSERT INTO State(IdCountry, Name) VALUES('4','Managua');

INSERT INTO City(IdState, Name) VALUES('66','Ciudad Sandino');
INSERT INTO City(IdState, Name) VALUES('66','El Crucero');
INSERT INTO City(IdState, Name) VALUES('66','Managua');
INSERT INTO City(IdState, Name) VALUES('66','Mateare');
INSERT INTO City(IdState, Name) VALUES('66','San Francisco Libre');
INSERT INTO City(IdState, Name) VALUES('66','San Rafael del Sur');
INSERT INTO City(IdState, Name) VALUES('66','Ticuantepe');
INSERT INTO City(IdState, Name) VALUES('66','Tipitapa');
INSERT INTO City(IdState, Name) VALUES('66','Villa El Carmen');
end


begin -- Masaya, Id State: 67
INSERT INTO State(IdCountry, Name) VALUES('4','Masaya');

INSERT INTO City(IdState, Name) VALUES('67','Catarina');
INSERT INTO City(IdState, Name) VALUES('67','La Concepción');
INSERT INTO City(IdState, Name) VALUES('67','Masatepe');
INSERT INTO City(IdState, Name) VALUES('67','Masaya');
INSERT INTO City(IdState, Name) VALUES('67','Nandasmo');
INSERT INTO City(IdState, Name) VALUES('67','Nindirí');
INSERT INTO City(IdState, Name) VALUES('67','Niquinohomo');
INSERT INTO City(IdState, Name) VALUES('67','San Juande Oriente');
INSERT INTO City(IdState, Name) VALUES('67','Tisma');
end

begin -- Matagalpa, Id State: 68
INSERT INTO State(IdCountry, Name) VALUES('4','Matagalpa');

INSERT INTO City(IdState, Name) VALUES('68','Ciudad Darío');
INSERT INTO City(IdState, Name) VALUES('68','El Tuma - La Dalia');
INSERT INTO City(IdState, Name) VALUES('68','Esquipulas');
INSERT INTO City(IdState, Name) VALUES('68','Matagalpa');
INSERT INTO City(IdState, Name) VALUES('68','Matiguás');
INSERT INTO City(IdState, Name) VALUES('68','Muy Muy');
INSERT INTO City(IdState, Name) VALUES('68','Rancho Grande');
INSERT INTO City(IdState, Name) VALUES('68','Río Blanco');
INSERT INTO City(IdState, Name) VALUES('68','San Dionisio');
INSERT INTO City(IdState, Name) VALUES('68','San Isidro');
INSERT INTO City(IdState, Name) VALUES('68','San Ramón');
INSERT INTO City(IdState, Name) VALUES('68','Sébaco');
INSERT INTO City(IdState, Name) VALUES('68','Terrabona');
end

begin -- Nueva Segovia, Id State: 69
INSERT INTO State(IdCountry, Name) VALUES('4','Nueva Segovia');

INSERT INTO City(IdState, Name) VALUES('69','Ciudad Antigua');
INSERT INTO City(IdState, Name) VALUES('69','Dipilto');
INSERT INTO City(IdState, Name) VALUES('69','El Jícaro');
INSERT INTO City(IdState, Name) VALUES('69','Jalapa');
INSERT INTO City(IdState, Name) VALUES('69','Macuelizo');
INSERT INTO City(IdState, Name) VALUES('69','Mozonte');
INSERT INTO City(IdState, Name) VALUES('69','Murra');
INSERT INTO City(IdState, Name) VALUES('69','Ocotal');
INSERT INTO City(IdState, Name) VALUES('69','Quilalí');
INSERT INTO City(IdState, Name) VALUES('69','San Feranndo');
INSERT INTO City(IdState, Name) VALUES('69','Santa María');
INSERT INTO City(IdState, Name) VALUES('69','Wiwilí');
end

begin -- Río San Juan, Id State: 70
INSERT INTO State(IdCountry, Name) VALUES('4','Río San Juan');

INSERT INTO City(IdState, Name) VALUES('70','El Almendro');
INSERT INTO City(IdState, Name) VALUES('70','El Castillo');
INSERT INTO City(IdState, Name) VALUES('70','Morrito');
INSERT INTO City(IdState, Name) VALUES('70','San Carlos');
INSERT INTO City(IdState, Name) VALUES('70','San Juan del Norte');
INSERT INTO City(IdState, Name) VALUES('70','San Miguelito');
end

begin -- Rivas, Id State: 71
INSERT INTO State(IdCountry, Name) VALUES('4','Rivas');

INSERT INTO City(IdState, Name) VALUES('71','Altagracia');
INSERT INTO City(IdState, Name) VALUES('71','Belén');
INSERT INTO City(IdState, Name) VALUES('71','Buenos Aires');
INSERT INTO City(IdState, Name) VALUES('71','Cárdenas');
INSERT INTO City(IdState, Name) VALUES('71','Moyogalpa');
INSERT INTO City(IdState, Name) VALUES('71','Potosí');
INSERT INTO City(IdState, Name) VALUES('71','Rivas');
INSERT INTO City(IdState, Name) VALUES('71','San Jorge');
INSERT INTO City(IdState, Name) VALUES('71','San Juan del Sur');
INSERT INTO City(IdState, Name) VALUES('71','Tola');
end

end

begin -- Costa  Rica, Id Country: 5
INSERT INTO Country(Name) VALUES('Costa Rica');

begin -- San José, Id State: 72
INSERT INTO State(IdCountry, Name) VALUES('5','San José');

INSERT INTO City(IdState, Name) VALUES('72','Pérez Zeledón');
INSERT INTO City(IdState, Name) VALUES('72','Puriscal');
INSERT INTO City(IdState, Name) VALUES('72','Turrubares');
INSERT INTO City(IdState, Name) VALUES('72','Dota');
INSERT INTO City(IdState, Name) VALUES('72','Acosta');
INSERT INTO City(IdState, Name) VALUES('72','Tarrazú');
INSERT INTO City(IdState, Name) VALUES('72','Vázquez de Coronado');
INSERT INTO City(IdState, Name) VALUES('72','Aserrí');
INSERT INTO City(IdState, Name) VALUES('72','Mora');
INSERT INTO City(IdState, Name) VALUES('72','León Cortés');
INSERT INTO City(IdState, Name) VALUES('72','Desamparados');
INSERT INTO City(IdState, Name) VALUES('72','Santa Ana');
INSERT INTO City(IdState, Name) VALUES('72','San José');
INSERT INTO City(IdState, Name) VALUES('72','Escazú');
INSERT INTO City(IdState, Name) VALUES('72','Goicoechea');
INSERT INTO City(IdState, Name) VALUES('72','Moravia');
INSERT INTO City(IdState, Name) VALUES('72','Alajuelita');
INSERT INTO City(IdState, Name) VALUES('72','Curridabat');
INSERT INTO City(IdState, Name) VALUES('72','Montes de Oca');
INSERT INTO City(IdState, Name) VALUES('72','Tibás');
end

begin -- Alajuela, Id State: 73
INSERT INTO State(IdCountry, Name) VALUES('5','Alajuela');

INSERT INTO City(IdState, Name) VALUES('73','San Carlos');
INSERT INTO City(IdState, Name) VALUES('73','Upala');
INSERT INTO City(IdState, Name) VALUES('73','Los Chiles');
INSERT INTO City(IdState, Name) VALUES('73','San Ramón');
INSERT INTO City(IdState, Name) VALUES('73','Guatuso');
INSERT INTO City(IdState, Name) VALUES('73','Alajuela');
INSERT INTO City(IdState, Name) VALUES('73','Río Cuarto');
INSERT INTO City(IdState, Name) VALUES('73','Zarcero');
INSERT INTO City(IdState, Name) VALUES('73','Orotina');
INSERT INTO City(IdState, Name) VALUES('73','Grecia');
INSERT INTO City(IdState, Name) VALUES('73','Atenas');
INSERT INTO City(IdState, Name) VALUES('73','Naranjo');
INSERT INTO City(IdState, Name) VALUES('73','San Mateo');
INSERT INTO City(IdState, Name) VALUES('73','Sarchí');
INSERT INTO City(IdState, Name) VALUES('73','Poás');
INSERT INTO City(IdState, Name) VALUES('73','Palmares');
end

begin -- Cartago, Id State: 74
INSERT INTO State(IdCountry, Name) VALUES('5','Cartago');

INSERT INTO City(IdState, Name) VALUES('74','Turrialba');
INSERT INTO City(IdState, Name) VALUES('74','Paraíso');
INSERT INTO City(IdState, Name) VALUES('74','Cartago');
INSERT INTO City(IdState, Name) VALUES('74','Jiménez');
INSERT INTO City(IdState, Name) VALUES('74','Oreamuno');
INSERT INTO City(IdState, Name) VALUES('74','El Guarco');
INSERT INTO City(IdState, Name) VALUES('74','Alvarado');
INSERT INTO City(IdState, Name) VALUES('74','La Unión');
end

begin -- Heredia, Id State: 75
INSERT INTO State(IdCountry, Name) VALUES('5','Heredia');

INSERT INTO City(IdState, Name) VALUES('75','Sarapiquí');
INSERT INTO City(IdState, Name) VALUES('75','Heredia');
INSERT INTO City(IdState, Name) VALUES('75','Barva');
INSERT INTO City(IdState, Name) VALUES('75','Santa Bárbara');
INSERT INTO City(IdState, Name) VALUES('75','San Rafael');
INSERT INTO City(IdState, Name) VALUES('75','San Isidro');
INSERT INTO City(IdState, Name) VALUES('75','Santo Domingo');
INSERT INTO City(IdState, Name) VALUES('75','Belén');
INSERT INTO City(IdState, Name) VALUES('75','San Pablo');
INSERT INTO City(IdState, Name) VALUES('75','Flores');
end

begin -- Puntarenas, Id State: 76
INSERT INTO State(IdCountry, Name) VALUES('5','Puntarenas');

INSERT INTO City(IdState, Name) VALUES('76','Buenos Aires');
INSERT INTO City(IdState, Name) VALUES('76','Osa');
INSERT INTO City(IdState, Name) VALUES('76','Puntarenas');
INSERT INTO City(IdState, Name) VALUES('76','Golfito');
INSERT INTO City(IdState, Name) VALUES('76','Coto Brus');
INSERT INTO City(IdState, Name) VALUES('76','Corredores');
INSERT INTO City(IdState, Name) VALUES('76','Quepos');
INSERT INTO City(IdState, Name) VALUES('76','Parrita');
INSERT INTO City(IdState, Name) VALUES('76','Garabito');
INSERT INTO City(IdState, Name) VALUES('76','Montes de Oro');
INSERT INTO City(IdState, Name) VALUES('76','Esparza');
end

begin -- Guanacaste, Id State: 77
INSERT INTO State(IdCountry, Name) VALUES('5','Guanacaste');

INSERT INTO City(IdState, Name) VALUES('77','Liberia');
INSERT INTO City(IdState, Name) VALUES('77','La Cruz');
INSERT INTO City(IdState, Name) VALUES('77','Nicoya');
INSERT INTO City(IdState, Name) VALUES('77','Santa Cruz');
INSERT INTO City(IdState, Name) VALUES('77','Bagaces');
INSERT INTO City(IdState, Name) VALUES('77','Cañas');
INSERT INTO City(IdState, Name) VALUES('77','Abangares');
INSERT INTO City(IdState, Name) VALUES('77','Tilarán');
INSERT INTO City(IdState, Name) VALUES('77','Carrillo');
INSERT INTO City(IdState, Name) VALUES('77','Nandayure');
INSERT INTO City(IdState, Name) VALUES('77','Hojancha');
end

begin -- Limón, Id State: 78
INSERT INTO State(IdCountry, Name) VALUES('5','Limón');

INSERT INTO City(IdState, Name) VALUES('78','Talamanca');
INSERT INTO City(IdState, Name) VALUES('78','Pococi');
INSERT INTO City(IdState, Name) VALUES('78','Limón');
INSERT INTO City(IdState, Name) VALUES('78','Siquirres');
INSERT INTO City(IdState, Name) VALUES('78','Matina');
INSERT INTO City(IdState, Name) VALUES('78','Guácimo');
end

end

begin -- Panamá, Id Country: 6
INSERT INTO Country(Name) VALUES('Panamá');

begin -- Bocas del Toro, Id State: 79
INSERT INTO State(IdCountry, Name) VALUES('6','Bocas del Toro');

INSERT INTO City(IdState, Name) VALUES('79','Almirante');
INSERT INTO City(IdState, Name) VALUES('79','Bocas del Toro');
INSERT INTO City(IdState, Name) VALUES('79','Changuinola');
INSERT INTO City(IdState, Name) VALUES('79','Chiriquí Grande');
end

begin -- Chiriquí, Id State: 80
INSERT INTO State(IdCountry, Name) VALUES('6','Chiriquí');

INSERT INTO City(IdState, Name) VALUES('80','Alanje');
INSERT INTO City(IdState, Name) VALUES('80','Barú');
INSERT INTO City(IdState, Name) VALUES('80','Boquerón');
INSERT INTO City(IdState, Name) VALUES('80','Boquete');
INSERT INTO City(IdState, Name) VALUES('80','Bugaba');
INSERT INTO City(IdState, Name) VALUES('80','David');
INSERT INTO City(IdState, Name) VALUES('80','Dolega');
INSERT INTO City(IdState, Name) VALUES('80','Gualaca');
INSERT INTO City(IdState, Name) VALUES('80','Remedios');
INSERT INTO City(IdState, Name) VALUES('80','Renacimiento');
INSERT INTO City(IdState, Name) VALUES('80','San Félix');
INSERT INTO City(IdState, Name) VALUES('80','San Lorenzo');
INSERT INTO City(IdState, Name) VALUES('80','Tierras Altas');
INSERT INTO City(IdState, Name) VALUES('80','Tolé');
end

begin -- Coclé, Id State: 81
INSERT INTO State(IdCountry, Name) VALUES('6','Coclé');

INSERT INTO City(IdState, Name) VALUES('81','Aguadulce');
INSERT INTO City(IdState, Name) VALUES('81','Antón');
INSERT INTO City(IdState, Name) VALUES('81','La Pintada');
INSERT INTO City(IdState, Name) VALUES('81','Natá');
INSERT INTO City(IdState, Name) VALUES('81','Olá');
INSERT INTO City(IdState, Name) VALUES('81','Penonomé');
end

begin -- Colón, Id State: 82
INSERT INTO State(IdCountry, Name) VALUES('6','Colón');

INSERT INTO City(IdState, Name) VALUES('82','Chagres');
INSERT INTO City(IdState, Name) VALUES('82','Colón');
INSERT INTO City(IdState, Name) VALUES('82','Donoso');
INSERT INTO City(IdState, Name) VALUES('82','Portobelo');
INSERT INTO City(IdState, Name) VALUES('82','Santa Isabel');
INSERT INTO City(IdState, Name) VALUES('82','Omar Torrijos Herrera');
end

begin -- Darién, Id State: 83
INSERT INTO State(IdCountry, Name) VALUES('6','Darién');

INSERT INTO City(IdState, Name) VALUES('83','Chepigana');
INSERT INTO City(IdState, Name) VALUES('83','Pinogana');
INSERT INTO City(IdState, Name) VALUES('83','Santa Fe');
INSERT INTO City(IdState, Name) VALUES('83','Guna de Wargandi');
end

begin -- Herrera, Id State: 84
INSERT INTO State(IdCountry, Name) VALUES('6','Herrera');

INSERT INTO City(IdState, Name) VALUES('84','Chitré');
INSERT INTO City(IdState, Name) VALUES('84','Las Minas');
INSERT INTO City(IdState, Name) VALUES('84','Los Pozos');
INSERT INTO City(IdState, Name) VALUES('84','Ocú');
INSERT INTO City(IdState, Name) VALUES('84','Parita');
INSERT INTO City(IdState, Name) VALUES('84','Pesé');
INSERT INTO City(IdState, Name) VALUES('84','Santa María');
end

begin -- Los Santos, Id State: 85
INSERT INTO State(IdCountry, Name) VALUES('6','Los Santos');

INSERT INTO City(IdState, Name) VALUES('85','Guararé');
INSERT INTO City(IdState, Name) VALUES('85','Las Tablas');
INSERT INTO City(IdState, Name) VALUES('85','Los Santos');
INSERT INTO City(IdState, Name) VALUES('85','Macaracas');
INSERT INTO City(IdState, Name) VALUES('85','Pedasí');
INSERT INTO City(IdState, Name) VALUES('85','Pocrí');
INSERT INTO City(IdState, Name) VALUES('85','Tonosí');
end

begin -- Panamá, Id State: 86
INSERT INTO State(IdCountry, Name) VALUES('6','Panamá');

INSERT INTO City(IdState, Name) VALUES('86','Balboa');
INSERT INTO City(IdState, Name) VALUES('86','Chepo');
INSERT INTO City(IdState, Name) VALUES('86','Chimán');
INSERT INTO City(IdState, Name) VALUES('86','Panamá');
INSERT INTO City(IdState, Name) VALUES('86','San Miguelito');
INSERT INTO City(IdState, Name) VALUES('86','Taboga');
end

begin -- Panamá Oeste, Id State: 87
INSERT INTO State(IdCountry, Name) VALUES('6','Panamá Oeste');

INSERT INTO City(IdState, Name) VALUES('87','Arraiján');
INSERT INTO City(IdState, Name) VALUES('87','Capira');
INSERT INTO City(IdState, Name) VALUES('87','Chame');
INSERT INTO City(IdState, Name) VALUES('87','La Chorrera');
INSERT INTO City(IdState, Name) VALUES('87','San Carlos');
end

begin -- Veraguas, Id State: 88
INSERT INTO State(IdCountry, Name) VALUES('6','Veraguas');

INSERT INTO City(IdState, Name) VALUES('88','Atalaya');
INSERT INTO City(IdState, Name) VALUES('88','Calobre');
INSERT INTO City(IdState, Name) VALUES('88','Cañazas');
INSERT INTO City(IdState, Name) VALUES('88','La mesa');
INSERT INTO City(IdState, Name) VALUES('88','Las Palmas');
INSERT INTO City(IdState, Name) VALUES('88','Mariato');
INSERT INTO City(IdState, Name) VALUES('88','Montijo');
INSERT INTO City(IdState, Name) VALUES('88','Río de Jesús');
INSERT INTO City(IdState, Name) VALUES('88','San Francisco');
INSERT INTO City(IdState, Name) VALUES('88','Santa Fe');
INSERT INTO City(IdState, Name) VALUES('88','Santiago');
INSERT INTO City(IdState, Name) VALUES('88','Soná');
end

end

end

/*
DELETE FROM City
DELETE FROM State
DELETE FROM Country

DBCC CHECKIDENT ('Country', RESEED, 0)  
DBCC CHECKIDENT ('State', RESEED, 0)  
DBCC CHECKIDENT ('City', RESEED, 0)  
*/
