DROP TABLE IF EXISTS Person;
DROP TABLE IF EXISTS Animal;

CREATE TABLE Person (
Name VARCHAR(100) NOT NULL,
City VARCHAR(64) NOT NULL,
State VARCHAR(2) NOt NULL,
Country VARCHAR(3) NOT NULL
);

CREATE TABLE Animal (
AnimalID VARCHAR(32) NOT NULL PRIMARY KEY,
Name VARCHAR(128) NOT NULL,
Breed VARCHAR(64) NOT NULL,
Species VARCHAR(16) NOT NULL,
RegNum VARCHAR(32),
PersonID INT NOT NULL,
FOREIGN KEY (PersonID) REFERENCES kabsu.person (PersonID)
);

