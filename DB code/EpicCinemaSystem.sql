--USE master;

--DROP DATABASE epiccinesystemDB;

--CREATE DATABASE epiccinesystemDB;

USE epiccinesystemDB;

CREATE TABLE Hall (
hall_ID int NOT NULL PRIMARY KEY,
seat_amnt tinyint NOT NULL, 
CHECK (seat_amnt < 255)
);

CREATE TABLE Participant (
participant_ID int NOT NULL PRIMARY KEY,
participant_name varchar(32) NOT NULL,
email varchar(64) NOT NULL
);

CREATE TABLE Actor (
actor_ID int NOT NULL PRIMARY KEY,
actor_name varchar(32) NOT NULL
);

CREATE TABLE Director (
director_ID int NOT NULL PRIMARY KEY,
director_name varchar(32) NOT NULL
);

CREATE TABLE Movie (
movie_ID int NOT NULL PRIMARY KEY,
release_year int NOT NULL,
duration int NOT NULL,
genre varchar(50) NOT NULL,
title varchar(255) NOT NULL,
director_ID int FOREIGN KEY REFERENCES Director(director_ID) NOT NULL,
actor_ID int FOREIGN KEY REFERENCES Actor(actor_ID) NOT NULL
);
 
CREATE TABLE IMAX (
imax_ID int NOT NULL PRIMARY KEY,
imax_name varchar(32) NOT NULL,
imax_location text NOT NULL,
sales_num int,
movie_ID int FOREIGN KEY REFERENCES Movie(movie_ID) NOT NULL
);

CREATE TABLE Ticket (
ticket_ID int NOT NULL PRIMARY KEY,
price decimal(6, 2) NOT NULL,
showing_ID int,
participant_ID int FOREIGN KEY REFERENCES Participant(participant_ID) NOT NULL
);

CREATE TABLE Showing (
showing_ID int NOT NULL PRIMARY KEY,
showing_num int, --Numbers of showings
imax_ID int FOREIGN KEY REFERENCES Movie(movie_ID) NOT NULL,
hall_ID int FOREIGN KEY REFERENCES Hall(hall_ID) NOT NULL,
ticket_ID int FOREIGN KEY REFERENCES Ticket(ticket_ID) NOT NULL
);

CREATE TABLE ActorInMovie (
aim_ID int NOT NULL PRIMARY KEY,
movie_ID int FOREIGN KEY REFERENCES Movie(movie_ID) NOT NULL,
actor_ID int FOREIGN KEY REFERENCES Actor(actor_ID) NOT NULL
);

CREATE TABLE DirectorOfMovie (
dom_ID int NOT NULL PRIMARY KEY,
movie_ID int FOREIGN KEY REFERENCES Movie(movie_ID) NOT NULL,
director_ID int FOREIGN KEY REFERENCES Director(director_ID) NOT NULL
);

SELECT *
FROM Hall;
SELECT *
FROM Participant;
SELECT *
FROM Actor;
SELECT *
FROM Director;
SELECT *
FROM Movie;
SELECT *
FROM IMAX;
SELECT *
FROM Ticket;
SELECT *
FROM Showing;
SELECT *
FROM ActorInMovie;
SELECT *
FROM DirectorOfMovie;