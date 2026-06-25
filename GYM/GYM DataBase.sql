CREATE DATABASE GYM;

--Tables--

--Member Table--
--CREATE TABLE -- MEMBER(---
--EMP INTNOT NULL ,--
--MemberName --VARCHAR--(2000) NOT NULL ,
--FatherName VARCHAR(2000) DEFAULT 'NULL',
--Contactno VARCHAR(2000) DEFAULT 'NULL',
--Add_ress VARCHAR(5000) DEFAULT 'NULL',
--Weigh VARCHAR(2000) DEFAULT 'NULL',
--HeightFT INT DEFAULT 'NULL',
--HeightIN INT DEFAULT 'NULL',
--Purpose VARCHAR(2000) DEFAULT 'NULL',
--Admissionfee MONEY DEFAULT 'NULL',
--DateOfJoining DATE,
--Gender VARCHAR(2000) DEFAULT 'NULL',
--Category VARCHAR(2000) NOT NULL
--CONSTRAINT MEMBERPK PRIMARY KEY(MemberID)
--
DELETE FROM MEMBER 
SELECT * FROM MEMBER
INSERT INTO MEMBER(MemberID, MemberName, Gender,DateOfJoining, Add_ress, Contactno, Weigh , HeightFT, HeightIN,FatherName,Purpose,Admissionfee,Category)
VALUES
(1,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(2,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(3,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(4,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(5,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(6,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(7,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(8,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(9,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(10,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(11,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(12,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(13,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(14,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(15,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(16,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(17,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(18,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(19,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(20,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(21,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student'),
(22,'a','NULL','2023/2/2','NULL','NULL','NULL',0,0,'NULL','NULL',0,'Student')
;

--Trainer Table--
CREATE TABLE TRAINER(
TrainerID INT NOT NULL,
TrainerName VARCHAR(2000) NOT NULL,
Add_ress VARCHAR(5000) NOT NULL,
Contactno VARCHAR(2000) NOT NULL,
YrsofExperience VARCHAR(2000) DEFAULT 'NULL',
DateOfJoining DATE,
CONSTRAINT TRAINERPK PRIMARY KEY(TrainerID)
)
SELECT * FROM TRAINER

--PackageLINE Table--
CREATE TABLE PACKAGE_LINE(
PackageID INT NOT NULL IDENTITY(1,1), 
kategory VARCHAR(2000) NOT NULL,
PackageName VARCHAR(2000) NOT NULL,
Duration VARCHAR(2000) NOT NULL,
Price MONEY NOT NULL
CONSTRAINT PACKAGE_LINEPK PRIMARY KEY(PackageID)
)
DELETE FROM PACKAGE_LINE
SELECT * FROM PACKAGE_LINE
INSERT INTO PACKAGE_LINE VALUES
('Student','Student 1 month without Treadmill[1500 / RS]','1Month','1500'),
('Student','Student 1 month with Treadmill [2300/RS]','1Month','2300'),
('Student','Student 2 month without Treadmill [2700/RS]','2Month','2700'),
('Student','Student 4 month without Treadmill [4600/RS]','4Month','4600'),
('Student','Student 6 month without Treadmill [7000/RS]','6Month','7000'),
('Student','Student 12 month without Treadmill [14200/RS]','12Month','14200'),
('Non Student','Non-Student 1 month without Treadmill [1700/RS]','1Month','1700'),
('Non Student','Non-Student 1 month with Treadmill [2500/RS]','1Month','2500'),
('Non Student','Non-Student 2 month without Treadmill [2900/RS]','2Month','2900'),
('Non Student','Non-Student 4 month without Treadmill [4800/RS]','4Month','4800'),
('Non Student','Non-Student 6 month without Treadmill [7200/RS]','6Month','7200'),
('Non Student','Non-Student 12 month without Treadmill [14400/RS]','12Month','14400')
;
--DELETE FROM PACKAGELINE WHERE PackageID=

--Package Table--
CREATE TABLE PACKAGE(
PackageID INT NOT NULL,
MemberID INT NOT NULL,
CONSTRAINT PACKAGEFK1 FOREIGN KEY(PackageID) REFERENCES PACKAGE_LINE(PackageID),
CONSTRAINT PACKAGEFK2 FOREIGN KEY(MemberID) REFERENCES MEMBER(MemberID)
)
SELECT * FROM PACKAGE
DELETE FROM PACKAGE
SELECT PACKAGE_LINE.Price,PACKAGE_LINE.PackageName FROM ((MEMBER RIGHT JOIN PACKAGE ON MEMBER.MemberID = PACKAGE.MemberID) RIGHT JOIN PACKAGE_LINE ON PACKAGE_LINE.PackageID = PACKAGE.PackageID)

INSERT INTO PACKAGE VALUES
(1,1),
(2,2),
(2,3),
(6,4),
(3,5),
(4,6),
(1,7),
(2,8),
(5,9),
(6,10),
(3,11),
(4,12),
(5,13),
(6,14),
(1,15),
(1,16),
(1,17),
(1,18),
(1,19),
(1,20),
(1,21),
(1,22);



--Salary Table--
CREATE TABLE SALARY(
TrainerID INT NOT NULL,
PayID INT NOT NULL
CONSTRAINT SALARYfk1 FOREIGN KEY(TrainerID) REFERENCES TRAINER(TrainerID)
ON UPDATE CASCADE
ON DELETE CASCADE,
CONSTRAINT SALARYfk2 FOREIGN KEY(PayID) REFERENCES PAYLINE(PayID)
)
SELECT * FROM SALARY

--Pay Table--
CREATE TABLE PAYLINE(
PayID INT NOT NULL IDENTITY(1,1),
PayTittle VARCHAR(2000) NOT NULL,
PayAmount MONEY NOT NULL
CONSTRAINT PAYPK PRIMARY KEY(PayID)
)
SELECT * FROM SALARY

--Salary Transaction--
CREATE TABLE Salary_Transaction(
TransactionID INT NOT NULL IDENTITY(1,1),
TrainerID INT NOT NULL,
Remaining_salary MONEY,
Amount_paid MONEY NOT NULL,
Date_transaction DATE,
Served_by VARCHAR(2000), 
CONSTRAINT Salary_TransactionPK PRIMARY KEY(TransactionID),
CONSTRAINT Salary_TransactionFK FOREIGN KEY(TrainerID) REFERENCES TRAINER(TrainerID)
ON UPDATE CASCADE
ON DELETE CASCADE
)

--Fee Table--
CREATE TABLE FEE(
FeeID INT NOT NULL IDENTITY(1,1),
MemberID INT NOT NULL,
Date_fee_paid DATE NOT NULL,
Amount_paid MONEY NOT NULL,
Served_by VARCHAR(2000),
Remaining_dues MONEY 
CONSTRAINT FEEPK PRIMARY KEY(FeeID),
CONSTRAINT FEEFK1 FOREIGN KEY(MemberID) REFERENCES MEMBER(MemberID)
ON UPDATE CASCADE
ON DELETE CASCADE
)
SELECT * FROM FEE
DELETE FROM FEE 

INSERT INTO FEE 
VALUES
(9,'2023/2/2',1000,'ADMIN',0),
(1,'2023/2/2',1220,'ADMIN',212),
(3,'2023/2/2',1200,'ADMIN',0),
(6,'2023/2/2',1700,'ADMIN',0),
(10,'2023/2/2',1180,'ADMIN',500);

--Train Table--
CREATE TABLE TRAIN(
TrainerID INT NOT NULL,
MemberID INT NOT NULL
CONSTRAINT TRAINFK1 FOREIGN KEY(TrainerID) REFERENCES TRAINER(TrainerID)
ON UPDATE CASCADE
ON DELETE CASCADE,
CONSTRAINT TRAINFK2 FOREIGN KEY(MemberID) REFERENCES MEMBER(MemberID),
CONSTRAINT TRAINPK PRIMARY KEY(TrainerID,MemberID)
)
SELECT * FROM TRAIN

--End TABLES--

