--CREATE DATABASE Curso
--USE Curso

--CREATE TABLE Persona(
--	PersonaId uniqueidentifier NOT NULL PRIMARY KEY,
--	Dni nvarchar(10) NOT NULL,
--	Nombre nvarchar(50) NOT NULL,
--	Apellido nvarchar(50) NOT NULL)

/*SELECT *
FROM Persona*/

/*INSERT INTO Persona ( 
		PersonaId,
		Dni,
		Nombre,
		Apellido
)
VALUES(
		NEWID(),
		'123465789',
		'LUC',
		'AS'
)*/
/*SELECT CONCAT(nombre, ' ', apellido) as nombreCompleto,
	nombre, apellido
FROM Persona
WHERE PersonaId = 'D4432251-C71A-46C3-9784-B20B319EF2B1'*/


/*SELECT CONCAT(nombre, ' ', apellido) as nombreCompleto,
	nombre, apellido
FROM Persona
WHERE Apellido like '%AN%'*/

/*UPDATE Persona
SET Edad = 45
Where PersonaId = 'D4432251-C71A-46C3-9784-B20B319EF2B1'*/

/*SELECT CONCAT(nombre, ' ', apellido) as nombreCompleto,
	nombre, apellido
FROM Persona
WHERE Edad in (10,24,30,40)*/

/*DELETE FROM Persona
WHERE Edad in (10,24,30,40)*/

/*CREATE TABLE Gato(
	GatoId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nombre nvarchar(10) NOT NULL,
	Persona uniqueidentifier NOT NULL)*/

/*INSERT INTO Gato ( 
		Nombre,
		Persona
)
VALUES(
		'MAURI',
		'1FA203C5-77F8-4327-A354-123BA6E3EAE7'
)*/

/*SELECT Persona.Nombre, Gato.Nombre
FROM persona
INNER JOIN Gato ON Gato.Persona = Persona.PersonaId */
