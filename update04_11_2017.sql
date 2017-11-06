create database BanHang3
	GO
use BanHang3 --Use QuanLyBanHang Database--
	GO
--Account--consist of Admin Account and Staff Acount--
--StaffInfo--
--Bill--
--Customer--
--Product--
------------------------------------------------------
CREATE TABLE Account
(
	AccountID int identity  primary key,
	username nvarchar(100) not null,
	displayname nvarchar(100) not null,
	password nvarchar(100) not null,
	type int not null
)
	Go
------------------------------------------------------
CREATE TABLE StaffInfo
(
	StaffID int identity primary key,
	StaffName nvarchar(100) not null,
	StaffSex nvarchar(100) not null,
	StaffBirth date not null,
	StaffAddress nvarchar(100) not null,
	StaffPhone text not null
)
	Go
-------------------------------------------------------
CREATE TABLE Product
(
	ProductID int identity primary key,--Mã sản phẩm--
	ProductName nvarchar(100) not null,
	ProductPrice float not null,
	ProductDateIn date not null,--Ngay nhap san pham vao cua hang--
--	ProductDateOut date not null,--Ngay ban san pham cho khach--
)	
	Go
------------------------------------------------------
CREATE TABLE Bill
(
	BillID int identity primary key,
	BillCustumerID int not null,
	BillStaffID int not null,--Mã nhân viên tính tiền--
	BillDate date not null,
	BillPrice float not null,
	FOREIGN KEY (BillStaffID) REFERENCES dbo.StaffInfo(StaffID),--Mã nhân viên tính tiền bắt buộc phải tồn tại trong StaffID-
	FOREIGN KEY (BillCustumerID) REFERENCES dbo.Customer(CustomerID),
)
	Go
------------------------------------------------------
CREATE TABLE BillDetail
(
	BillDetailID int not null,
	BillDetailProduct int not null,--Mã sản phẩm trong bill phải có trong dbo.Product--
	BillDetailQuantity int not null,
	FOREIGN KEY (BillDetailProduct) REFERENCES dbo.Product(ProductID),--Sản phần trong Bill phải có tồn tại trong mục Product--
	FOREIGN KEY (BillDetailID) REFERENCES dbo.Bill(BillID),
)
	Go
----------------------------------------------------------
CREATE TABLE Customer
(
	CustomerID int identity primary key,
	CustomerName nvarchar(100) not null,
	CustomerAddress nvarchar(100) not null,
	CustomerPhone text not null,
--	CustomerBill int not null
--	FOREIGN KEY (CustomerBill) REFERENCES dbo.Bill(BillID)--Mã hóa đơn của khách hành phải tồn tại trong mục Bill--
)
	Go
--Avoid SQL Injection--
CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
	Go