use master

IF EXISTS (SELECT * from sys.databases WHERE name =	'Influencerne')
BEGIN
	DROP DATABASE Influencerne;
END;
CREATE DATABASE Influencerne;

use Influencerne;
------------
--Opgave 0--
------------
CREATE TABLE Influencers(
influencerID int NOT NULL PRIMARY KEY,
firstName varchar(30) NOT NULL,
age tinyint,
instagramFollowers int
);

CREATE TABLE SocielMediaPlatforms(
platfromID int NOT NULL PRIMARY KEY,
platfromName varchar(30) NOT NULL,
averageUserAge FLOAT,
totalUsers int
);

CREATE TABLE Brands(
brandID int NOT NULL PRIMARY KEY,
brandName varchar(30) NOT NULL,
category varchar(255),
);

CREATE TABLE Collaborations(
CollaborationID int NOT NULL PRIMARY KEY,
influencerID int NOT NULL FOREIGN KEY REFERENCES Influencers(influencerID),
brandID int NOT NULL FOREIGN KEY REFERENCES Brands(brandID),
platfromID int NOT NULL FOREIGN KEY REFERENCES SocielMediaPlatforms(platfromID),
duration int,
payment FLOAT
);

INSERT INTO Influencers(influencerID,firstName,age,instagramFollowers)
	VALUES (1,'Anna',24,50000),
	 (2,'Bent',22,20000),
	 (3,'Caroline',26,80000),
	 (4,'David',28,45000),
	 (5,'Ella',30,70000),
	 (6,'Frank',27,32000),
	 (7,'Grace',29,92000),
	 (8,'Henry',31,48000);
INSERT INTO SocielMediaPlatforms(platfromID,platfromName,averageUserAge,totalUsers)
VALUES (1,'Instagram',24.5,1000000),
	(2,'TikTok',18.5,2000000),
	(3,'Youtube',28.5,1500000),
	(4,'SnapChat',20.0,800000),
	(5,'Twitter',27.5,500000),
	(6,'Facebook',32.5,2000000),
	(7,'Pinterest',29.0,600000),
	(8,'Linkedin',34.0,400000);
INSERT INTO Brands(brandID,brandName,category)
VALUES (1,'FashionCo','fahion'),
	(2,'BeautyBiiss','beauty'),
	(3,'TeachTron','technology'),
	(4,'GlemGlow','beauty'),
	(5,'SportSpot','sports'),
	(6,'EcoEssentials','lifestyle'),
	(7,'TrendTech','technology'),
	(8,'MystiqueMakeup','beauty');
INSERT INTO Collaborations(CollaborationID,influencerID,brandID,platfromID,duration,payment)
VALUES (1, 1, 1, 1, 30, 5000.00),
	(2, 2, 3, 2, 10, 3000.50),
	(3, 3, 2, 3, 20, 7500.00),
	(4, 4, 4, 4, 15, 2500.00),
	(5, 1, 2, 1, 25, 6000.50),
	(6, 3, 1, 2, 40, 6500.75),
	(7, 5, 5, 5, 45, 5300.00),
	(8, 6, 6, 6, 20, 3500.25),
	(9, 7, 7, 7, 15, 4700.50),
	(10, 8, 8, 8, 25, 2900.00),
	(11, 5, 7, 1, 30, 5100.75),
	(12, 6, 5, 2, 40, 4400.00),
	(13, 7, 6, 3, 35, 6500.25),
	(14, 8, 7, 4, 20, 7000.50);

------------
--Opgave 1--
------------
/*
SELECT firstName from Influencers
*/
------------
--Opgave 2--
------------
/*
SELECT platfromName FROM SocielMediaPlatforms;
*/
------------
--Opgave 3--
------------
/*
SELECT firstName from Influencers WHERE age > 25
*/
------------
--Opgave 4--
------------
/*
SELECT brandName FROM Brands WHERE category = 'beauty'
*/
------------
--Opgave 5--
------------
/*
SELECT COUNT(instagramFollowers) FROM Influencers WHERE instagramFollowers > 50000
*/
------------
--Opgave 6--
------------
/*
SELECT platfromName FROM SocielMediaPlatforms
WHERE averageUserAge = (SELECT MIN(averageUserAge) FROM SocielMediaPlatforms);
*/
------------
--Opgave 7--
------------
/*
SELECT firstName FROM Influencers
JOIN Collaborations ON Influencers.influencerID = Collaborations.influencerID
WHERE brandID = (SELECT brandID FROM Brands WHERE brandName = 'FashionCo');
*/
------------
--Opgave 8--
------------
/*
SELECT platfromName FROM SocielMediaPlatforms WHERE totalUsers > 1000000
*/
------------
--Opgave 9--
------------
/*
SELECT firstName FROM Influencers WHERE age BETWEEN 25 and 30
*/
------------
--Opgave 10--
------------
/*
SELECT brandName FROM Brands 
WHERE Brands.brandID NOT IN (SELECT Collaborations.brandID FROM Collaborations WHERE Collaborations.platfromID = (SELECT platfromID FROM SocielMediaPlatforms WHERE platfromName = 'SnapChat')); 
*/
------------
--Opgave 11--
------------
/*
SELECT brandName FROM Brands
JOIN Collaborations ON Brands.brandID = Collaborations.brandID
Where duration = (SELECT MAX(duration) FROM Collaborations); 

*/
------------
--Opgave 12--
------------ 
/*
SELECT Influencers.firstName, COUNT(Collaborations.collaborationID) from Collaborations 
join influencers on collaborations.influencerID = Influencers.influencerID 
group by Influencers.firstName;
*/
------------
--Opgave 13--
------------ HJÆLP
/*
SELECT distinct brandName FROM Brands
	JOIN Collaborations ON Collaborations.brandID = Brands.brandID
	WHERE Brands.brandID IN (SELECT influencerID FROM Influencers WHERE instagramFollowers > 40000);
	*/

------------
--Opgave 14--
------------

--SELECT platfromName, averageUserAge FROM SocielMediaPlatforms

SELECT influencerID FROM Collaborations

------------
--Opgave 15--
------------


--Kommer Mere Hvis du skal bruge mere 