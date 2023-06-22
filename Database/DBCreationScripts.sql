--DROP TABLE Expense;
--GO
--DROP TABLE InvestmentProjections
--GO
--DROP TABLE Investments;
--GO
--DROP TABLE InvestmentType
--GO
--DROP TABLE [User];
--GO
--Drop table Role;
--GO
Create table Role(RoleID uniqueidentifier PRIMARY KEY, RoleType varchar(255), RoleName varchar(255), RoleDescription varchar(500));
GO
CREATE TABLE [GENDER](GENDERID INT IDENTITY(1,1) PRIMARY KEY, GENDERNAME VARCHAR(50))
GO
Create table [User](UserID uniqueidentifier Primary Key, FirstName varchar(255), LastName varchar(255), Email varchar(255), password nvarchar(1048), dateofbirth datetime, phonenumber varchar(100), RoleID uniqueidentifier foreign key references Role(RoleID), [GENDERID] INT FOREIGN KEY  REFERENCES GENDER(GENDERID));
GO
CREATE table ExpenseType(ExpenseTypeID int identity(1,1) primary key, ExpenseTypeName varchar(50), ExpenseTypeDescription varchar(255))
GO
Create table Expense(ExpenseID uniqueidentifier primary key, ExpenseName varchar(255), ExpenseDescription varchar(500), ExpenseDate datetime, ExpenseAmount decimal(18,2), UserID uniqueidentifier foreign key references [User](UserID), ExpenseTypeID INT foreign key references [ExpenseType](ExpenseTypeID));
GO
Create table InvestmentType(InvestmentTypeID INT identity(1,1) primary key, InvestmentTypeName varchar(25), InvestmentTypeDescription varchar(255))
GO
Create table Investments(InvestmentID uniqueidentifier primary key, InvestName varchar(255), InvestmentDate datetime, InvestmentAmount decimal(18,5), InvestmentDescription varchar(500), InvestmentValue5 decimal(18,5), InvestmentValue10 decimal(18,5), UserID uniqueidentifier foreign key references [User](UserID), InvestmentTypeID int foreign key references [InvestmentType](InvestmentTypeID));
GO
Create table InvestmentProjections(InvestmentprojectionID uniqueidentifier primary key, InvestmentProjectionYear int, InvestmentProjectionValue decimal(18,5), InvestmentID uniqueidentifier foreign key references Investments(InvestmentID))
GO
CREATE table UserSecretQuestion(SecretKeyQuestionID int identity(1,1) primary key, SecretKeyQuestion nvarchar(500), SecretKeyAnswer nvarchar(1096), UserID uniqueidentifier foreign key references [User](UserID))
GO
CREATE OR ALTER PROCEDURE spGetAllGender
AS
BEGIN
	SELECT * FROM GENDER
END
GO
CREATE OR ALTER Procedure spGetAllRoles
AS 
BEGIN
	SELECT * FROM Role
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spAddUser](
	@UserID uniqueidentifier,
	@Firstname varchar(255),
	@Lastname varchar(255),
	@Email varchar(255),
	@password nvarchar(1048),
	@dateofbirth datetime,
	@phonenumber varchar(100),
	@RoleID varchar(500),
	@genderID int)
AS
BEGIN
	SET NOCOUNT ON 
	INSERT INTO [User] (UserID, FirstName, LastName, Email, password, dateofbirth, phonenumber, RoleID, GENDERID) 
	values(@UserID, @Firstname, @Lastname, @Email, @password, @dateofbirth, @phonenumber, @RoleID, @genderID)
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spAddSecretKeyQuestions](
	@UserID uniqueidentifier,
	@SecretkeyQuestion nvarchar(500),
	@SecretKeyAnswer nvarchar(1096))
AS
BEGIN
	INSERT INTO UserSecretQuestion values(@SecretkeyQuestion, @SecretKeyAnswer, @UserID)
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spGetSecretKeyQuestionsForUser](
	@Email varchar(255))
AS
BEGIN
	SELECT SecretKeyQuestion,SecretKeyAnswer FROM UserSecretQuestion WHERE UserID = (SELECT UserID FROM [User] WHERE Email = @Email)
END
GO
CREATE OR ALTER PROCEDURE [dbo].[SPAuthenticate](
	@Email varchar(255),
	@password nvarchar(1048))
AS
BEGIN
	DECLARE @UserID uniqueidentifier;
	SELECT @UserID = UserID FROM [dbo].[User] WHERE Email = @Email AND [Password] = @password
	IF @UserID IS NOT NULL
	BEGIN
		SELECT UserID, FirstName, LastName, Email, Phonenumber, Dateofbirth, RoleID, GenderID FROM [dbo].[User] WHERE UserID = @UserID
	END
	ELSE
	BEGIN
		Return;
	END
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spGetInvestmentForUser](
	@UserID uniqueidentifier)
AS
BEGIN
	SELECT i.InvestmentID, InvestName 'Investment Name', InvestmentDate 'Investment Date', InvestmentAmount 'Investment Amount'
			, InvestmentDescription 'Investment Description', InvestmentValue5, InvestmentValue10, it.InvestmentTypeName 'Investment Type Name'
			,it.InvestmentTypeID, i.UserID
	FROM Investments i 
	INNER JOIN InvestmentType it on i.InvestmentTypeID = it.InvestmentTypeID
	WHERE UserID = @UserID
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spUpdateUserProfile](
	@UserID uniqueidentifier,
	@Firstname varchar(255),
	@Lastname varchar(255),
	@dateofbirth datetime,
	@phonenumber varchar(100),
	@GenderID int)
AS
BEGIN
	UPDATE [User] SET FirstName = @Firstname, LastName = @Lastname, dateofbirth = @dateofbirth, phonenumber =@phonenumber, GENDERID = @GenderID
	WHERE UserID = @UserID
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spUpdatePasswordForuser](
	@UserID uniqueidentifier,
	@password nvarchar(2096))
AS
BEGIN
	UPDATE [User] SET password = @password WHERE UserID = @UserID 
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spGetUserByEmail](
	@Email varchar(255))
AS
BEGIN
	SELECT * FROM [User] WHERE Email = @Email
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spAddInvestmentForUser](
	@UserID uniqueidentifier,
	@InvestmentID uniqueidentifier,
	@InvestmentName varchar(255), 
	@InvestmentDate datetime, 
	@InvestmentAmount decimal(18,5), 
	@InvestmentDescription varchar(500),
	@InvestmentTypeID int,
	@InvestmentValue5 decimal(18,5),
	@InvestmentValue10 decimal(18,5))
AS
BEGIN
	INSERT INTO Investments(InvestmentID,InvestName,InvestmentDate,InvestmentAmount,InvestmentDescription,InvestmentValue5, InvestmentValue10, UserID,InvestmentTypeID) 
	values(@InvestmentID, @InvestmentName, @InvestmentDate, @InvestmentAmount, @InvestmentDescription, @InvestmentValue5, @InvestmentValue10, @UserID, @InvestmentTypeID)
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spGetAllInvestmentType]
AS
BEGIN
	SELECT InvestmentTypeId, InvestmentTypeName FROM InvestmentType
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spAddInvestmentProjections](
	@InvestmentprojectionID uniqueidentifier,
	@InvestmentID uniqueidentifier,
	@InvestmentProjectionYear int, 
	@InvestmentProjectionValue decimal(18,5))
AS
BEGIN

	INSERT INTO InvestmentProjections (InvestmentprojectionID,InvestmentProjectionYear, InvestmentProjectionValue, InvestmentID) VALUES
	(@InvestmentprojectionID,@InvestmentProjectionYear, @InvestmentProjectionValue,@InvestmentID)
END
GO
CREATE OR ALTER PROCEDURE spGetInvestmentProjectionsForUser(
	@UserID uniqueidentifier)
AS
BEGIN
	select i.InvestName, ip.InvestmentProjectionYear, CONVERT(decimal(18,2), sum(InvestmentProjectionValue)) AS 'ProjectionValue'
	FROM InvestmentProjections ip
	INNER JOIN Investments i on ip.InvestmentID = i.InvestmentID
	WHERE i.UserID = @UserID
	GROUP BY InvestName, InvestmentProjectionYear
END
GO
CREATE OR ALTER PROCEDURE spGetPiechartValuesforUser(
	@UserID uniqueidentifier)
AS
BEGIN
	select i.InvestName, CONVERT(decimal(18,2),Sum(InvestmentAmount)) AS 'InvestmentAmount'
	FROM Investments i 
	WHERE UserID = @UserID
	GROUP BY InvestName
END
GO
CREATE OR ALTER PROCEDURE spGetInvestmentProjectionForInvestmentID(
	@InvestmentID uniqueidentifier)
AS
BEGIN
	SELECT InvestmentProjectionID, InvestmentProjectionYear, InvestmentProjectionValue FROM InvestmentProjections WHERE InvestmentID = @InvestmentID 
END
GO
CREATE OR ALTER PROCEDURE spUpdateInvestmentForUser(
	@UserID uniqueidentifier,
	@InvestmentID uniqueidentifier,
	@InvestName varchar(255),
	@InvestmentDescription varchar(500),
	@InvestmentDate datetime,
	@InvestmentAmount decimal(18,5),
	@InvestmentTypeID int,
	@InvestmentValue5 decimal(18,5),
	@InvestmentValue10 decimal(18,5))
AS
BEGIN
	UPDATE Investments SET InvestName = @InvestName, InvestmentDate = @InvestmentDate,InvestmentAmount= @InvestmentAmount,InvestmentDescription=@InvestmentDescription, 
		InvestmentTypeID = @InvestmentTypeID, InvestmentValue5 = @InvestmentValue5, InvestmentValue10 = @InvestmentValue10
	WHERE InvestmentID = @InvestmentID and UserID = @UserID 
END
GO
CREATE OR ALTER PROCEDURE spUpdateInvestmentProjectionsForUser(
	@InvestmentID uniqueidentifier,
	@InvestmentProjectionValue decimal,
	@InvestmentprojectionYear int)
AS
BEGIN
	UPDATE InvestmentProjections SET InvestmentProjectionValue = @InvestmentProjectionValue
	WHERE InvestmentID = @InvestmentID and InvestmentProjectionYear = @InvestmentprojectionYear
END
GO
CREATE OR ALTER PROCEDURE spDeleteInvestment(
	@InvestmentID uniqueidentifier,
	@UserID uniqueidentifier)
AS
BEGIN
	BEGIN TRAN
		DELETE FROM InvestmentProjections WHERE InvestmentID = @InvestmentID 
		DELETE FROM Investments WHERE InvestmentID = @InvestmentID and UserID = @UserID
	COMMIT
END
GO
CREATE OR ALTER PROCEDURE spGetAllExpenseTypes
AS
BEGIN
	SELECT ExpenseTypeID, ExpenseTypeName, ExpenseTypeDescription FROM ExpenseType
END
GO
CREATE OR ALTER PROCEDURE spGetAllExpensesForUser(
	@UserID uniqueidentifier)
AS
BEGIN
	SELECT ExpenseID,ExpenseName 'Expense Name',et.ExpenseTypeName 'Expense Type Name',ExpenseDescription 'Expense Description',ExpenseDate 'Expense Date',ExpenseAmount 'Expense Amount', ep.ExpenseTypeID
	FROM Expense ep
	INNER JOIN ExpenseType et on ep.ExpenseTypeID = et.ExpenseTypeID
	WHERE UserID = @UserID
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spAddExpenseForUser](
	@UserID uniqueidentifier,
	@ExpenseID uniqueidentifier,
	@ExpenseName varchar(255), 
	@ExpenseDate datetime, 
	@ExpenseAmount decimal(18,5), 
	@ExpenseDescription varchar(500),
	@ExpenseTypeID int)
AS
BEGIN
	INSERT INTO Expense(ExpenseID,ExpenseName,ExpenseDescription,ExpenseDate,ExpenseAmount,UserID, ExpenseTypeID) 
	values(@ExpenseID, @ExpenseName, @ExpenseDescription, @ExpenseDate, @ExpenseAmount, @UserID, @ExpenseTypeID)
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spUpdateExpensesForUser](
	@ExpenseID uniqueidentifier,
	@UserID uniqueidentifier,
	@ExpenseName varchar(255),
	@ExpenseDate datetime,
	@ExpenseAmount decimal(18,5),
	@ExpenseDescription varchar(500),
	@ExpenseTypeID int)
AS
BEGIN
	UPDATE Expense SET ExpenseName = @ExpenseName, ExpenseDescription = @ExpenseDescription, ExpenseDate = @ExpenseDate, ExpenseAmount = @ExpenseAmount, 
	ExpenseTypeID = @ExpenseTypeID WHERE ExpenseID = @ExpenseID and UserID = @UserID
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spDeleteExpenseForUser](
	@ExpenseID uniqueidentifier,
	@UserID uniqueidentifier)
AS
BEGIN
	DELETE FROM Expense WHERE ExpenseID = @ExpenseID and UserID = @UserID
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spGetExpensePieChart](
	@UserID uniqueidentifier)
AS
BEGIN
	SELECT ExpenseName, SUM(ExpenseAmount) AS 'ExpenseAmount' FROM Expense WHERE UserID = @UserID
	GROUP BY ExpenseName
END
GO
CREATE OR ALTER PROCEDURE [dbo].[spGetAllStockNamesForUser](
	@UserID uniqueidentifier)
AS
BEGIN
	SELECT DISTINCT InvestName 
	FROM Investments i
	INNER JOIN InvestmentType it on i.InvestmentTypeID = it.InvestmentTypeID and it.InvestmentTypeName = 'Stock'
	WHERE USERID = @UserID
END
GO
INSERT INTO Role Values(NEWID(), 'SD', 'Standard','Standard Users');
INSERT INTO Role Values(NEWID(), 'AD', 'Admin','Administration');
INSERT INTO GENDER VALUES('Male');
INSERT INTO GENDER VALUES('Female');
INSERT INTO GENDER VALUES('Other');
INSERT INTO InvestmentType values('Stock', 'Stock investment');
INSERT INTO InvestmentType values('Crypto', 'CryptoCurrency');
INSERT INTO InvestmentType values('Movable assets', 'Movable assets');
INSERT INTO InvestmentType values('Immovable assets', 'Immovable assets');
INSERT INTO InvestmentType values('Salary', 'Salary');
INSERT INTO InvestmentType values('Business Income', 'Income from private business');
INSERT INTO InvestmentType values('Advertisements', 'Investment from advertisements');
INSERT INTO InvestmentType values('Hedge Funds', 'Investment from hedge funds');
INSERT INTO InvestmentType values('Prize money', 'prize money');
INSERT INTO InvestmentType values('Lottery', 'Lottery');
INSERT INTO InvestmentType values('Gambling', 'Gambling');
INSERT INTO InvestmentType values('Equity', 'Equity');
INSERT INTO ExpenseType values('Rent', 'Rent');
INSERT INTO ExpenseType values('Loans - Credit card', 'Credit card payments');
INSERT INTO ExpenseType values('Loans - Home loan', 'Home loan');
INSERT INTO ExpenseType values('Loans - Vehicle loan', 'Vehicle loan');
INSERT INTO ExpenseType values('Loans - Personal loan', 'Personal loan');
INSERT INTO ExpenseType values('Utilities - Electricity', 'Electricity');
INSERT INTO ExpenseType values('Utilities - Water', 'Water');
INSERT INTO ExpenseType values('Utilities - Internet', 'Internet');
INSERT INTO ExpenseType values('Utilities - Mobile plan', 'Mobile bill');
INSERT INTO ExpenseType values('Insurance - Vehicle Insurance', 'Vehicle Insurance');
INSERT INTO ExpenseType values('Insurance - Home insurance', 'Home insurance');
INSERT INTO ExpenseType values('Insurance - Life insurance', 'Life insurance');
INSERT INTO ExpenseType values('Insurance - Health Insurance', 'Health Insurance');
INSERT INTO ExpenseType values('Medical expenses', 'Medical expenses');
INSERT INTO ExpenseType values('Automotive expenses', 'Automotive expenses such as petrol / diesel etc');
INSERT INTO ExpenseType values('Shopping - Groceries', 'Groceries');
INSERT INTO ExpenseType values('Shopping - Personal', 'Personal shopping');
INSERT INTO ExpenseType values('Food - Dine in', 'Dine in');
INSERT INTO ExpenseType values('Food - Takeout', 'Take outs');
INSERT INTO ExpenseType values('Others', 'Others');
