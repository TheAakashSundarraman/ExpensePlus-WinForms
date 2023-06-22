Create table Role(RoleID uniqueidentifier PRIMARY KEY, RoleType varchar(255), RoleName varchar(255), RoleDescription varchar(500));
GO
CREATE TABLE [GENDER](GENDERID INT IDENTITY(1,1) PRIMARY KEY, GENDERNAME VARCHAR(50))
GO
Create table [User](UserID uniqueidentifier Primary Key, FirstName varchar(255), LastName varchar(255), Email varchar(255), password nvarchar(1048), dateofbirth datetime, phonenumber varchar(100), 
RoleID uniqueidentifier, GENDERID INT , foreign key(RoleID) references Role(RoleID), FOREIGN KEY(GENDERID) REFERENCES GENDER(GENDERID));
GO
CREATE table ExpenseType(ExpenseTypeID int identity(1,1) primary key, ExpenseTypeName varchar(50), ExpenseTypeDescription varchar(255))
GO
Create table Expense(ExpenseID uniqueidentifier primary key, ExpenseName varchar(255), ExpenseDescription varchar(500), ExpenseDate datetime, ExpenseAmount decimal(18,2), 
UserID uniqueidentifier, ExpenseTypeID INT, foreign key(UserID) references [User](UserID), foreign key(ExpenseTypeID) references [ExpenseType](ExpenseTypeID));
GO
Create table InvestmentType(InvestmentTypeID INT identity(1,1) primary key, InvestmentTypeName varchar(25), InvestmentTypeDescription varchar(255))
GO
Create table Investments(InvestmentID uniqueidentifier primary key, InvestName varchar(255), InvestmentDate datetime, InvestmentAmount decimal(18,5), InvestmentDescription varchar(500), 
InvestmentValue5 decimal(18,5), InvestmentValue10 decimal(18,5), 
UserID uniqueidentifier,InvestmentTypeID int, foreign key(UserID) references [User](UserID), foreign key(InvestmentTypeID) references [InvestmentType](InvestmentTypeID));
GO
Create table InvestmentProjections(InvestmentprojectionID uniqueidentifier primary key, InvestmentProjectionYear int, InvestmentProjectionValue decimal(18,5), 
InvestmentID uniqueidentifier, foreign key(InvestmentID) references Investments(InvestmentID))
GO
CREATE table UserSecretQuestion(SecretKeyQuestionID int identity(1,1) primary key, SecretKeyQuestion nvarchar(500), SecretKeyAnswer nvarchar(1096), 
UserID uniqueidentifier, foreign key(UserID) references [User](UserID))
GO
