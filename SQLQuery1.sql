--Account--
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'User',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
--Staff Information-
create table staffinfo
(
stt int not null identity(1,1),--start with 1 values and increase by 1 for each time.
name nvarchar(100) not null,
sex nvarchar(100) not null,
dataofbirth date not null,
address nvarchar(100) not null,
phonenumber text not null,
)
--reset the auton increasement--
--Avoid SQL Injection--
CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END

